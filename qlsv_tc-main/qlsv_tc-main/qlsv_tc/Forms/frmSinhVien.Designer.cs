
namespace qlsv_tc.Forms
{
    partial class frmSinhVien
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label dANGHIHOCLabel;
            System.Windows.Forms.Label pASSWORDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
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
            this.SINHVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.dS1 = new qlsv_tc.DS1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASSWORD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterSV = new qlsv_tc.DS1TableAdapters.SINHVIENTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnSinhVien = new System.Windows.Forms.Panel();
            this.checkBoxPHAI = new DevExpress.XtraEditors.CheckEdit();
            this.cboxMALOP = new System.Windows.Forms.ComboBox();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.txtPASSWORD = new DevExpress.XtraEditors.TextEdit();
            this.checkBoxDANGNGHIHOC = new DevExpress.XtraEditors.CheckEdit();
            this.dateEditNGAYSINH = new DevExpress.XtraEditors.DateEdit();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.txtTEN = new System.Windows.Forms.TextBox();
            this.txtHO = new System.Windows.Forms.TextBox();
            this.txtMASV = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new qlsv_tc.DS1TableAdapters.TableAdapterManager();
            this.tableAdapterDK = new qlsv_tc.DS1TableAdapters.DANGKYTableAdapter();
            this.tableAdapterLOP = new qlsv_tc.DS1TableAdapters.LOPTableAdapter();
            this.bdsDK = new System.Windows.Forms.BindingSource(this.components);
            this.error = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            dANGHIHOCLabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SINHVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxPHAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPASSWORD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxDANGNGHIHOC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNGAYSINH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNGAYSINH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(242, 38);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(70, 22);
            mASVLabel.TabIndex = 1;
            mASVLabel.Text = "MASV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(242, 86);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(44, 22);
            hOLabel.TabIndex = 3;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(242, 132);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(54, 22);
            tENLabel.TabIndex = 5;
            tENLabel.Text = "TEN:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(587, 38);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(61, 22);
            pHAILabel.TabIndex = 7;
            pHAILabel.Text = "PHAI:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(587, 83);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(83, 22);
            dIACHILabel.TabIndex = 9;
            dIACHILabel.Text = "DIACHI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(587, 132);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(115, 22);
            nGAYSINHLabel.TabIndex = 11;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(987, 40);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(83, 22);
            mALOPLabel.TabIndex = 13;
            mALOPLabel.Text = "MALOP:";
            // 
            // dANGHIHOCLabel
            // 
            dANGHIHOCLabel.AutoSize = true;
            dANGHIHOCLabel.Location = new System.Drawing.Point(987, 132);
            dANGHIHOCLabel.Name = "dANGHIHOCLabel";
            dANGHIHOCLabel.Size = new System.Drawing.Size(133, 22);
            dANGHIHOCLabel.TabIndex = 15;
            dANGHIHOCLabel.Text = "DANGHIHOC:";
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Location = new System.Drawing.Point(987, 91);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(120, 22);
            pASSWORDLabel.TabIndex = 17;
            pASSWORDLabel.Text = "PASSWORD:";
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
            this.btnThem,
            this.barButtonItem2,
            this.btnHieuChinh,
            this.btnGhi,
            this.btnXoa,
            this.btnUndo,
            this.btnReload,
            this.barButtonItem1,
            this.btnHuy,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 3;
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu Chỉnh";
            this.btnHieuChinh.Id = 3;
            this.btnHieuChinh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHieuChinh.ImageOptions.SvgImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 5;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Id = 6;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Huỷ";
            this.btnHuy.Id = 9;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1944, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1039);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1944, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1005);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1944, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1005);
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
            this.panelControl1.Location = new System.Drawing.Point(0, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1944, 80);
            this.panelControl1.TabIndex = 19;
            // 
            // cboxKhoa
            // 
            this.cboxKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxKhoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxKhoa.FormattingEnabled = true;
            this.cboxKhoa.Location = new System.Drawing.Point(805, 24);
            this.cboxKhoa.Name = "cboxKhoa";
            this.cboxKhoa.Size = new System.Drawing.Size(424, 33);
            this.cboxKhoa.TabIndex = 1;
            this.cboxKhoa.SelectedIndexChanged += new System.EventHandler(this.cboxKhoa_SelectedIndexChanged);
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenKhoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhoa.Appearance.Options.UseFont = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(739, 27);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(47, 25);
            this.lblTenKhoa.TabIndex = 0;
            this.lblTenKhoa.Text = "Khoa";
            // 
            // SINHVIENGridControl
            // 
            this.SINHVIENGridControl.DataSource = this.bdsSV;
            this.SINHVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SINHVIENGridControl.Location = new System.Drawing.Point(0, 114);
            this.SINHVIENGridControl.MainView = this.gridView1;
            this.SINHVIENGridControl.MenuManager = this.barManager1;
            this.SINHVIENGridControl.Name = "SINHVIENGridControl";
            this.SINHVIENGridControl.Size = new System.Drawing.Size(1944, 925);
            this.SINHVIENGridControl.TabIndex = 20;
            this.SINHVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SINHVIEN";
            this.bdsSV.DataSource = this.dS1;
            // 
            // dS1
            // 
            this.dS1.DataSetName = "DS1";
            this.dS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colMALOP,
            this.colDANGHIHOC,
            this.colPASSWORD});
            this.gridView1.GridControl = this.SINHVIENGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.colMASV.MinWidth = 30;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 112;
            // 
            // colHO
            // 
            this.colHO.AppearanceCell.Options.UseTextOptions = true;
            this.colHO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHO.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colHO.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHO.AppearanceHeader.Options.UseBackColor = true;
            this.colHO.AppearanceHeader.Options.UseFont = true;
            this.colHO.AppearanceHeader.Options.UseTextOptions = true;
            this.colHO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 30;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 112;
            // 
            // colTEN
            // 
            this.colTEN.AppearanceCell.Options.UseTextOptions = true;
            this.colTEN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colTEN.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTEN.AppearanceHeader.Options.UseBackColor = true;
            this.colTEN.AppearanceHeader.Options.UseFont = true;
            this.colTEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 112;
            // 
            // colPHAI
            // 
            this.colPHAI.AppearanceCell.Options.UseTextOptions = true;
            this.colPHAI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHAI.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colPHAI.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPHAI.AppearanceHeader.Options.UseBackColor = true;
            this.colPHAI.AppearanceHeader.Options.UseFont = true;
            this.colPHAI.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 30;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.AllowEdit = false;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 112;
            // 
            // colDIACHI
            // 
            this.colDIACHI.AppearanceCell.Options.UseTextOptions = true;
            this.colDIACHI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIACHI.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colDIACHI.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIACHI.AppearanceHeader.Options.UseBackColor = true;
            this.colDIACHI.AppearanceHeader.Options.UseFont = true;
            this.colDIACHI.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIACHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 30;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 112;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.AppearanceCell.Options.UseTextOptions = true;
            this.colNGAYSINH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYSINH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colNGAYSINH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYSINH.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAYSINH.AppearanceHeader.Options.UseFont = true;
            this.colNGAYSINH.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAYSINH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 30;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 112;
            // 
            // colMALOP
            // 
            this.colMALOP.AppearanceCell.Options.UseTextOptions = true;
            this.colMALOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALOP.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colMALOP.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMALOP.AppearanceHeader.Options.UseBackColor = true;
            this.colMALOP.AppearanceHeader.Options.UseFont = true;
            this.colMALOP.AppearanceHeader.Options.UseTextOptions = true;
            this.colMALOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 30;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 6;
            this.colMALOP.Width = 112;
            // 
            // colDANGHIHOC
            // 
            this.colDANGHIHOC.AppearanceCell.Options.UseTextOptions = true;
            this.colDANGHIHOC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDANGHIHOC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colDANGHIHOC.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDANGHIHOC.AppearanceHeader.Options.UseBackColor = true;
            this.colDANGHIHOC.AppearanceHeader.Options.UseFont = true;
            this.colDANGHIHOC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDANGHIHOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDANGHIHOC.FieldName = "DANGHIHOC";
            this.colDANGHIHOC.MinWidth = 30;
            this.colDANGHIHOC.Name = "colDANGHIHOC";
            this.colDANGHIHOC.OptionsColumn.AllowEdit = false;
            this.colDANGHIHOC.Visible = true;
            this.colDANGHIHOC.VisibleIndex = 7;
            this.colDANGHIHOC.Width = 112;
            // 
            // colPASSWORD
            // 
            this.colPASSWORD.AppearanceCell.Options.UseTextOptions = true;
            this.colPASSWORD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPASSWORD.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colPASSWORD.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPASSWORD.AppearanceHeader.Options.UseBackColor = true;
            this.colPASSWORD.AppearanceHeader.Options.UseFont = true;
            this.colPASSWORD.AppearanceHeader.Options.UseTextOptions = true;
            this.colPASSWORD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPASSWORD.FieldName = "PASSWORD";
            this.colPASSWORD.MinWidth = 30;
            this.colPASSWORD.Name = "colPASSWORD";
            this.colPASSWORD.OptionsColumn.AllowEdit = false;
            this.colPASSWORD.Visible = true;
            this.colPASSWORD.VisibleIndex = 8;
            this.colPASSWORD.Width = 112;
            // 
            // tableAdapterSV
            // 
            this.tableAdapterSV.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::qlsv_tc.Properties.Resources.sinhvien;
            this.pictureBox1.Location = new System.Drawing.Point(23, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnSinhVien
            // 
            this.pnSinhVien.Controls.Add(this.checkBoxPHAI);
            this.pnSinhVien.Controls.Add(this.cboxMALOP);
            this.pnSinhVien.Controls.Add(pASSWORDLabel);
            this.pnSinhVien.Controls.Add(this.txtPASSWORD);
            this.pnSinhVien.Controls.Add(dANGHIHOCLabel);
            this.pnSinhVien.Controls.Add(this.checkBoxDANGNGHIHOC);
            this.pnSinhVien.Controls.Add(mALOPLabel);
            this.pnSinhVien.Controls.Add(nGAYSINHLabel);
            this.pnSinhVien.Controls.Add(this.dateEditNGAYSINH);
            this.pnSinhVien.Controls.Add(dIACHILabel);
            this.pnSinhVien.Controls.Add(this.txtDIACHI);
            this.pnSinhVien.Controls.Add(pHAILabel);
            this.pnSinhVien.Controls.Add(tENLabel);
            this.pnSinhVien.Controls.Add(this.txtTEN);
            this.pnSinhVien.Controls.Add(hOLabel);
            this.pnSinhVien.Controls.Add(this.txtHO);
            this.pnSinhVien.Controls.Add(mASVLabel);
            this.pnSinhVien.Controls.Add(this.txtMASV);
            this.pnSinhVien.Controls.Add(this.pictureBox1);
            this.pnSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSinhVien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSinhVien.Location = new System.Drawing.Point(0, 818);
            this.pnSinhVien.Name = "pnSinhVien";
            this.pnSinhVien.Size = new System.Drawing.Size(1944, 221);
            this.pnSinhVien.TabIndex = 21;
            // 
            // checkBoxPHAI
            // 
            this.checkBoxPHAI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "PHAI", true));
            this.checkBoxPHAI.Location = new System.Drawing.Point(708, 34);
            this.checkBoxPHAI.MenuManager = this.barManager1;
            this.checkBoxPHAI.Name = "checkBoxPHAI";
            this.checkBoxPHAI.Properties.Caption = "";
            this.checkBoxPHAI.Size = new System.Drawing.Size(32, 29);
            this.checkBoxPHAI.TabIndex = 21;
            // 
            // cboxMALOP
            // 
            this.cboxMALOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSV, "MALOP", true));
            this.cboxMALOP.DataSource = this.bdsLOP;
            this.cboxMALOP.DisplayMember = "MALOP";
            this.cboxMALOP.FormattingEnabled = true;
            this.cboxMALOP.Location = new System.Drawing.Point(1126, 37);
            this.cboxMALOP.Name = "cboxMALOP";
            this.cboxMALOP.Size = new System.Drawing.Size(208, 30);
            this.cboxMALOP.TabIndex = 20;
            this.cboxMALOP.ValueMember = "MALOP";
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.dS1;
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "PASSWORD", true));
            this.txtPASSWORD.Location = new System.Drawing.Point(1126, 88);
            this.txtPASSWORD.MenuManager = this.barManager1;
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPASSWORD.Properties.Appearance.Options.UseFont = true;
            this.txtPASSWORD.Properties.UseReadOnlyAppearance = false;
            this.txtPASSWORD.Properties.UseSystemPasswordChar = true;
            this.txtPASSWORD.Size = new System.Drawing.Size(208, 30);
            this.txtPASSWORD.TabIndex = 18;
            // 
            // checkBoxDANGNGHIHOC
            // 
            this.checkBoxDANGNGHIHOC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "DANGHIHOC", true));
            this.checkBoxDANGNGHIHOC.Location = new System.Drawing.Point(1126, 127);
            this.checkBoxDANGNGHIHOC.MenuManager = this.barManager1;
            this.checkBoxDANGNGHIHOC.Name = "checkBoxDANGNGHIHOC";
            this.checkBoxDANGNGHIHOC.Properties.Caption = "";
            this.checkBoxDANGNGHIHOC.Size = new System.Drawing.Size(112, 29);
            this.checkBoxDANGNGHIHOC.TabIndex = 16;
            // 
            // dateEditNGAYSINH
            // 
            this.dateEditNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NGAYSINH", true));
            this.dateEditNGAYSINH.EditValue = null;
            this.dateEditNGAYSINH.Location = new System.Drawing.Point(708, 129);
            this.dateEditNGAYSINH.MenuManager = this.barManager1;
            this.dateEditNGAYSINH.Name = "dateEditNGAYSINH";
            this.dateEditNGAYSINH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNGAYSINH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNGAYSINH.Size = new System.Drawing.Size(233, 28);
            this.dateEditNGAYSINH.TabIndex = 12;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSV, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(708, 83);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(233, 30);
            this.txtDIACHI.TabIndex = 10;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSV, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(318, 129);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(220, 30);
            this.txtTEN.TabIndex = 6;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSV, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(318, 83);
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(220, 30);
            this.txtHO.TabIndex = 4;
            // 
            // txtMASV
            // 
            this.txtMASV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSV, "MASV", true));
            this.txtMASV.Location = new System.Drawing.Point(318, 35);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(220, 30);
            this.txtMASV.TabIndex = 2;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = this.tableAdapterDK;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.tableAdapterLOP;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.tableAdapterSV;
            this.tableAdapterManager.UpdateOrder = qlsv_tc.DS1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterDK
            // 
            this.tableAdapterDK.ClearBeforeFill = true;
            // 
            // tableAdapterLOP
            // 
            this.tableAdapterLOP.ClearBeforeFill = true;
            // 
            // bdsDK
            // 
            this.bdsDK.DataMember = "FK_CTLTC_SINHVIEN";
            this.bdsDK.DataSource = this.bdsSV;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1944, 1059);
            this.Controls.Add(this.pnSinhVien);
            this.Controls.Add(this.SINHVIENGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSinhVien";
            this.Text = "frmSinhVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SINHVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnSinhVien.ResumeLayout(false);
            this.pnSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxPHAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPASSWORD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxDANGNGHIHOC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNGAYSINH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNGAYSINH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
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
        private DevExpress.XtraGrid.GridControl SINHVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DS1 dS1;
        private System.Windows.Forms.BindingSource bdsSV;
        private DS1TableAdapters.SINHVIENTableAdapter tableAdapterSV;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colDANGHIHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colPASSWORD;
        private System.Windows.Forms.Panel pnSinhVien;
        private DevExpress.XtraEditors.TextEdit txtPASSWORD;
        private DevExpress.XtraEditors.CheckEdit checkBoxDANGNGHIHOC;
        private DevExpress.XtraEditors.DateEdit dateEditNGAYSINH;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.TextBox txtTEN;
        private System.Windows.Forms.TextBox txtHO;
        private System.Windows.Forms.TextBox txtMASV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DS1TableAdapters.TableAdapterManager tableAdapterManager;
        private DS1TableAdapters.DANGKYTableAdapter tableAdapterDK;
        private System.Windows.Forms.BindingSource bdsDK;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider error;
        private System.Windows.Forms.ComboBox cboxMALOP;
        private DS1TableAdapters.LOPTableAdapter tableAdapterLOP;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DevExpress.XtraEditors.CheckEdit checkBoxPHAI;
    }
}