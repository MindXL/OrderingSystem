namespace Ex3.forms.main
{
    partial class Inventory
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
            this.components = new System.ComponentModel.Container();
            this.gvInventory = new System.Windows.Forms.DataGridView();
            this.cms_gvInventoryCell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWarn = new System.Windows.Forms.Button();
            this.btnShowInventory = new System.Windows.Forms.Button();
            this.lblMatNum = new System.Windows.Forms.Label();
            this.btnShowOrderDlg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).BeginInit();
            this.cms_gvInventoryCell.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvInventory
            // 
            this.gvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInventory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvInventory.Location = new System.Drawing.Point(0, 150);
            this.gvInventory.Name = "gvInventory";
            this.gvInventory.ReadOnly = true;
            this.gvInventory.RowHeadersWidth = 51;
            this.gvInventory.Size = new System.Drawing.Size(800, 300);
            this.gvInventory.TabIndex = 0;
            this.gvInventory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GvInventory_CellMouseClick);
            // 
            // cms_gvInventoryCell
            // 
            this.cms_gvInventoryCell.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_gvInventoryCell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOrder});
            this.cms_gvInventoryCell.Name = "cms_gvInventory";
            this.cms_gvInventoryCell.Size = new System.Drawing.Size(139, 28);
            // 
            // createOrder
            // 
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(138, 24);
            this.createOrder.Text = "生成订单";
            this.createOrder.Click += new System.EventHandler(this.createOrder_Click);
            // 
            // btnWarn
            // 
            this.btnWarn.AutoSize = true;
            this.btnWarn.ForeColor = System.Drawing.Color.Red;
            this.btnWarn.Location = new System.Drawing.Point(209, 51);
            this.btnWarn.Name = "btnWarn";
            this.btnWarn.Size = new System.Drawing.Size(77, 25);
            this.btnWarn.TabIndex = 1;
            this.btnWarn.Text = "库存预警";
            this.btnWarn.UseVisualStyleBackColor = true;
            this.btnWarn.Click += new System.EventHandler(this.btnWarn_Click);
            // 
            // btnShowInventory
            // 
            this.btnShowInventory.AutoSize = true;
            this.btnShowInventory.Location = new System.Drawing.Point(42, 51);
            this.btnShowInventory.Name = "btnShowInventory";
            this.btnShowInventory.Size = new System.Drawing.Size(137, 25);
            this.btnShowInventory.TabIndex = 2;
            this.btnShowInventory.Text = "查看库存（刷新）";
            this.btnShowInventory.UseVisualStyleBackColor = true;
            this.btnShowInventory.Click += new System.EventHandler(this.btnShowInventory_Click);
            // 
            // lblMatNum
            // 
            this.lblMatNum.AutoSize = true;
            this.lblMatNum.Location = new System.Drawing.Point(-3, 132);
            this.lblMatNum.Name = "lblMatNum";
            this.lblMatNum.Size = new System.Drawing.Size(82, 15);
            this.lblMatNum.TabIndex = 3;
            this.lblMatNum.Text = "显示数量：";
            // 
            // btnShowOrderDlg
            // 
            this.btnShowOrderDlg.AutoSize = true;
            this.btnShowOrderDlg.Location = new System.Drawing.Point(680, 52);
            this.btnShowOrderDlg.Name = "btnShowOrderDlg";
            this.btnShowOrderDlg.Size = new System.Drawing.Size(77, 25);
            this.btnShowOrderDlg.TabIndex = 4;
            this.btnShowOrderDlg.Text = "查看订单";
            this.btnShowOrderDlg.UseVisualStyleBackColor = true;
            this.btnShowOrderDlg.Click += new System.EventHandler(this.btnShowOrderDlg_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowOrderDlg);
            this.Controls.Add(this.lblMatNum);
            this.Controls.Add(this.btnShowInventory);
            this.Controls.Add(this.btnWarn);
            this.Controls.Add(this.gvInventory);
            this.Name = "Inventory";
            this.Text = "库存";
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).EndInit();
            this.cms_gvInventoryCell.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DataGridView gvInventory;
        private System.Windows.Forms.ContextMenuStrip cms_gvInventoryCell;
        private System.Windows.Forms.ToolStripMenuItem createOrder;
        private System.Windows.Forms.Button btnWarn;
        private System.Windows.Forms.Button btnShowInventory;
        private System.Windows.Forms.Label lblMatNum;
        private System.Windows.Forms.Button btnShowOrderDlg;
    }
}