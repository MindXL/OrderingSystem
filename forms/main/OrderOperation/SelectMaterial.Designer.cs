namespace Ex3.forms.main.OrderOperation
{
    partial class SelectMaterial
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
            this.cbxManName = new System.Windows.Forms.ComboBox();
            this.lblManName = new System.Windows.Forms.Label();
            this.lblMatModel = new System.Windows.Forms.Label();
            this.cbxMatModel = new System.Windows.Forms.ComboBox();
            this.lblMatName = new System.Windows.Forms.Label();
            this.cbxMatName = new System.Windows.Forms.ComboBox();
            this.lblMatAmount = new System.Windows.Forms.Label();
            this.txtMatAmount = new System.Windows.Forms.TextBox();
            this.cbxSupName = new System.Windows.Forms.ComboBox();
            this.lblSupName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSupPriEmail = new System.Windows.Forms.TextBox();
            this.txtSupPriPhone = new System.Windows.Forms.TextBox();
            this.txtSupPriName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSupPriName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxManName
            // 
            this.cbxManName.DisplayMember = "id";
            this.cbxManName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxManName.FormattingEnabled = true;
            this.cbxManName.Location = new System.Drawing.Point(141, 38);
            this.cbxManName.Name = "cbxManName";
            this.cbxManName.Size = new System.Drawing.Size(121, 23);
            this.cbxManName.TabIndex = 2;
            this.cbxManName.ValueMember = "id";
            this.cbxManName.SelectedIndexChanged += new System.EventHandler(this.cbxManName_SelectedIndexChanged);
            // 
            // lblManName
            // 
            this.lblManName.AutoSize = true;
            this.lblManName.Location = new System.Drawing.Point(53, 41);
            this.lblManName.Name = "lblManName";
            this.lblManName.Size = new System.Drawing.Size(82, 15);
            this.lblManName.TabIndex = 3;
            this.lblManName.Text = "生产厂商：";
            // 
            // lblMatModel
            // 
            this.lblMatModel.AutoSize = true;
            this.lblMatModel.Location = new System.Drawing.Point(53, 104);
            this.lblMatModel.Name = "lblMatModel";
            this.lblMatModel.Size = new System.Drawing.Size(52, 15);
            this.lblMatModel.TabIndex = 4;
            this.lblMatModel.Text = "型号：";
            // 
            // cbxMatModel
            // 
            this.cbxMatModel.DisplayMember = "id";
            this.cbxMatModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatModel.FormattingEnabled = true;
            this.cbxMatModel.Location = new System.Drawing.Point(141, 101);
            this.cbxMatModel.Name = "cbxMatModel";
            this.cbxMatModel.Size = new System.Drawing.Size(121, 23);
            this.cbxMatModel.TabIndex = 5;
            this.cbxMatModel.Tag = "";
            this.cbxMatModel.ValueMember = "id";
            this.cbxMatModel.SelectionChangeCommitted += new System.EventHandler(this.cbxMatModel_SelectionChangeCommitted);
            // 
            // lblMatName
            // 
            this.lblMatName.AutoSize = true;
            this.lblMatName.Location = new System.Drawing.Point(369, 104);
            this.lblMatName.Name = "lblMatName";
            this.lblMatName.Size = new System.Drawing.Size(52, 15);
            this.lblMatName.TabIndex = 6;
            this.lblMatName.Text = "材料：";
            // 
            // cbxMatName
            // 
            this.cbxMatName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatName.FormattingEnabled = true;
            this.cbxMatName.Location = new System.Drawing.Point(448, 101);
            this.cbxMatName.Name = "cbxMatName";
            this.cbxMatName.Size = new System.Drawing.Size(121, 23);
            this.cbxMatName.TabIndex = 7;
            this.cbxMatName.SelectionChangeCommitted += new System.EventHandler(this.cbxMatName_SelectionChangeCommitted);
            // 
            // lblMatAmount
            // 
            this.lblMatAmount.AutoSize = true;
            this.lblMatAmount.Location = new System.Drawing.Point(53, 167);
            this.lblMatAmount.Name = "lblMatAmount";
            this.lblMatAmount.Size = new System.Drawing.Size(52, 15);
            this.lblMatAmount.TabIndex = 8;
            this.lblMatAmount.Text = "数量：";
            // 
            // txtMatAmount
            // 
            this.txtMatAmount.Location = new System.Drawing.Point(141, 164);
            this.txtMatAmount.Name = "txtMatAmount";
            this.txtMatAmount.Size = new System.Drawing.Size(100, 25);
            this.txtMatAmount.TabIndex = 9;
            this.txtMatAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatAmount_Validating);
            // 
            // cbxSupName
            // 
            this.cbxSupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSupName.FormattingEnabled = true;
            this.cbxSupName.Location = new System.Drawing.Point(100, 39);
            this.cbxSupName.Name = "cbxSupName";
            this.cbxSupName.Size = new System.Drawing.Size(121, 23);
            this.cbxSupName.TabIndex = 10;
            this.cbxSupName.SelectedIndexChanged += new System.EventHandler(this.cbxSupName_SelectedIndexChanged);
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Location = new System.Drawing.Point(12, 42);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(67, 15);
            this.lblSupName.TabIndex = 11;
            this.lblSupName.Text = "供货商：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSupPriEmail);
            this.groupBox1.Controls.Add(this.txtSupPriPhone);
            this.groupBox1.Controls.Add(this.txtSupPriName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSupPriName);
            this.groupBox1.Controls.Add(this.lblSupName);
            this.groupBox1.Controls.Add(this.cbxSupName);
            this.groupBox1.Location = new System.Drawing.Point(41, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 176);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "供货商";
            // 
            // txtSupPriEmail
            // 
            this.txtSupPriEmail.Location = new System.Drawing.Point(545, 110);
            this.txtSupPriEmail.Name = "txtSupPriEmail";
            this.txtSupPriEmail.ReadOnly = true;
            this.txtSupPriEmail.Size = new System.Drawing.Size(100, 25);
            this.txtSupPriEmail.TabIndex = 17;
            // 
            // txtSupPriPhone
            // 
            this.txtSupPriPhone.Location = new System.Drawing.Point(345, 110);
            this.txtSupPriPhone.Name = "txtSupPriPhone";
            this.txtSupPriPhone.ReadOnly = true;
            this.txtSupPriPhone.Size = new System.Drawing.Size(100, 25);
            this.txtSupPriPhone.TabIndex = 16;
            // 
            // txtSupPriName
            // 
            this.txtSupPriName.Location = new System.Drawing.Point(100, 110);
            this.txtSupPriName.Name = "txtSupPriName";
            this.txtSupPriName.ReadOnly = true;
            this.txtSupPriName.Size = new System.Drawing.Size(100, 25);
            this.txtSupPriName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "邮箱：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "联系方式：";
            // 
            // lblSupPriName
            // 
            this.lblSupPriName.AutoSize = true;
            this.lblSupPriName.Location = new System.Drawing.Point(15, 114);
            this.lblSupPriName.Name = "lblSupPriName";
            this.lblSupPriName.Size = new System.Drawing.Size(67, 15);
            this.lblSupPriName.TabIndex = 12;
            this.lblSupPriName.Text = "负责人：";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Location = new System.Drawing.Point(238, 398);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 25);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "添加";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(426, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SelectMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMatAmount);
            this.Controls.Add(this.lblMatAmount);
            this.Controls.Add(this.cbxMatName);
            this.Controls.Add(this.lblMatName);
            this.Controls.Add(this.cbxMatModel);
            this.Controls.Add(this.lblMatModel);
            this.Controls.Add(this.lblManName);
            this.Controls.Add(this.cbxManName);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectMaterial";
            this.Text = "添加材料";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectMaterial_FormClosed);
            this.Load += new System.EventHandler(this.SelectMaterial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxManName;
        private System.Windows.Forms.Label lblManName;
        private System.Windows.Forms.Label lblMatModel;
        private System.Windows.Forms.ComboBox cbxMatModel;
        private System.Windows.Forms.Label lblMatName;
        private System.Windows.Forms.ComboBox cbxMatName;
        private System.Windows.Forms.Label lblMatAmount;
        private System.Windows.Forms.TextBox txtMatAmount;
        private System.Windows.Forms.ComboBox cbxSupName;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSupPriEmail;
        private System.Windows.Forms.TextBox txtSupPriPhone;
        private System.Windows.Forms.TextBox txtSupPriName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSupPriName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}