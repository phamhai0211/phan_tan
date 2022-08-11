using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlsv_tc.Forms
{
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        private static int _position = 0;
        private static string _flag;

        // các biến toàn cục dùng để lưu giá trị cũ để so sánh nếu sửa đổi
        private static string masv;
       
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            error.ClearErrors();

            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Ultils.BindingDataToComBo(cboxKhoa, Program.bds_dspm.DataSource);

            pnSinhVien.Enabled = false;
            SINHVIENGridControl.Enabled = true;

            // TODO : Role Action
            if (Program.mGroup == Program.role.PGV.ToString())// PGV
            {
                cboxKhoa.Visible = true;
                cboxKhoa.Enabled = true;

                btnThem.Enabled
                   = btnXoa.Enabled
                   = btnHieuChinh.Enabled
                   = btnUndo.Enabled
                   = btnGhi.Enabled
                   = true;
            }
            else if (Program.mGroup == Program.role.KHOA.ToString()) // KHOA
            {
                cboxKhoa.Visible = false;

                btnThem.Enabled
                   = btnXoa.Enabled
                   = btnHieuChinh.Enabled
                   = btnUndo.Enabled
                   = btnGhi.Enabled
                   = true;

                cboxKhoa.Visible = true;
                cboxKhoa.Enabled = false;

            }
            btnGhi.Enabled = btnHuy.Enabled = false;
           

        }

        private void cboxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO : Chuyển Bộ Phận

            Ultils.ComboboxHelper(this.cboxKhoa);

            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì
            // thoát.
            if (Program.KetNoi() == 0)
            {
                XtraMessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                loadInitializeData();
            }
        }
        private void loadInitializeData()
        {
            dS1.EnforceConstraints = false;
            this.tableAdapterLOP.Connection.ConnectionString = Program.connstr;
            this.tableAdapterLOP.Fill(this.dS1.LOP);
            this.tableAdapterSV.Connection.ConnectionString = Program.connstr;
            this.tableAdapterSV.Fill(this.dS1.SINHVIEN);
            this.tableAdapterDK.Connection.ConnectionString = Program.connstr;
            this.tableAdapterDK.Fill(this.dS1.DANGKY);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _flag = "ADD";
            cboxKhoa.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;


            SINHVIENGridControl.Enabled = false;
            pnSinhVien.Enabled = true;

            bdsSV.AddNew();
            checkBoxPHAI.Checked = true;
            checkBoxDANGNGHIHOC.Checked = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _flag = "EDIT";
            // lưu vào biến để so sánh nếu thay đổi thì kiểm tra trùng
            masv = txtMASV.Text.Trim();
           
            // TODO: Display To handle
            SINHVIENGridControl.Enabled = false;
            pnSinhVien.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = true;

            btnThem.Enabled
                = btnXoa.Enabled
                = btnHieuChinh.Enabled
                = btnUndo.Enabled
                = btnReload.Enabled = false;
            cboxKhoa.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSV.CancelEdit();

            // load lại cả form...
            frmSinhVien_Load(sender, e);
            if (_position > 0)
            {
                bdsSV.Position = _position;
            }
            if (Program.mGroup.Equals(Program.role.PGV.ToString())) cboxKhoa.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSinhVien_Load(sender, e);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pnSinhVien.Enabled)
            {

                String notifi = " Dữ liệu sinh viên chưa lưu vào Database. \n Bạn có chắc muốn thoát !";


                DialogResult dr = XtraMessageBox.Show(notifi, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
                return;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = this.ValidateInfo();
            if (check)
            {
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        btnThem.Enabled
                        = btnXoa.Enabled
                        = btnHieuChinh.Enabled
                        = btnUndo.Enabled
                        = btnReload.Enabled = true;

                        SINHVIENGridControl.Enabled = true;
                        pnSinhVien.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;

                        this.bdsSV.EndEdit();
                        this.bdsSV.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        this.tableAdapterSV.Update(this.dS1.SINHVIEN);
                        if (Program.mGroup.Equals(Program.role.PGV.ToString())) cboxKhoa.Enabled = true;
                        XtraMessageBox.Show("Ghi Thành Công");

                    }
                    catch (Exception ex)
                    {
                        bdsSV.RemoveCurrent();
                        XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool ValidateInfo()
        {
            error.ClearErrors();

            // TODO : Check khoảng trống ở textField
            if (txtMASV.Text.Trim().Equals(""))
            {
                this.error.SetError(txtMASV, "MASV không được để trống !");
                return false;
            }
            if (txtHO.Text.Trim().Equals(""))
            {
                this.error.SetError(txtHO, "HO không được để trống !");
                return false;
            }
            if (txtTEN.Text.Trim().Equals(""))
            {
                this.error.SetError(txtTEN, "TEN không được để trống !");
                return false;
            }
            if (dateEditNGAYSINH.Text.Trim().Equals(""))
            {
                this.error.SetError(dateEditNGAYSINH, "NGAYSINH không được để trống !");
                return false;
            }
            if (cboxMALOP.Text.Trim().Equals(""))
            {
                this.error.SetError(cboxMALOP, "MALOP không được để trống !");
                return false;
            }
            if (_flag.Equals("ADD"))
            {
                return checkExistSV(txtMASV.Text.Trim());
            }
            else if (_flag.Equals("EDIT"))
            {
                // thay đổi masv
                if (!txtMASV.Text.Trim().Equals(masv))
                {
                    return checkExistSV(txtMASV.Text.Trim());
                }
                return true;
            }

            return checkExistSV(txtMASV.Text.Trim());
        }

        private bool checkExistSV(string masv)
        {
            // check exist MONHOC
            string query = "DECLARE @return_value INT \n" +
                $"EXEC @return_value=[dbo].[SP_CheckExistSV] @masv=N'{masv}' " +
                "SELECT 'Return Value'=@return_value;";
            int result = Ultils.CheckDataHelper(query);
            if (result > 0) // exist
            {
                XtraMessageBox.Show($"Đã tồn tại sinh viên có MASV: {masv}");
                this.error.SetError(txtMASV, "Đã tồn tại MASV");
                return false;
            }
            return true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDK.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa sinh viên vì đã đăng ký.", "", MessageBoxButtons.OK);
                return;
            }
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa sinh viên này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsSV.RemoveCurrent();
                    this.tableAdapterSV.Connection.ConnectionString = Program.connstr;
                    int check = this.tableAdapterSV.Update(this.dS1.SINHVIEN);
                    if (check > 0) XtraMessageBox.Show("Xoá Thành Công");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa lớp.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterSV.Fill(this.dS1.SINHVIEN);
                    return;

                }
            }
            if (bdsSV.Count == 0) btnXoa.Enabled = btnHieuChinh.Enabled = btnHuy.Enabled = false;


            btnReload.Enabled = true;
            pnSinhVien.Enabled = false;

            if (_position > 0)
            {
                bdsDK.Position = _position;
            }
        }
    }
}