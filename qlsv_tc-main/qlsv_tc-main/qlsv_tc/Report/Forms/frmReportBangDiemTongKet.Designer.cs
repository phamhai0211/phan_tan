
namespace qlsv_tc.Report.Forms
{
    partial class frmReportBangDiemTongKet
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
            this.lookupEditMalop = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.dS1 = new qlsv_tc.DS1();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cboxKhoa = new System.Windows.Forms.ComboBox();
            this.btnInLTC = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label8 = new System.Windows.Forms.Label();
            this.tableAdapterLop = new qlsv_tc.DS1TableAdapters.LOPTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditMalop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lookupEditMalop);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.cboxKhoa);
            this.groupBox1.Controls.Add(this.btnInLTC);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(139, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 225);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "In Bảng Điểm Tổng Kết";
            // 
            // lookupEditMalop
            // 
            this.lookupEditMalop.Location = new System.Drawing.Point(120, 97);
            this.lookupEditMalop.Name = "lookupEditMalop";
            this.lookupEditMalop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lookupEditMalop.Properties.Appearance.Options.UseFont = true;
            this.lookupEditMalop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupEditMalop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MALOP", "MALOP", 98, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KHOAHOC", "KHOAHOC", 118, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookupEditMalop.Properties.DataSource = this.bdsLop;
            this.lookupEditMalop.Properties.DisplayMember = "MALOP";
            this.lookupEditMalop.Properties.NullText = "";
            this.lookupEditMalop.Properties.ValueMember = "MALOP";
            this.lookupEditMalop.Size = new System.Drawing.Size(377, 34);
            this.lookupEditMalop.TabIndex = 24;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS1;
            // 
            // dS1
            // 
            this.dS1.DataSetName = "DS1";
            this.dS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(19)))), ((int)(((byte)(0)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(197, 163);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(141, 39);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            // btnInLTC
            // 
            this.btnInLTC.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInLTC.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInLTC.Appearance.Options.UseBackColor = true;
            this.btnInLTC.Appearance.Options.UseFont = true;
            this.btnInLTC.Location = new System.Drawing.Point(367, 163);
            this.btnInLTC.Name = "btnInLTC";
            this.btnInLTC.Size = new System.Drawing.Size(130, 39);
            this.btnInLTC.TabIndex = 14;
            this.btnInLTC.Text = "In Báo Cáo";
            this.btnInLTC.Click += new System.EventHandler(this.btnInLTC_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label8.Location = new System.Drawing.Point(19, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mã Lớp:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableAdapterLop
            // 
            this.tableAdapterLop.ClearBeforeFill = true;
            // 
            // frmReportBangDiemTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 352);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReportBangDiemTongKet";
            this.Text = "frmReportBangDiemTongKet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportBangDiemTongKet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditMalop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cboxKhoa;
        private DevExpress.XtraEditors.SimpleButton btnInLTC;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label label8;
        private DS1 dS1;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS1TableAdapters.LOPTableAdapter tableAdapterLop;
        private DevExpress.XtraEditors.LookUpEdit lookupEditMalop;
    }
}