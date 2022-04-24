--USE master
--DROP DATABASE Ex3
--GO

CREATE DATABASE Ex3 ON (
    NAME = Ex3,
    FILENAME = 'E:\Projects\NET\SoftwareEngineering\Ex3\static\Ex3.mdf',
    SIZE = 5MB,
    MAXSIZE = 50MB,
    FILEGROWTH = 1MB
) LOG ON(
    NAME = MyPetShop_log,
    FILENAME = 'E:\Projects\NET\SoftwareEngineering\Ex3\static\Ex3.ldf',
    SIZE = 3MB,
    MAXSIZE = 25MB,
    FILEGROWTH = 1MB
) COLLATE Chinese_PRC_CS_AS;
GO

USE Ex3
GO

-- DECLARE @MIN_PHONE_LEN INT, @MAX_PHONE_LEN INT
-- SELECT @MIN_PHONE_LEN=11, @MAX_PHONE_LEN=15
-- 
-- DECLARE @MAX_PERSON_NAME_LEN INT, @MAX_EMAIL_LEN INT
-- SELECT @MAX_PERSON_NAME_LEN=20, @MAX_EMAIL_LEN=20
-- GO

CREATE FUNCTION [isPhoneValid](@phone NVARCHAR(15))
RETURNS BIT
BEGIN
    DECLARE @len INT
    IF @phone is NULL RETURN 0

    SET @len = LEN(@phone)
    RETURN CASE WHEN @len=11 OR @len=15 THEN 1 ELSE 0 END
END
GO

CREATE TABLE [Manufacturer] (    -- 生产厂商
    [id] INT IDENTITY(1, 1) PRIMARY KEY,    -- 生产厂商编号
    [name] NVARCHAR(40) NOT NULL    -- 生产厂商名
)
CREATE TABLE [Supplier] (    -- 供货商
    [id] INT IDENTITY(1, 1) PRIMARY KEY,    -- 供货商编号
    [name] NVARCHAR(40) NOT NULL,    -- 供货商名
    [principalName] NVARCHAR(20) NOT NULL,    -- 负责人名
    [principalPhone] VARCHAR(15),    -- 负责人手机
    [principalEmail] VARCHAR(20),    -- 负责人邮箱

    -- 电话和邮件至少有一个不为NULL
    CHECK(dbo.isPhoneValid([principalPhone])=1 OR ([principalEmail] IS NOT NULL))
)
CREATE TABLE [ManSupCoop] (    -- 生产厂商与供货商是否合作
    [manId] INT FOREIGN KEY REFERENCES [Manufacturer],    -- 生产厂商编号
    [supId] INT FOREIGN KEY REFERENCES [Supplier],    -- 供货商编号

    PRIMARY KEY([manId], [supId])
)

CREATE TABLE [Material] (    -- 材料
    [id] INT IDENTITY(1, 1) PRIMARY KEY,    -- 材料编号
    [manId] INT FOREIGN KEY REFERENCES [Manufacturer],    -- 生产厂商编号
    [model] NVARCHAR(20) NOT NULL,    -- 型号
    [name] NVARCHAR(20) NOT NULL,    -- 材料名
    [amount] INT NOT NULL DEFAULT 0 CHECK([amount]>=0),    -- 数量
    [warningAmount] INT NOT NULL DEFAULT 0 CHECK([warningAmount]>=0)    -- 库存预警数量
)
CREATE TABLE [User] (    -- 用户，即进货负责人
    [id] INT IDENTITY(1,1) PRIMARY KEY,    -- 用户编号
    [account] VARCHAR(16) UNIQUE,    -- 账号
    [password] VARCHAR(20) NOT NULL,    -- 密码
    [name] NVARCHAR(20) NOT NULL,    -- 姓名
    [phone] VARCHAR(15) NOT NULL CHECK(dbo.isPhoneValid([phone])=1),    -- 手机
    [email] VARCHAR(20) NOT NULL    -- 邮箱
)
CREATE TABLE [Order] (    -- 订单
    [id] VARCHAR(16) PRIMARY KEY,    -- 订单号
    [state] TINYINT NOT NULL DEFAULT 0 CHECK([state] BETWEEN 0 AND 2),    -- 订单状态{0:未批准, 1:进行中, 2:已完成}
    [description] NVARCHAR(200),
    [principalId] INT FOREIGN KEY REFERENCES [User],    -- 负责人（用户）编号
    [totalPrice] INT NOT NULL CHECK([totalPrice]>=0),    -- 总价格
    [finalPrice] INT NOT NULL CHECK([finalPrice]>=0),    -- 最终成交价
    [genDate] DATETIME NOT NULL,    -- 订单生成日期
    [approveDate] DATETIME,    -- 订单批准日期
    [finishDate] DATETIME    -- 订单完成日期
)
CREATE TABLE [UnfinishedRecord] (    -- 未完成的记录
    [orderId] VARCHAR(16) FOREIGN KEY REFERENCES [Order],    -- 所属订单号
    [matId] INT FOREIGN KEY REFERENCES [Material],    -- 材料编号
    [supId] INT FOREIGN KEY REFERENCES [Supplier],    -- 供货商编号
    [amount] INT NOT NULL DEFAULT 0 CHECK([amount]>=0),    -- 到手数量
    [expectAmount] INT NOT NULL CHECK([expectAmount]>0),    -- 应到数量

    PRIMARY KEY([orderId],[matId],[supId])
)
CREATE TABLE [EntryRecord] (    -- 单个材料的入库记录
    [orderId] VARCHAR(16) FOREIGN KEY REFERENCES [Order],    -- 所属订单号
    [matId] INT FOREIGN KEY REFERENCES [Material],    -- 材料编号
    [supId] INT FOREIGN KEY REFERENCES [Supplier],    -- 供货商编号
    [amount] INT NOT NULL CHECK([amount]>0),    -- 入库数量
    [price] DECIMAL(11,2) NOT NULL CHECK([price]>=0),    -- 最大数值记录为亿
    [finalPrice] DECIMAL(11,2) NOT NULL CHECK([finalPrice]>=0),    -- 最终成交价
    [entryDate] DATETIME NOT NULL,    -- 入库时间

    PRIMARY KEY([orderId],[matId],[supId])
)
GO

