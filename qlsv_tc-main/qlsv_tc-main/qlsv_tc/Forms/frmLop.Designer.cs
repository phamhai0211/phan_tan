
namespace qlsv_tc.Forms
{
    partial class frmLop
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label kHOAHOCLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.dS1 = new qlsv_tc.DS1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOAHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnLop = new System.Windows.Forms.Panel();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtKHOAHOC = new DevExpress.XtraEditors.TextEdit();
            this.txtTENLOP = new DevExpress.XtraEditors.TextEdit();
            this.txtMALOP = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableAdapterLop = new qlsv_tc.DS1TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new qlsv_tc.DS1TableAdapters.TableAdapterManager();
            this.tableAdapterSinhVien = new qlsv_tc.DS1TableAdapters.SINHVIENTableAdapter();
            this.error = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            kHOAHOCLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKHOAHOC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENLOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(243, 42);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(83, 22);
            mALOPLabel.TabIndex = 1;
            mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(243, 102);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(90, 22);
            tENLOPLabel.TabIndex = 3;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // kHOAHOCLabel
            // 
            kHOAHOCLabel.AutoSize = true;
            kHOAHOCLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kHOAHOCLabel.Location = new System.Drawing.Point(644, 42);
            kHOAHOCLabel.Name = "kHOAHOCLabel";
            kHOAHOCLabel.Size = new System.Drawing.Size(113, 22);
            kHOAHOCLabel.TabIndex = 5;
            kHOAHOCLabel.Text = "KHOAHOC:";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOALabel.Location = new System.Drawing.Point(644, 102);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(103, 22);
            mAKHOALabel.TabIndex = 7;
            mAKHOALabel.Text = "MAKHOA:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1368, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 708);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1368, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 674);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1368, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 674);
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
            this.panelControl1.Size = new System.Drawing.Size(1368, 80);
            this.panelControl1.TabIndex = 18;
            // 
            // cboxKhoa
            // 
            this.cboxKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxKhoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxKhoa.FormattingEnabled = true;
            this.cboxKhoa.Location = new System.Drawing.Point(517, 24);
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
            this.lblTenKhoa.Location = new System.Drawing.Point(451, 27);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(47, 25);
            this.lblTenKhoa.TabIndex = 0;
            this.lblTenKhoa.Text = "Khoa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lOPGridControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 376);
            this.panel1.TabIndex = 19;
            // 
            // lOPGridControl
            // 
            this.lOPGridControl.DataSource = this.bdsLop;
            this.lOPGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lOPGridControl.Location = new System.Drawing.Point(0, 0);
            this.lOPGridControl.MainView = this.gridView1;
            this.lOPGridControl.MenuManager = this.barManager1;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(1368, 376);
            this.lOPGridControl.TabIndex = 0;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colKHOAHOC,
            this.colMAKHOA});
            this.gridView1.GridControl = this.lOPGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP
            // 
            this.colMALOP.AppearanceCell.Options.UseTextOptions = true;
            this.colMALOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALOP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
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
            this.colMALOP.OptionsColumn.AllowFocus = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 112;
            // 
            // colTENLOP
            // 
            this.colTENLOP.AppearanceCell.Options.UseTextOptions = true;
            this.colTENLOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENLOP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTENLOP.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colTENLOP.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENLOP.AppearanceHeader.Options.UseBackColor = true;
            this.colTENLOP.AppearanceHeader.Options.UseFont = true;
            this.colTENLOP.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENLOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 30;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.OptionsColumn.AllowFocus = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 112;
            // 
            // colKHOAHOC
            // 
            this.colKHOAHOC.AppearanceCell.Options.UseTextOptions = true;
            this.colKHOAHOC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKHOAHOC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colKHOAHOC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colKHOAHOC.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colKHOAHOC.AppearanceHeader.Options.UseBackColor = true;
            this.colKHOAHOC.AppearanceHeader.Options.UseFont = true;
            this.colKHOAHOC.AppearanceHeader.Options.UseTextOptions = true;
            this.colKHOAHOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKHOAHOC.FieldName = "KHOAHOC";
            this.colKHOAHOC.MinWidth = 30;
            this.colKHOAHOC.Name = "colKHOAHOC";
            this.colKHOAHOC.OptionsColumn.AllowEdit = false;
            this.colKHOAHOC.OptionsColumn.AllowFocus = false;
            this.colKHOAHOC.Visible = true;
            this.colKHOAHOC.VisibleIndex = 2;
            this.colKHOAHOC.Width = 112;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.AppearanceCell.Options.UseTextOptions = true;
            this.colMAKHOA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAKHOA.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMAKHOA.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colMAKHOA.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKHOA.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKHOA.AppearanceHeader.Options.UseFont = true;
            this.colMAKHOA.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAKHOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 30;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.OptionsColumn.AllowEdit = false;
            this.colMAKHOA.OptionsColumn.AllowFocus = false;
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            this.colMAKHOA.Width = 112;
            // 
            // pnLop
            // 
            this.pnLop.Controls.Add(this.txtMaKhoa);
            this.pnLop.Controls.Add(mAKHOALabel);
            this.pnLop.Controls.Add(kHOAHOCLabel);
            this.pnLop.Controls.Add(this.txtKHOAHOC);
            this.pnLop.Controls.Add(tENLOPLabel);
            this.pnLop.Controls.Add(this.txtTENLOP);
            this.pnLop.Controls.Add(mALOPLabel);
            this.pnLop.Controls.Add(this.txtMALOP);
            this.pnLop.Controls.Add(this.pictureBox1);
            this.pnLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLop.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLop.Location = new System.Drawing.Point(0, 490);
            this.pnLop.Name = "pnLop";
            this.pnLop.Size = new System.Drawing.Size(1368, 218);
            this.pnLop.TabIndex = 20;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MAKHOA", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(763, 99);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(249, 30);
            this.txtMaKhoa.TabIndex = 9;
            // 
            // txtKHOAHOC
            // 
            this.txtKHOAHOC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "KHOAHOC", true));
            this.txtKHOAHOC.Location = new System.Drawing.Point(763, 38);
            this.txtKHOAHOC.MenuManager = this.barManager1;
            this.txtKHOAHOC.Name = "txtKHOAHOC";
            this.txtKHOAHOC.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKHOAHOC.Properties.Appearance.Options.UseFont = true;
            this.txtKHOAHOC.Size = new System.Drawing.Size(249, 30);
            this.txtKHOAHOC.TabIndex = 6;
            // 
            // txtTENLOP
            // 
            this.txtTENLOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "TENLOP", true));
            this.txtTENLOP.Location = new System.Drawing.Point(351, 98);
            this.txtTENLOP.MenuManager = this.barManager1;
            this.txtTENLOP.Name = "txtTENLOP";
            this.txtTENLOP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENLOP.Properties.Appearance.Options.UseFont = true;
            this.txtTENLOP.Size = new System.Drawing.Size(239, 30);
            this.txtTENLOP.TabIndex = 4;
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLop, "MALOP", true));
            this.txtMALOP.Location = new System.Drawing.Point(351, 38);
            this.txtMALOP.MenuManager = this.barManager1;
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMALOP.Properties.Appearance.Options.UseFont = true;
            this.txtMALOP.Properties.MaxLength = 10;
            this.txtMALOP.Size = new System.Drawing.Size(239, 30);
            this.txtMALOP.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::qlsv_tc.Properties.Resources._3442161;
            this.pictureBox1.Location = new System.Drawing.Point(23, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableAdapterLop
            // 
            this.tableAdapterLop.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.tableAdapterLop;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.tableAdapterSinhVien;
            this.tableAdapterManager.UpdateOrder = qlsv_tc.DS1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterSinhVien
            // 
            this.tableAdapterSinhVien.ClearBeforeFill = true;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSinhVien.DataSource = this.bdsLop;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 728);
            this.Controls.Add(this.pnLop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLop";
            this.Text = "Danh Mục Lớp";
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnLop.ResumeLayout(false);
            this.pnLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKHOAHOC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENLOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnLop;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS1 dS1;
        private DS1TableAdapters.LOPTableAdapter tableAdapterLop;
        private DS1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider error;
        private DevExpress.XtraEditors.TextEdit txtKHOAHOC;
        private DevExpress.XtraEditors.TextEdit txtTENLOP;
        private DevExpress.XtraEditors.TextEdit txtMALOP;
        private DS1TableAdapters.SINHVIENTableAdapter tableAdapterSinhVien;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private System.Windows.Forms.TextBox txtMaKhoa;
    }
}