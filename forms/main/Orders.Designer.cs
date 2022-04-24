namespace Ex3.forms.main
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvOrder = new System.Windows.Forms.DataGridView();
            this.lblOrdNum = new System.Windows.Forms.Label();
            this.btnShowAllOrder = new System.Windows.Forms.Button();
            this.btnShowUnauthorized = new System.Windows.Forms.Button();
            this.btnShowUnfinished = new System.Windows.Forms.Button();
            this.btnShowFinished = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnShowInventoryDlg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // gvOrder
            // 
            this.gvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvOrder.Location = new System.Drawing.Point(0, 150);
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.ReadOnly = true;
            this.gvOrder.RowHeadersWidth = 51;
            this.gvOrder.RowTemplate.Height = 27;
            this.gvOrder.Size = new System.Drawing.Size(800, 300);
            this.gvOrder.TabIndex = 0;
            // 
            // lblOrdNum
            // 
            this.lblOrdNum.AutoSize = true;
            this.lblOrdNum.Location = new System.Drawing.Point(0, 129);
            this.lblOrdNum.Name = "lblOrdNum";
            this.lblOrdNum.Size = new System.Drawing.Size(82, 15);
            this.lblOrdNum.TabIndex = 1;
            this.lblOrdNum.Text = "显示数量：";
            // 
            // btnShowAllOrder
            // 
            this.btnShowAllOrder.AutoSize = true;
            this.btnShowAllOrder.Location = new System.Drawing.Point(14, 22);
            this.btnShowAllOrder.Name = "btnShowAllOrder";
            this.btnShowAllOrder.Size = new System.Drawing.Size(167, 25);
            this.btnShowAllOrder.TabIndex = 2;
            this.btnShowAllOrder.Text = "显示所有订单（刷新）";
            this.btnShowAllOrder.UseVisualStyleBackColor = true;
            this.btnShowAllOrder.Click += new System.EventHandler(this.BtnShowAllOrder_Click);
            // 
            // btnShowUnauthorized
            // 
            this.btnShowUnauthorized.AutoSize = true;
            this.btnShowUnauthorized.Location = new System.Drawing.Point(280, 22);
            this.btnShowUnauthorized.Name = "btnShowUnauthorized";
            this.btnShowUnauthorized.Size = new System.Drawing.Size(92, 25);
            this.btnShowUnauthorized.TabIndex = 3;
            this.btnShowUnauthorized.Text = "未批准订单";
            this.btnShowUnauthorized.UseVisualStyleBackColor = true;
            this.btnShowUnauthorized.Click += new System.EventHandler(this.BtnShowUnauthorized_Click);
            // 
            // btnShowUnfinished
            // 
            this.btnShowUnfinished.AutoSize = true;
            this.btnShowUnfinished.Location = new System.Drawing.Point(399, 22);
            this.btnShowUnfinished.Name = "btnShowUnfinished";
            this.btnShowUnfinished.Size = new System.Drawing.Size(92, 25);
            this.btnShowUnfinished.TabIndex = 4;
            this.btnShowUnfinished.Text = "未完成订单";
            this.btnShowUnfinished.UseVisualStyleBackColor = true;
            this.btnShowUnfinished.Click += new System.EventHandler(this.BtnShowUnfinished_Click);
            // 
            // btnShowFinished
            // 
            this.btnShowFinished.AutoSize = true;
            this.btnShowFinished.Location = new System.Drawing.Point(522, 22);
            this.btnShowFinished.Name = "btnShowFinished";
            this.btnShowFinished.Size = new System.Drawing.Size(92, 25);
            this.btnShowFinished.TabIndex = 5;
            this.btnShowFinished.Text = "已完成订单";
            this.btnShowFinished.UseVisualStyleBackColor = true;
            this.btnShowFinished.Click += new System.EventHandler(this.BtnShowFinished_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.AutoSize = true;
            this.btnCreateOrder.Location = new System.Drawing.Point(14, 78);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(77, 25);
            this.btnCreateOrder.TabIndex = 6;
            this.btnCreateOrder.Text = "创建订单";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.BtnCreateOrder_Click);
            // 
            // btnShowInventoryDlg
            // 
            this.btnShowInventoryDlg.AutoSize = true;
            this.btnShowInventoryDlg.Location = new System.Drawing.Point(713, 23);
            this.btnShowInventoryDlg.Name = "btnShowInventoryDlg";
            this.btnShowInventoryDlg.Size = new System.Drawing.Size(77, 25);
            this.btnShowInventoryDlg.TabIndex = 7;
            this.btnShowInventoryDlg.Text = "查看库存";
            this.btnShowInventoryDlg.UseVisualStyleBackColor = true;
            this.btnShowInventoryDlg.Click += new System.EventHandler(this.BtnShowInventoryDlg_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowInventoryDlg);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnShowFinished);
            this.Controls.Add(this.btnShowUnfinished);
            this.Controls.Add(this.btnShowUnauthorized);
            this.Controls.Add(this.btnShowAllOrder);
            this.Controls.Add(this.lblOrdNum);
            this.Controls.Add(this.gvOrder);
            this.Name = "Orders";
            this.Text = "订单";
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvOrder;
        private System.Windows.Forms.Label lblOrdNum;
        private System.Windows.Forms.Button btnShowAllOrder;
        private System.Windows.Forms.Button btnShowUnauthorized;
        private System.Windows.Forms.Button btnShowUnfinished;
        private System.Windows.Forms.Button btnShowFinished;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnShowInventoryDlg;
    }
}