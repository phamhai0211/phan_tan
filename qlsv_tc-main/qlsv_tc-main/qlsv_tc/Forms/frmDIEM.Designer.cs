
namespace qlsv_tc.Forms
{
    partial class frmDIEM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDIEM));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboxKhoa = new System.Windows.Forms.ComboBox();
            this.lblTenKhoa = new DevExpress.XtraEditors.LabelControl();
            this.dS1 = new qlsv_tc.DS1();
            this.DiemGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsDIEMSV = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEMHETMON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterDIEMSV = new qlsv_tc.DS1TableAdapters.GetDanhSachDiemSVTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBatDau = new DevExpress.XtraEditors.SimpleButton();
            this.spinEditNhom = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditHocKi = new DevExpress.XtraEditors.SpinEdit();
            this.lookUpMonHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.tableAdapterMonHoc = new qlsv_tc.DS1TableAdapters.MONHOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDIEMSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditHocKi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem2,
            this.btnGhi,
            this.btnReload,
            this.barButtonItem1,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(87, 264);
            this.bar1.FloatSize = new System.Drawing.Size(591, 36);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 3;
            this.bar1.Text = "Tools";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Làm mới";
            this.btnReload.Id = 7;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thoát";
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(923, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 483);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(923, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 459);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(923, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 459);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cboxKhoa);
            this.panelControl1.Controls.Add(this.lblTenKhoa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(923, 55);
            this.panelControl1.TabIndex = 20;
            // 
            // cboxKhoa
            // 
            this.cboxKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxKhoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxKhoa.FormattingEnabled = true;
            this.cboxKhoa.Location = new System.Drawing.Point(350, 16);
            this.cboxKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cboxKhoa.Name = "cboxKhoa";
            this.cboxKhoa.Size = new System.Drawing.Size(284, 25);
            this.cboxKhoa.TabIndex = 1;
            this.cboxKhoa.SelectedIndexChanged += new System.EventHandler(this.cboxKhoa_SelectedIndexChanged);
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenKhoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhoa.Appearance.Options.UseFont = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(306, 18);
            this.lblTenKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(32, 17);
            this.lblTenKhoa.TabIndex = 0;
            this.lblTenKhoa.Text = "Khoa";
            // 
            // dS1
            // 
            this.dS1.DataSetName = "DS1";
            this.dS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DiemGridControl
            // 
            this.DiemGridControl.DataSource = this.bdsDIEMSV;
            this.DiemGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiemGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.DiemGridControl.Location = new System.Drawing.Point(0, 160);
            this.DiemGridControl.MainView = this.gridView1;
            this.DiemGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.DiemGridControl.MenuManager = this.barManager1;
            this.DiemGridControl.Name = "DiemGridControl";
            this.DiemGridControl.Size = new System.Drawing.Size(923, 323);
            this.DiemGridControl.TabIndex = 23;
            this.DiemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsDIEMSV
            // 
            this.bdsDIEMSV.DataMember = "GetDanhSachDiemSV";
            this.bdsDIEMSV.DataSource = this.dS1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colMASV,
            this.colHOTENSV,
            this.colDIEM_CC,
            this.colDIEM_GK,
            this.colDIEM_CK,
            this.colDIEMHETMON});
            this.gridView1.DetailHeight = 239;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.DiemGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // colMALTC
            // 
            this.colMALTC.AppearanceCell.Options.UseTextOptions = true;
            this.colMALTC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALTC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colMALTC.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMALTC.AppearanceHeader.Options.UseBackColor = true;
            this.colMALTC.AppearanceHeader.Options.UseFont = true;
            this.colMALTC.AppearanceHeader.Options.UseTextOptions = true;
            this.colMALTC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.OptionsColumn.ReadOnly = true;
            // 
            // colMASV
            // 
            this.colMASV.AppearanceCell.Options.UseTextOptions = true;
            this.colMASV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMASV.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colMASV.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMASV.AppearanceHeader.Options.UseBackColor = true;
            this.colMASV.AppearanceHeader.Options.UseFont = true;
            this.colMASV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMASV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.OptionsColumn.AllowFocus = false;
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHOTENSV
            // 
            this.colHOTENSV.AppearanceCell.Options.UseTextOptions = true;
            this.colHOTENSV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOTENSV.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colHOTENSV.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOTENSV.AppearanceHeader.Options.UseBackColor = true;
            this.colHOTENSV.AppearanceHeader.Options.UseFont = true;
            this.colHOTENSV.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOTENSV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOTENSV.FieldName = "HOTENSV";
            this.colHOTENSV.Name = "colHOTENSV";
            this.colHOTENSV.OptionsColumn.AllowEdit = false;
            this.colHOTENSV.OptionsColumn.AllowFocus = false;
            this.colHOTENSV.OptionsColumn.ReadOnly = true;
            this.colHOTENSV.Visible = true;
            this.colHOTENSV.VisibleIndex = 1;
            // 
            // colDIEM_CC
            // 
            this.colDIEM_CC.AppearanceCell.Options.UseTextOptions = true;
            this.colDIEM_CC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM_CC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colDIEM_CC.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIEM_CC.AppearanceHeader.Options.UseBackColor = true;
            this.colDIEM_CC.AppearanceHeader.Options.UseFont = true;
            this.colDIEM_CC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIEM_CC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM_CC.FieldName = "DIEM_CC";
            this.colDIEM_CC.Name = "colDIEM_CC";
            this.colDIEM_CC.Visible = true;
            this.colDIEM_CC.VisibleIndex = 2;
            // 
            // colDIEM_GK
            // 
            this.colDIEM_GK.AppearanceCell.Options.UseTextOptions = true;
            this.colDIEM_GK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM_GK.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colDIEM_GK.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIEM_GK.AppearanceHeader.Options.UseBackColor = true;
            this.colDIEM_GK.AppearanceHeader.Options.UseFont = true;
            this.colDIEM_GK.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIEM_GK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM_GK.DisplayFormat.FormatString = "n2";
            this.colDIEM_GK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDIEM_GK.FieldName = "DIEM_GK";
            this.colDIEM_GK.Name = "colDIEM_GK";
            this.colDIEM_GK.Visible = true;
            this.colDIEM_GK.VisibleIndex = 3;
            // 
            // colDIEM_CK
            // 
            this.colDIEM_CK.AppearanceCell.Options.UseTextOptions = true;
            this.colDIEM_CK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM_CK.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colDIEM_CK.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIEM_CK.AppearanceHeader.Options.UseBackColor = true;
            this.colDIEM_CK.AppearanceHeader.Options.UseFont = true;
            this.colDIEM_CK.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIEM_CK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM_CK.DisplayFormat.FormatString = "n2";
            this.colDIEM_CK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDIEM_CK.FieldName = "DIEM_CK";
            this.colDIEM_CK.Name = "colDIEM_CK";
            this.colDIEM_CK.Visible = true;
            this.colDIEM_CK.VisibleIndex = 4;
            // 
            // colDIEMHETMON
            // 
            this.colDIEMHETMON.AppearanceCell.Options.UseTextOptions = true;
            this.colDIEMHETMON.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEMHETMON.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colDIEMHETMON.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIEMHETMON.AppearanceHeader.Options.UseBackColor = true;
            this.colDIEMHETMON.AppearanceHeader.Options.UseFont = true;
            this.colDIEMHETMON.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIEMHETMON.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEMHETMON.DisplayFormat.FormatString = "n2";
            this.colDIEMHETMON.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDIEMHETMON.FieldName = "DIEMHETMON";
            this.colDIEMHETMON.Name = "colDIEMHETMON";
            this.colDIEMHETMON.OptionsColumn.AllowEdit = false;
            this.colDIEMHETMON.OptionsColumn.AllowFocus = false;
            this.colDIEMHETMON.OptionsColumn.ReadOnly = true;
            this.colDIEMHETMON.Visible = true;
            this.colDIEMHETMON.VisibleIndex = 5;
            // 
            // tableAdapterDIEMSV
            // 
            this.tableAdapterDIEMSV.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBatDau);
            this.panel1.Controls.Add(this.spinEditNhom);
            this.panel1.Controls.Add(this.spinEditHocKi);
            this.panel1.Controls.Add(this.lookUpMonHoc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNienKhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 81);
            this.panel1.TabIndex = 22;
            // 
            // btnBatDau
            // 
            this.btnBatDau.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBatDau.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBatDau.Appearance.Options.UseBackColor = true;
            this.btnBatDau.Appearance.Options.UseFont = true;
            this.btnBatDau.Appearance.Options.UseForeColor = true;
            this.btnBatDau.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnBatDau.AppearanceHovered.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnBatDau.AppearanceHovered.Options.UseBackColor = true;
            this.btnBatDau.AppearanceHovered.Options.UseFont = true;
            this.btnBatDau.AppearanceHovered.Options.UseForeColor = true;
            this.btnBatDau.Location = new System.Drawing.Point(541, 40);
            this.btnBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(83, 27);
            this.btnBatDau.TabIndex = 9;
            this.btnBatDau.Text = "Bắt Đầu";
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // spinEditNhom
            // 
            this.spinEditNhom.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditNhom.Location = new System.Drawing.Point(363, 45);
            this.spinEditNhom.Margin = new System.Windows.Forms.Padding(2);
            this.spinEditNhom.MenuManager = this.barManager1;
            this.spinEditNhom.Name = "spinEditNhom";
            this.spinEditNhom.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEditNhom.Properties.Appearance.Options.UseFont = true;
            this.spinEditNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditNhom.Size = new System.Drawing.Size(100, 22);
            this.spinEditNhom.TabIndex = 7;
            // 
            // spinEditHocKi
            // 
            this.spinEditHocKi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditHocKi.Location = new System.Drawing.Point(91, 45);
            this.spinEditHocKi.Margin = new System.Windows.Forms.Padding(2);
            this.spinEditHocKi.MenuManager = this.barManager1;
            this.spinEditHocKi.Name = "spinEditHocKi";
            this.spinEditHocKi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEditHocKi.Properties.Appearance.Options.UseFont = true;
            this.spinEditHocKi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditHocKi.Size = new System.Drawing.Size(100, 22);
            this.spinEditHocKi.TabIndex = 6;
            // 
            // lookUpMonHoc
            // 
            this.lookUpMonHoc.Location = new System.Drawing.Point(363, 17);
            this.lookUpMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.lookUpMonHoc.MenuManager = this.barManager1;
            this.lookUpMonHoc.Name = "lookUpMonHoc";
            this.lookUpMonHoc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpMonHoc.Properties.Appearance.Options.UseFont = true;
            this.lookUpMonHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMonHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAMH", "MAMH", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENMH", "TENMH", 79, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpMonHoc.Properties.DataSource = this.bdsMonHoc;
            this.lookUpMonHoc.Properties.DisplayMember = "MAMH";
            this.lookUpMonHoc.Properties.NullText = "";
            this.lookUpMonHoc.Properties.ValueMember = "MAMH";
            this.lookUpMonHoc.Size = new System.Drawing.Size(159, 22);
            this.lookUpMonHoc.TabIndex = 5;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhóm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Môn Học: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Học Kì:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Niên Khóa:";
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNienKhoa.Location = new System.Drawing.Point(91, 14);
            this.txtNienKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(159, 23);
            this.txtNienKhoa.TabIndex = 0;
            this.txtNienKhoa.TextChanged += new System.EventHandler(this.txtNienKhoa_TextChanged);
            // 
            // tableAdapterMonHoc
            // 
            this.tableAdapterMonHoc.ClearBeforeFill = true;
            // 
            // frmDIEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 503);
            this.Controls.Add(this.DiemGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDIEM";
            this.Text = "frmDIEM";
            this.Load += new System.EventHandler(this.frmDIEM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDIEMSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditHocKi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cboxKhoa;
        private DevExpress.XtraEditors.LabelControl lblTenKhoa;
        private DS1 dS1;
        private DevExpress.XtraGrid.GridControl DiemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdsDIEMSV;
        private DS1TableAdapters.GetDanhSachDiemSVTableAdapter tableAdapterDIEMSV;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnBatDau;
        private DevExpress.XtraEditors.SpinEdit spinEditNhom;
        private DevExpress.XtraEditors.SpinEdit spinEditHocKi;
        private DevExpress.XtraEditors.LookUpEdit lookUpMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNienKhoa;
        private DS1TableAdapters.MONHOCTableAdapter tableAdapterMonHoc;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENSV;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEMHETMON;
    }
}