using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlsv_tc.Forms
{
    public partial class frmMoLTC : DevExpress.XtraEditors.XtraForm
    {
        private static int _position = 0;
        private static string _flag;
        private static string nienkhoa, hocky, mamh, nhom; // dùng để lưu giá trị cũ để so sánh nếu sửa đổi
        public frmMoLTC()
        {
            InitializeComponent();
        }

       
        private void loadInitializeData()
        {

            dS.EnforceConstraints = false;
            this.tableAdapterMH.Connection.ConnectionString = Program.connstr;
            this.tableAdapterMH.Fill(this.dS.MONHOC);

            this.tableAdapterGV.Connection.ConnectionString = Program.connstr;
            this.tableAdapterGV.Fill(this.dS.GIANGVIEN);

            this.tableAdapterLTC.Connection.ConnectionString = Program.connstr;
            this.tableAdapterLTC.Fill(this.dS.LOPTINCHI);
           
            this.tableAdapterDK.Connection.ConnectionString = Program.connstr;
            this.tableAdapterDK.Fill(this.dS.DANGKY);

        }
        private void frmMoLTC_Load(object sender, EventArgs e)
        {
           
            loadInitializeData();
            
            err.Clear();

            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Ultils.BindingDataToComBo(cboxKhoa, Program.bds_dspm.DataSource);

            gbMoLTC.Enabled = false;
            LTCGridControl.Enabled = true;

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
           btnGhi.Enabled = btnHuy.Enabled =  false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _flag = "ADD";
            cboxKhoa.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            

            LTCGridControl.Enabled = false;
            gbMoLTC.Enabled = true;

            // thao tác chuẩn bị thêm
            bdsLTC.AddNew();

            cmbMAGV.SelectedIndex = 1;
            cmbMAGV.SelectedIndex = 0;

            cmbMAMH.SelectedIndex = 1;
            cmbMAMH.SelectedIndex = 0;

            txtMaKhoa.Text = Ultils.GetMaKhoa();

            // mặc định là false
            txtHUYLOP.Checked = false;

            if (Program.mGroup.Equals(Program.role.KHOA.ToString())) txtMaKhoa.Enabled = false;
            else if(Program.mGroup.Equals(Program.role.PGV.ToString())) txtMaKhoa.Enabled = true;
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

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            bdsLTC.CancelEdit();
            
            // load lại cả form...
            frmMoLTC_Load(sender, e);
            if (_position > 0)
            {
                bdsLTC.Position = _position;
            }
            if (Program.mGroup.Equals(Program.role.PGV.ToString())) cboxKhoa.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMoLTC_Load(sender, e);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }
        // ====================== SUPPORT VALIDATION ====================== //
        private bool ValidateInfo()
        {
            err.Clear();

            // TODO : Check khoảng trống ở textField
            if (txtNIENKHOA.Text.Trim().Equals(""))
            {
                this.err.SetError(txtNIENKHOA, "Niên Khoá không được để trống !");
                return false;
            }
            if (cmbMAGV.Text.Equals(""))
            {
                this.err.SetError(cmbMAGV, "Vui lòng chọn MAGV !");
                return false;
            }
            if (txtHOCKY.Text.Equals(""))
            {
                this.err.SetError(txtHOCKY, "Vui lòng chọn HOCKY !");
                return false;
            }
            if (cmbMAMH.Text.Equals(""))
            {
                this.err.SetError(cmbMAMH, "Vui lòng chọn MAMH !");
                return false;
            }
            if (txtSOSVTOITHIEU.Text.Equals(""))
            {
                this.err.SetError(txtSOSVTOITHIEU, "Vui lòng chọn SOSVTOITHIEU !");
                return false;
            }

            if (txtNHOM.Text.Equals(""))
            {
                this.err.SetError(txtNHOM, "Vui lòng chọn NHOM !");
                return false;
            }
            if (txtMaKhoa.Text.Trim().Equals(""))
            {
                this.err.SetError(txtMaKhoa, "MAKHOA không được để trống !");
                return false;
            }

            if (_flag.Equals("ADD"))
            {
                return checkExist(txtNIENKHOA.Text.Trim(), txtHOCKY.Text.Trim(), cmbMAMH.Text.Trim(), txtNHOM.Text.Trim());
            }
            else if (_flag.Equals("EDIT"))
            {
                if(!txtNIENKHOA.Text.Trim().Equals(nienkhoa) || 
                    !txtHOCKY.Text.Trim().Equals(hocky) ||
                    !txtNHOM.Text.Trim().Equals(nhom) ||
                    !cmbMAMH.Text.Trim().Equals(mamh))
                {
                    return checkExist(txtNIENKHOA.Text.Trim(), txtHOCKY.Text.Trim(), cmbMAMH.Text.Trim(), txtNHOM.Text.Trim());

                }
            }
            return true;
        }

        private bool checkExist(string strNienKhoa,string strHocKy,string strMaMH,string strNhom)
        {
            // check exist LOPTINCHI
            string query = "DECLARE @return_value INT \n" +
                $"EXEC @return_value=[dbo].[SP_CheckExistLTC] @nienkhoa=N'{strNienKhoa}', @hocki={strHocKy}, @mamh=N'{strMaMH}', @nhom={strNhom};\n" +
                "SELECT 'Return Value'=@return_value;";
            int result = Ultils.CheckDataHelper(query);
            if (result > 0) // exist
            {
                XtraMessageBox.Show($"Đã Tồn Tại Lớp Tín Chỉ có niên khóa: {strNienKhoa}, học kỳ: {strHocKy} \n" +
                    $"Mã MH: {strMaMH}, Nhóm: {strNhom}");
                return false;
            }
            return true;
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

                        LTCGridControl.Enabled = true;
                        gbMoLTC.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;

                        this.bdsLTC.EndEdit();
                        this.bdsLTC.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        this.tableAdapterLTC.Update(this.dS.LOPTINCHI);
                        if (Program.mGroup.Equals(Program.role.PGV.ToString())) cboxKhoa.Enabled = true;
                        XtraMessageBox.Show("Ghi Thành Công");
                      
                    }
                    catch (Exception ex)
                    {
                        bdsLTC.RemoveCurrent();
                        XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _flag = "EDIT";
            // lưu vào biến để so sánh nếu thay đổi thì kiểm tra trùng
            nienkhoa = txtNIENKHOA.Text.Trim();
            hocky = txtHOCKY.Text.Trim();
            mamh = cmbMAMH.Text.Trim();
            nhom = txtNHOM.Text.Trim();

            // TODO: Display To handle
            LTCGridControl.Enabled = false;
            gbMoLTC.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = true;

            btnThem.Enabled
                = btnXoa.Enabled
                = btnHieuChinh.Enabled
                = btnUndo.Enabled
                = btnReload.Enabled = false;
            cboxKhoa.Enabled = false;

            if (Program.mGroup.Equals(Program.role.KHOA.ToString())) txtMaKhoa.Enabled = false;// role khoa thi ko dc sua
            else if (Program.mGroup.Equals(Program.role.PGV.ToString())) txtMaKhoa.Enabled = true;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDK.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa lớp này vì Lớp đã có sinh viên đăng ký.", "", MessageBoxButtons.OK);
                return;
            }
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa Lớp này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsLTC.RemoveCurrent();
                    this.tableAdapterLTC.Connection.ConnectionString = Program.connstr;
                    int check = this.tableAdapterLTC.Update(this.dS.LOPTINCHI);
                    if (check > 0) XtraMessageBox.Show("Xoá Thành Công");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa Lớp.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterLTC.Fill(this.dS.LOPTINCHI);
                    return;

                }
            }
            if (bdsLTC.Count == 0) btnXoa.Enabled = btnHieuChinh.Enabled =  btnHuy.Enabled =false;


            btnReload.Enabled = true;
            gbMoLTC.Enabled = false;

            if (_position > 0)
            {
                bdsLTC.Position = _position;
            }
        }

        private void txtHUYLOP_CheckedChanged(object sender, EventArgs e)
        {
            // nếu đã có sinh viên đăng kí thì ko cho hủy lớp
            if (_flag.Equals("EDIT"))
            {
                if(bdsDK.Count > 0 && txtHUYLOP.Checked)
                {
                    XtraMessageBox.Show("Không thể hủy lớp này vì Lớp đã có sinh viên đăng ký.", "", MessageBoxButtons.OK);
                    txtHUYLOP.Checked = !txtHUYLOP.Checked;
                }
            }
        }

        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _position = e.RowHandle;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gbMoLTC.Enabled)
            {

                String notifi = " Dữ liệu chưa lưu vào Database. \n Bạn có chắc muốn thoát !";


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

        private void txtNienKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('-')) return;
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
    }
}