CREATE TRIGGER [Tri_UnfinishedRecord]
ON [UnfinishedRecord]
AFTER UPDATE
AS BEGIN
    DECLARE @afterAmount INT    -- 更新后的材料数量
    SET @afterAmount=(SELECT [amount] FROM [inserted])

    -- 材料的数量到达应到数量后，删除其在本表中的记录
    IF @afterAmount>=(SELECT [expectAmount] FROM [inserted])
    BEGIN
        -- 如果这是其所属订单的最后一条记录，则在删除前将订单的状态改为已完成（Order.state=>2）
        IF 1=(SELECT COUNT([u].[orderId]) FROM [UnfinishedRecord] AS [u],[inserted] WHERE [u].[orderId]=[inserted].[orderId])
            UPDATE [Order] SET [state]=2 FROM [inserted] WHERE [Order].[id]=[inserted].[orderId]

        DELETE [UnfinishedRecord] FROM [inserted]
    END
END
GO
--ENABLE TRIGGER Tri_UnfinishedRecord ON [UnfinishedRecord]
GO

CREATE TRIGGER [Tri_EntryRecord]
ON [EntryRecord]
INSTEAD OF INSERT
AS BEGIN
    BEGIN TRY
        -- 不能为未批准或已完成的订单作入库
        IF (SELECT [state] FROM [Order] WHERE [id]=(SELECT [orderId] FROM [inserted]))!=1
            RAISERROR(60001,16,1)
    END TRY
    BEGIN CATCH
        IF @@ERROR=60001 
            PRINT '不能为未批准或已完成的订单作入库'
        ROLLBACK TRANSACTION
        RETURN
    END CATCH

    -- 触发[UnfinishedRecord]的UPDATE触发器Tri_UnfinishedRecord
    UPDATE [u]
        SET [u].[amount]=[u].[amount]+(SELECT [amount] FROM [i])
        FROM [UnfinishedRecord] AS [u], [inserted] AS [i]
        WHERE [u].[orderId]=[i].[orderId]
            AND [u].[matId]=[i].[matId]
            AND [u].[supId]=[i].[supId]
END
GO
ENABLE TRIGGER Tri_EntryRecord ON [EntryRecord]
GO

INSERT INTO [User] ([account],[password],[name],[phone],[email])
    SELECT 'root','123456','Mind','01234567890','123@email.com'
INSERT INTO [Manufacturer] ([name])
    SELECT '生产厂商A'
    UNION SELECT '生产厂商B'
INSERT INTO [Supplier] ([name],[principalName],[principalPhone],[principalEmail])
    SELECT '供货商A','张三','13612345678',null
    UNION SELECT '供货商B','李四',null,'123@email.com'
INSERT INTO [ManSupCoop] ([manId],[supId])
    SELECT 1,1
    UNION SELECT 1,2
    UNION SELECT 2,1
INSERT INTO [Material] ([manId],[model],[name],[amount],[warningAmount])
    SELECT 1,'A-1','材料A-1',100,50
    UNION SELECT 1,'A-2','材料A-2',50,50
    UNION SELECT 1,'A-3','材料A-3',10,100
    UNION SELECT 2,'B-1','材料B-1',50,70
    UNION SELECT 2,'B-2','材料B-2',120,80
GO
