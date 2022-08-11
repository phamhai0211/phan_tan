
namespace qlsv_tc.Forms
{
    partial class frmMonHoc
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label sOTIET_LTLabel;
            System.Windows.Forms.Label sOTIET_THLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
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
            this.dS1 = new qlsv_tc.DS1();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterMonHoc = new qlsv_tc.DS1TableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new qlsv_tc.DS1TableAdapters.TableAdapterManager();
            this.MonHocGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMonHoc = new System.Windows.Forms.Panel();
            this.spSOTIETTH = new DevExpress.XtraEditors.SpinEdit();
            this.spSOTIETLT = new DevExpress.XtraEditors.SpinEdit();
            this.txtTENMH = new System.Windows.Forms.TextBox();
            this.txtMAMH = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bdsLtc = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterLTC = new qlsv_tc.DS1TableAdapters.LOPTINCHITableAdapter();
            this.error = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            sOTIET_LTLabel = new System.Windows.Forms.Label();
            sOTIET_THLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSOTIETTH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSOTIETLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLtc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(301, 30);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(61, 19);
            mAMHLabel.TabIndex = 1;
            mAMHLabel.Text = "MAMH:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(301, 88);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(68, 19);
            tENMHLabel.TabIndex = 3;
            tENMHLabel.Text = "TENMH:";
            // 
            // sOTIET_LTLabel
            // 
            sOTIET_LTLabel.AutoSize = true;
            sOTIET_LTLabel.Location = new System.Drawing.Point(687, 30);
            sOTIET_LTLabel.Name = "sOTIET_LTLabel";
            sOTIET_LTLabel.Size = new System.Drawing.Size(94, 19);
            sOTIET_LTLabel.TabIndex = 5;
            sOTIET_LTLabel.Text = "SOTIET LT:";
            // 
            // sOTIET_THLabel
            // 
            sOTIET_THLabel.AutoSize = true;
            sOTIET_THLabel.Location = new System.Drawing.Point(687, 88);
            sOTIET_THLabel.Name = "sOTIET_THLabel";
            sOTIET_THLabel.Size = new System.Drawing.Size(97, 19);
            sOTIET_THLabel.TabIndex = 7;
            sOTIET_THLabel.Text = "SOTIET TH:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1408, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 664);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1408, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 630);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1408, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 630);
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
            // dS1
            // 
            this.dS1.DataSetName = "DS1";
            this.dS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS1;
            // 
            // tableAdapterMonHoc
            // 
            this.tableAdapterMonHoc.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.tableAdapterMonHoc;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = qlsv_tc.DS1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MonHocGridControl
            // 
            this.MonHocGridControl.DataSource = this.bdsMonHoc;
            this.MonHocGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonHocGridControl.Location = new System.Drawing.Point(0, 0);
            this.MonHocGridControl.MainView = this.gridView1;
            this.MonHocGridControl.MenuManager = this.barManager1;
            this.MonHocGridControl.Name = "MonHocGridControl";
            this.MonHocGridControl.Size = new System.Drawing.Size(1408, 333);
            this.MonHocGridControl.TabIndex = 18;
            this.MonHocGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colSOTIET_LT,
            this.colSOTIET_TH});
            this.gridView1.GridControl = this.MonHocGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAMH
            // 
            this.colMAMH.AppearanceCell.Options.UseTextOptions = true;
            this.colMAMH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAMH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colMAMH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAMH.AppearanceHeader.Options.UseBackColor = true;
            this.colMAMH.AppearanceHeader.Options.UseFont = true;
            this.colMAMH.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAMH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 30;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.OptionsColumn.AllowFocus = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 112;
            // 
            // colTENMH
            // 
            this.colTENMH.AppearanceCell.Options.UseTextOptions = true;
            this.colTENMH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENMH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colTENMH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENMH.AppearanceHeader.Options.UseBackColor = true;
            this.colTENMH.AppearanceHeader.Options.UseFont = true;
            this.colTENMH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENMH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 30;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.OptionsColumn.AllowFocus = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 112;
            // 
            // colSOTIET_LT
            // 
            this.colSOTIET_LT.AppearanceCell.Options.UseTextOptions = true;
            this.colSOTIET_LT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOTIET_LT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colSOTIET_LT.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTIET_LT.AppearanceHeader.Options.UseBackColor = true;
            this.colSOTIET_LT.AppearanceHeader.Options.UseFont = true;
            this.colSOTIET_LT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOTIET_LT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOTIET_LT.FieldName = "SOTIET_LT";
            this.colSOTIET_LT.MinWidth = 30;
            this.colSOTIET_LT.Name = "colSOTIET_LT";
            this.colSOTIET_LT.OptionsColumn.AllowEdit = false;
            this.colSOTIET_LT.OptionsColumn.AllowFocus = false;
            this.colSOTIET_LT.Visible = true;
            this.colSOTIET_LT.VisibleIndex = 2;
            this.colSOTIET_LT.Width = 112;
            // 
            // colSOTIET_TH
            // 
            this.colSOTIET_TH.AppearanceCell.Options.UseTextOptions = true;
            this.colSOTIET_TH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOTIET_TH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colSOTIET_TH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTIET_TH.AppearanceHeader.Options.UseBackColor = true;
            this.colSOTIET_TH.AppearanceHeader.Options.UseFont = true;
            this.colSOTIET_TH.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOTIET_TH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOTIET_TH.FieldName = "SOTIET_TH";
            this.colSOTIET_TH.MinWidth = 30;
            this.colSOTIET_TH.Name = "colSOTIET_TH";
            this.colSOTIET_TH.OptionsColumn.AllowEdit = false;
            this.colSOTIET_TH.OptionsColumn.AllowFocus = false;
            this.colSOTIET_TH.Visible = true;
            this.colSOTIET_TH.VisibleIndex = 3;
            this.colSOTIET_TH.Width = 112;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MonHocGridControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1408, 333);
            this.panel1.TabIndex = 19;
            // 
            // pnMonHoc
            // 
            this.pnMonHoc.Controls.Add(sOTIET_THLabel);
            this.pnMonHoc.Controls.Add(this.spSOTIETTH);
            this.pnMonHoc.Controls.Add(sOTIET_LTLabel);
            this.pnMonHoc.Controls.Add(this.spSOTIETLT);
            this.pnMonHoc.Controls.Add(tENMHLabel);
            this.pnMonHoc.Controls.Add(this.txtTENMH);
            this.pnMonHoc.Controls.Add(mAMHLabel);
            this.pnMonHoc.Controls.Add(this.txtMAMH);
            this.pnMonHoc.Controls.Add(this.pictureBox1);
            this.pnMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMonHoc.Location = new System.Drawing.Point(0, 367);
            this.pnMonHoc.Name = "pnMonHoc";
            this.pnMonHoc.Size = new System.Drawing.Size(1408, 297);
            this.pnMonHoc.TabIndex = 20;
            // 
            // spSOTIETTH
            // 
            this.spSOTIETTH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "SOTIET_TH", true));
            this.spSOTIETTH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSOTIETTH.Location = new System.Drawing.Point(803, 84);
            this.spSOTIETTH.MenuManager = this.barManager1;
            this.spSOTIETTH.Name = "spSOTIETTH";
            this.spSOTIETTH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spSOTIETTH.Size = new System.Drawing.Size(84, 28);
            this.spSOTIETTH.TabIndex = 8;
            // 
            // spSOTIETLT
            // 
            this.spSOTIETLT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "SOTIET_LT", true));
            this.spSOTIETLT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSOTIETLT.Location = new System.Drawing.Point(803, 26);
            this.spSOTIETLT.MenuManager = this.barManager1;
            this.spSOTIETLT.Name = "spSOTIETLT";
            this.spSOTIETLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spSOTIETLT.Size = new System.Drawing.Size(84, 28);
            this.spSOTIETLT.TabIndex = 6;
            // 
            // txtTENMH
            // 
            this.txtTENMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMonHoc, "TENMH", true));
            this.txtTENMH.Location = new System.Drawing.Point(401, 85);
            this.txtTENMH.Name = "txtTENMH";
            this.txtTENMH.Size = new System.Drawing.Size(234, 27);
            this.txtTENMH.TabIndex = 4;
            // 
            // txtMAMH
            // 
            this.txtMAMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "MAMH", true));
            this.txtMAMH.Location = new System.Drawing.Point(401, 26);
            this.txtMAMH.MenuManager = this.barManager1;
            this.txtMAMH.Name = "txtMAMH";
            this.txtMAMH.Properties.MaxLength = 10;
            this.txtMAMH.Size = new System.Drawing.Size(234, 28);
            this.txtMAMH.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::qlsv_tc.Properties.Resources._1116589;
            this.pictureBox1.Location = new System.Drawing.Point(51, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bdsLtc
            // 
            this.bdsLtc.DataMember = "FK_LOPTINCHI_MONHOC";
            this.bdsLtc.DataSource = this.bdsMonHoc;
            // 
            // tableAdapterLTC
            // 
            this.tableAdapterLTC.ClearBeforeFill = true;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 684);
            this.Controls.Add(this.pnMonHoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMonHoc";
            this.Text = "Môn Học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnMonHoc.ResumeLayout(false);
            this.pnMonHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSOTIETTH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSOTIETLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLtc)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DS1 dS1;
        private DS1TableAdapters.MONHOCTableAdapter tableAdapterMonHoc;
        private DS1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl MonHocGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel pnMonHoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SpinEdit spSOTIETTH;
        private DevExpress.XtraEditors.SpinEdit spSOTIETLT;
        private System.Windows.Forms.TextBox txtTENMH;
        private DevExpress.XtraEditors.TextEdit txtMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH;
        private System.Windows.Forms.BindingSource bdsLtc;
        private DS1TableAdapters.LOPTINCHITableAdapter tableAdapterLTC;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider error;
    }
}