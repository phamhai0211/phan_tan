using qlsv_tc.Forms;
using qlsv_tc.Report.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace qlsv_tc
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }


        public void HienThiMenu()
        {
            MANV.Text = "MÃ NV: " + Program.username;
            HOTEN.Text = "HỌ TÊN: " + Program.mHoten;
            NHOM.Text = "NHÓM: " + Program.mGroup;

            // phân quyền
            // dựa vào Program.mGroup để bật tắt các module cần thiết
            rb_quantri.Visible = true;
            btnDangXuat.Enabled = true;
            btnDangNhap.Enabled = false;

            if (Program.mGroup.Equals(Program.role.SV.ToString(), StringComparison.Ordinal))
            {
                btnDangKyLTC.Enabled = true;
                btnTaoTaiKhoan.Enabled = btnSinhVien.Enabled = btnLop.Enabled = btnMoLTC.Enabled = btnHocPhi.Enabled = btnMonHoc.Enabled = btnDiemSV.Enabled = false;

                rb_baocao.Visible = false;
            }else if( Program.mGroup.Equals(Program.role.KHOA.ToString(), StringComparison.Ordinal) ||
                      Program.mGroup.Equals(Program.role.PGV.ToString(), StringComparison.Ordinal))
            {
                btnTaoTaiKhoan.Enabled = true;
                rb_baocao.Visible = true;
                btnHocPhi.Enabled = false;
                btnSinhVien.Enabled = btnMoLTC.Enabled = btnDangKyLTC.Enabled = btnLop.Enabled = btnMonHoc.Enabled =  btnDiemSV.Enabled =true;
                btnDsDongHPLop.Enabled = false;
                btnInDSLTC.Enabled = true;
                btnBangDiemMonHoc.Enabled = true;
                btnLapNhapXuatNV.Enabled = true;
                btnDsDongHPLop.Enabled = true;
                btnPhieuDiemSinhVien.Enabled = true;
                btnBangDiemTK.Enabled = true;

            }
            else if (Program.mGroup.Equals(Program.role.PKT.ToString(), StringComparison.Ordinal))
            {
                btnTaoTaiKhoan.Enabled = true;
                rb_baocao.Visible = true;

                btnHocPhi.Enabled = true;
                btnSinhVien.Enabled = btnMoLTC.Enabled = btnDangKyLTC.Enabled = btnLop.Enabled =  btnMonHoc.Enabled = btnDiemSV.Enabled = false;
                btnInDSLTC.Enabled = false;
                btnBangDiemMonHoc.Enabled = false;
                btnLapNhapXuatNV.Enabled = false;
                btnDsDongHPLop.Enabled = true;
                btnPhieuDiemSinhVien.Enabled = false;
                btnBangDiemTK.Enabled = false;
            }
        }

        public void Dangxuat()
        {
            MANV.Text = "MÃ NV: ";
            HOTEN.Text = "HỌ TÊN: ";
            NHOM.Text = "NHÓM: ";

            Program.connstr = Program.rootConnstr;


            rb_quantri.Visible = false;
            rb_baocao.Visible = false;
            btnDangXuat.Enabled = btnTaoTaiKhoan.Enabled = false;

            // tạo đối tượng mới sau 1 loạt tác động filter
            Program.bds_dspm = new BindingSource();
            // đóng tất cả các form còn mở 
            foreach(Form f in Program.frmMain.MdiChildren)
                f.Close();
        }


        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMoLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = CheckExists(typeof(frmMoLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmMoLTC f = new frmMoLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dangxuat();

            btnDangNhap_ItemClick(sender, e);
        }

    
        private void btnDangKyLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmDangKy));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKy f = new frmDangKy();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmDongHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmDongHocPhi f = new frmDongHocPhi();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // tự động hiện form đăng nhập 
            btnDangNhap.PerformClick();

        }

        private void btnInDSLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmReportLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmReportLTC f = new frmReportLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLapNhapXuatNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmReportSVDkyLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmReportSVDkyLTC f = new frmReportSVDkyLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDsDongHPLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmReportChiTietHpLOP));
            if (frm != null) frm.Activate();
            else
            {
                frmReportChiTietHpLOP f = new frmReportChiTietHpLOP();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBangDiemMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmReportBangDiemMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmReportBangDiemMonHoc f = new frmReportBangDiemMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuDiemSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmReportPhieuDiemSV));
            if (frm != null) frm.Activate();
            else
            {
                frmReportPhieuDiemSV f = new frmReportPhieuDiemSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDiemSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmDIEM));
            if (frm != null) frm.Activate();
            else
            {
                frmDIEM f = new frmDIEM();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBangDiemTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmReportBangDiemTongKet));
            if (frm != null) frm.Activate();
            else
            {
                frmReportBangDiemTongKet f = new frmReportBangDiemTongKet();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
