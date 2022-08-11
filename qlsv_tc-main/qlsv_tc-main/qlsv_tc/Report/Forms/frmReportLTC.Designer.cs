
namespace qlsv_tc.Forms
{
    partial class frmReportLTC
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboxKhoa = new System.Windows.Forms.ComboBox();
            this.spHocKi = new DevExpress.XtraEditors.SpinEdit();
            this.btnInLTC = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.bdsNienKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new qlsv_tc.DS1();
            this.nIENKHOATableAdapter = new qlsv_tc.DS1TableAdapters.NIENKHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spHocKi.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNienKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 25);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Khoa";
            // 
            // cboxKhoa
            // 
            this.cboxKhoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxKhoa.FormattingEnabled = true;
            this.cboxKhoa.Location = new System.Drawing.Point(120, 41);
            this.cboxKhoa.Name = "cboxKhoa";
            this.cboxKhoa.Size = new System.Drawing.Size(377, 33);
            this.cboxKhoa.TabIndex = 11;
            this.cboxKhoa.SelectedIndexChanged += new System.EventHandler(this.cboxKhoa_SelectedIndexChanged);
            // 
            // spHocKi
            // 
            this.spHocKi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spHocKi.Location = new System.Drawing.Point(120, 147);
            this.spHocKi.Name = "spHocKi";
            this.spHocKi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHocKi.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.spHocKi.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spHocKi.Size = new System.Drawing.Size(76, 28);
            this.spHocKi.TabIndex = 16;
            // 
            // btnInLTC
            // 
            this.btnInLTC.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInLTC.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInLTC.Appearance.Options.UseBackColor = true;
            this.btnInLTC.Appearance.Options.UseFont = true;
            this.btnInLTC.Location = new System.Drawing.Point(367, 198);
            this.btnInLTC.Name = "btnInLTC";
            this.btnInLTC.Size = new System.Drawing.Size(130, 39);
            this.btnInLTC.TabIndex = 14;
            this.btnInLTC.Text = "In Báo Cáo";
            this.btnInLTC.Click += new System.EventHandler(this.btnInLTC_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Học Kì";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Niên Khoá";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.cmbNienKhoa);
            this.groupBox1.Controls.Add(this.cboxKhoa);
            this.groupBox1.Controls.Add(this.btnInLTC);
            this.groupBox1.Controls.Add(this.spHocKi);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(126, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 255);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "In LTC";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(19)))), ((int)(((byte)(0)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(196, 198);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(141, 39);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataSource = this.bdsNienKhoa;
            this.cmbNienKhoa.DisplayMember = "NIENKHOA";
            this.cmbNienKhoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(121, 97);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(376, 33);
            this.cmbNienKhoa.TabIndex = 17;
            this.cmbNienKhoa.ValueMember = "NIENKHOA";
            // 
            // bdsNienKhoa
            // 
            this.bdsNienKhoa.DataMember = "NIENKHOA";
            this.bdsNienKhoa.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nIENKHOATableAdapter
            // 
            this.nIENKHOATableAdapter.ClearBeforeFill = true;
            // 
            // frmReportLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 445);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReportLTC";
            this.Text = "Báo Cáo Lớp Tín Chỉ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spHocKi.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNienKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cboxKhoa;
        private DevExpress.XtraEditors.SpinEdit spHocKi;
        private DevExpress.XtraEditors.SimpleButton btnInLTC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private DS1 dS;
        private System.Windows.Forms.BindingSource bdsNienKhoa;
        private DS1TableAdapters.NIENKHOATableAdapter nIENKHOATableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}