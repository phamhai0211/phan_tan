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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        private static int _position = 0;
        private static string _flag;
        private static string malop;
        public frmLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS1);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            error.ClearErrors();

            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Ultils.BindingDataToComBo(cboxKhoa, Program.bds_dspm.DataSource);

            pnLop.Enabled = false;
            lOPGridControl.Enabled = true;

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
            this.tableAdapterLop.Connection.ConnectionString = Program.connstr;
            this.tableAdapterLop.Fill(this.dS1.LOP);
            this.tableAdapterSinhVien.Connection.ConnectionString = Program.connstr;
            this.tableAdapterSinhVien.Fill(this.dS1.SINHVIEN);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _flag = "ADD";
            cboxKhoa.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;


            lOPGridControl.Enabled = false;
            pnLop.Enabled = true;

            bdsLop.AddNew();

            txtMaKhoa.Text = Ultils.GetMaKhoa();

            if (Program.mGroup.Equals(Program.role.KHOA.ToString()))
                txtMaKhoa.Enabled = false;
            else if(Program.mGroup.Equals(Program.role.PGV.ToString()))
                txtMaKhoa.Enabled = true;

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _flag = "EDIT";
            malop = txtMALOP.Text.Trim();

            // TODO: Display To handle
            lOPGridControl.Enabled = false;
            pnLop.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = true;

            btnThem.Enabled
                = btnXoa.Enabled
                = btnHieuChinh.Enabled
                = btnUndo.Enabled
                = btnReload.Enabled = false;
            cboxKhoa.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSinhVien.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa lớp vì đã có sinh viên.", "", MessageBoxButtons.OK);
                return;
            }
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa lớp này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsLop.RemoveCurrent();
                    this.tableAdapterLop.Connection.ConnectionString = Program.connstr;
                    int check = this.tableAdapterLop.Update(this.dS1.LOP);
                    if (check > 0) XtraMessageBox.Show("Xoá Thành Công");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa lớp.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterLop.Fill(this.dS1.LOP);
                    return;

                }
            }
            if (bdsLop.Count == 0) btnXoa.Enabled = btnHieuChinh.Enabled = btnHuy.Enabled = false;


            btnReload.Enabled = true;
            pnLop.Enabled = false;

            if (_position > 0)
            {
                bdsLop.Position = _position;
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

                        lOPGridControl.Enabled = true;
                        pnLop.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;

                        this.bdsLop.EndEdit();
                        this.bdsLop.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        this.tableAdapterLop.Update(this.dS1.LOP);
                        if (Program.mGroup.Equals(Program.role.PGV.ToString())) cboxKhoa.Enabled = true;
                        XtraMessageBox.Show("Ghi Thành Công");

                    }
                    catch (Exception ex)
                    {
                        bdsLop.RemoveCurrent();
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
            if (txtMALOP.Text.Trim().Equals(""))
            {
                this.error.SetError(txtMALOP, "MALOP không được để trống !");
                return false;
            }
            if (txtTENLOP.Text.Trim().Equals(""))
            {
                this.error.SetError(txtTENLOP, "TENLOP không được để trống !");
                return false;
            }
            if (txtKHOAHOC.Text.Trim().Equals(""))
            {
                this.error.SetError(txtKHOAHOC, "KHOAHOC không được để trống !");
                return false;
            }
            if (txtMaKhoa.Text.Trim().Equals(""))
            {
                this.error.SetError(txtMaKhoa, "MAKHOA không được để trống !");
                return false;
            }
            if (_flag.Equals("ADD"))
            {
                return checkExistLop(txtMALOP.Text.Trim());
            }else if (_flag.Equals("EDIT"))
            {
                // thay đổi mã lớp
                if (!txtMALOP.Text.Trim().Equals(malop))
                {
                    return checkExistLop(txtMALOP.Text.Trim());
                }
                return true;
            }
            return checkExistLop(txtMALOP.Text.Trim());
        }

        private bool checkExistLop(string malop)
        {
            // check exist MONHOC
            string query = "DECLARE @return_value INT \n" +
                $"EXEC @return_value=[dbo].[SP_CheckExistLop] @malop=N'{malop}' " +
                "SELECT 'Return Value'=@return_value;";
            int result = Ultils.CheckDataHelper(query);
            if (result > 0) // exist
            {
                XtraMessageBox.Show($"Đã Tồn Tại Lớp có MALOP: {malop}");
                this.error.SetError(txtMALOP, "Đã Tồn Tại MALOP");
                return false;
            }
            return true;
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();

            // load lại cả form...
            frmLop_Load(sender, e);
            if (_position > 0)
            {
                bdsLop.Position = _position;
            }
            if (Program.mGroup.Equals(Program.role.PGV.ToString())) cboxKhoa.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLop_Load(sender, e);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pnLop.Enabled)
            {

                String notifi = " Dữ liệu Lớp chưa lưu vào Database. \n Bạn có chắc muốn thoát !";


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
    }

}