namespace Ex3.forms.main.OrderOperation
{
    partial class CreateOrder
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
            this.gvMaterials = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMaterials
            // 
            this.gvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMaterials.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvMaterials.Location = new System.Drawing.Point(0, 300);
            this.gvMaterials.Name = "gvMaterials";
            this.gvMaterials.RowHeadersWidth = 51;
            this.gvMaterials.RowTemplate.Height = 27;
            this.gvMaterials.Size = new System.Drawing.Size(800, 150);
            this.gvMaterials.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDescription.Location = new System.Drawing.Point(0, 150);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(800, 150);
            this.txtDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(-3, 132);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(166, 15);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "描述（不多于200字）：";
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.AutoSize = true;
            this.btnAddMaterial.Location = new System.Drawing.Point(375, 79);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(77, 25);
            this.btnAddMaterial.TabIndex = 3;
            this.btnAddMaterial.Text = "添加材料";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.AutoSize = true;
            this.btnCreateOrder.Location = new System.Drawing.Point(590, 79);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(77, 25);
            this.btnCreateOrder.TabIndex = 4;
            this.btnCreateOrder.Text = "生成订单";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.gvMaterials);
            this.Name = "CreateOrder";
            this.Text = "创建订单";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateOrder_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMaterials;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.Button btnCreateOrder;
    }
}