

namespace qlsv_tc
{
    partial class frmDangNhap
    {


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
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.cboxKhoa = new System.Windows.Forms.ComboBox();
            this.grbDangNhap = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            this.grbDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(19)))), ((int)(((byte)(0)))));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Appearance.Options.UseBackColor = true;
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Appearance.Options.UseForeColor = true;
            this.btnThoat.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            this.btnThoat.AppearanceHovered.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnThoat.AppearanceHovered.Options.UseBackColor = true;
            this.btnThoat.AppearanceHovered.Options.UseFont = true;
            this.btnThoat.AppearanceHovered.Options.UseForeColor = true;
            this.btnThoat.Location = new System.Drawing.Point(306, 263);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(138, 48);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(102, 151);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tài khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(102, 215);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 25);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(222, 142);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(313, 34);
            this.txtTaiKhoan.TabIndex = 4;
            this.txtTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(222, 206);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau.Size = new System.Drawing.Size(313, 34);
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(102, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 25);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Khoa";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Appearance.Options.UseBackColor = true;
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Appearance.Options.UseForeColor = true;
            this.btnDangNhap.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnDangNhap.AppearanceHovered.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.AppearanceHovered.Options.UseBackColor = true;
            this.btnDangNhap.AppearanceHovered.Options.UseFont = true;
            this.btnDangNhap.AppearanceHovered.Options.UseForeColor = true;
            this.btnDangNhap.Location = new System.Drawing.Point(461, 263);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(152, 48);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // cboxKhoa
            // 
            this.cboxKhoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxKhoa.FormattingEnabled = true;
            this.cboxKhoa.Location = new System.Drawing.Point(222, 79);
            this.cboxKhoa.Name = "cboxKhoa";
            this.cboxKhoa.Size = new System.Drawing.Size(313, 33);
            this.cboxKhoa.TabIndex = 9;
            this.cboxKhoa.SelectedIndexChanged += new System.EventHandler(this.cboxKhoa_SelectedIndexChanged);
            // 
            // grbDangNhap
            // 
            this.grbDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbDangNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbDangNhap.Controls.Add(this.labelControl3);
            this.grbDangNhap.Controls.Add(this.btnThoat);
            this.grbDangNhap.Controls.Add(this.btnDangNhap);
            this.grbDangNhap.Controls.Add(this.txtMatKhau);
            this.grbDangNhap.Controls.Add(this.labelControl2);
            this.grbDangNhap.Controls.Add(this.cboxKhoa);
            this.grbDangNhap.Controls.Add(this.txtTaiKhoan);
            this.grbDangNhap.Controls.Add(this.labelControl1);
            this.grbDangNhap.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grbDangNhap.Location = new System.Drawing.Point(84, 65);
            this.grbDangNhap.Name = "grbDangNhap";
            this.grbDangNhap.Size = new System.Drawing.Size(682, 339);
            this.grbDangNhap.TabIndex = 10;
            this.grbDangNhap.TabStop = false;
            this.grbDangNhap.Text = "Đăng Nhập";
            // 
            // frmDangNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 580);
            this.Controls.Add(this.grbDangNhap);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            this.grbDangNhap.ResumeLayout(false);
            this.grbDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private System.Windows.Forms.ComboBox cboxKhoa;
        private System.Windows.Forms.GroupBox grbDangNhap;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}