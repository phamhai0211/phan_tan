
namespace qlsv_tc.Forms
{
    partial class frmTaoTaiKhoan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.pnRole = new DevExpress.XtraEditors.PanelControl();
            this.rbtnPGV = new System.Windows.Forms.RadioButton();
            this.rbtnKhoa = new System.Windows.Forms.RadioButton();
            this.rbtnPKT = new System.Windows.Forms.RadioButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaoTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lookUpUser = new DevExpress.XtraEditors.LookUpEdit();
            this.dS3 = new qlsv_tc.DS3();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new qlsv_tc.DS3TableAdapters.GIANGVIENTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnRole)).BeginInit();
            this.pnRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lookUpUser);
            this.groupBox1.Controls.Add(this.chkShowPass);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTaoTaiKhoan);
            this.groupBox1.Controls.Add(this.pnRole);
            this.groupBox1.Controls.Add(this.lbRole);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtConfirm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(201, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 638);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo Tài Khoản";
            // 
            // label5
            // 
            this.label5.Image = global::qlsv_tc.Properties.Resources._5596784__1_;
            this.label5.Location = new System.Drawing.Point(192, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 206);
            this.label5.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(135, 232);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(357, 30);
            this.txtLogin.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(135, 286);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(357, 30);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(135, 340);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(357, 30);
            this.txtConfirm.TabIndex = 19;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Confirm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Giảng Viên";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(38, 484);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(48, 22);
            this.lbRole.TabIndex = 22;
            this.lbRole.Text = "Role";
            // 
            // pnRole
            // 
            this.pnRole.Controls.Add(this.rbtnPGV);
            this.pnRole.Controls.Add(this.rbtnKhoa);
            this.pnRole.Controls.Add(this.rbtnPKT);
            this.pnRole.Location = new System.Drawing.Point(135, 452);
            this.pnRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnRole.Name = "pnRole";
            this.pnRole.Size = new System.Drawing.Size(357, 77);
            this.pnRole.TabIndex = 24;
            // 
            // rbtnPGV
            // 
            this.rbtnPGV.AutoSize = true;
            this.rbtnPGV.Location = new System.Drawing.Point(22, 29);
            this.rbtnPGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnPGV.Name = "rbtnPGV";
            this.rbtnPGV.Size = new System.Drawing.Size(64, 23);
            this.rbtnPGV.TabIndex = 4;
            this.rbtnPGV.TabStop = true;
            this.rbtnPGV.Text = "PGV";
            this.rbtnPGV.UseVisualStyleBackColor = true;
            // 
            // rbtnKhoa
            // 
            this.rbtnKhoa.AutoSize = true;
            this.rbtnKhoa.Location = new System.Drawing.Point(102, 29);
            this.rbtnKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnKhoa.Name = "rbtnKhoa";
            this.rbtnKhoa.Size = new System.Drawing.Size(69, 23);
            this.rbtnKhoa.TabIndex = 5;
            this.rbtnKhoa.TabStop = true;
            this.rbtnKhoa.Text = "Khoa";
            this.rbtnKhoa.UseVisualStyleBackColor = true;
            // 
            // rbtnPKT
            // 
            this.rbtnPKT.AutoSize = true;
            this.rbtnPKT.Location = new System.Drawing.Point(189, 29);
            this.rbtnPKT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnPKT.Name = "rbtnPKT";
            this.rbtnPKT.Size = new System.Drawing.Size(96, 23);
            this.rbtnPKT.TabIndex = 6;
            this.rbtnPKT.TabStop = true;
            this.rbtnPKT.Text = "PKeToan";
            this.rbtnPKT.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(19)))), ((int)(((byte)(0)))));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseBackColor = true;
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(237, 565);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(148, 43);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTaoTaiKhoan.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTaiKhoan.Appearance.Options.UseBackColor = true;
            this.btnTaoTaiKhoan.Appearance.Options.UseFont = true;
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(409, 565);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(148, 43);
            this.btnTaoTaiKhoan.TabIndex = 7;
            this.btnTaoTaiKhoan.Text = "Tạo Tài Khoản";
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Location = new System.Drawing.Point(499, 316);
            this.chkShowPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(78, 26);
            this.chkShowPass.TabIndex = 25;
            this.chkShowPass.Text = "show";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lookUpUser
            // 
            this.lookUpUser.Location = new System.Drawing.Point(135, 392);
            this.lookUpUser.Name = "lookUpUser";
            this.lookUpUser.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpUser.Properties.Appearance.Options.UseFont = true;
            this.lookUpUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpUser.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAGV", "MAGV", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HO", "HO", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN", "TEN", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpUser.Properties.DataSource = this.gIANGVIENBindingSource;
            this.lookUpUser.Properties.DisplayMember = "MAGV";
            this.lookUpUser.Properties.DropDownRows = 10;
            this.lookUpUser.Properties.NullText = "";
            this.lookUpUser.Properties.ValueMember = "MAGV";
            this.lookUpUser.Size = new System.Drawing.Size(360, 30);
            this.lookUpUser.TabIndex = 26;
            // 
            // dS3
            // 
            this.dS3.DataSetName = "DS3";
            this.dS3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.dS3;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 731);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "Tạo Tài Khoản";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnRole)).EndInit();
            this.pnRole.ResumeLayout(false);
            this.pnRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.PanelControl pnRole;
        private System.Windows.Forms.RadioButton rbtnPGV;
        private System.Windows.Forms.RadioButton rbtnKhoa;
        private System.Windows.Forms.RadioButton rbtnPKT;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnTaoTaiKhoan;
        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevExpress.XtraEditors.LookUpEdit lookUpUser;
        private DS3 dS3;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private DS3TableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
    }
}