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
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS3.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dS3.GIANGVIEN);
            // khoa chỉ được quyền đăng ký cho khoa
            if (Program.mGroup == Program.role.KHOA.ToString())
            {
                rbtnKhoa.Checked = true;
                rbtnPGV.Enabled = rbtnPKT.Enabled = false;
            } // học phí chỉ được quyền đăng ký cho học phí
            else if (Program.mGroup == Program.role.PKT.ToString())
            {
                rbtnPKT.Checked = true;
                rbtnKhoa.Enabled = rbtnPGV.Enabled = false;
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            bool check = this.ValidateInfo();
            if (check)
            {
                createTaiKhoan();
            }
            else
            {
                return;
            }
        }
        // 1: trùng, 0 : not trùng
        private void createTaiKhoan()
        {

            String login = txtLogin.Text;
            String pass = txtPassword.Text;
            String user = (String)lookUpUser.EditValue;
            String role = rbtnKhoa.Checked ? Program.role.KHOA.ToString() : (rbtnPGV.Checked ? Program.role.PGV.ToString() : Program.role.PKT.ToString());

            String subLenh = " EXEC    @return_value = [dbo].[SP_TAOLOGIN] " +
                            " @LGNAME = N'" + login + "', " +
                            " @PASS = N'" + pass + "', " +
                            " @USERNAME = N'" + user + "', " +
                            " @ROLE = N'" + role + "' ";


            // trường hợp tạo tài khoản cho pketoan thì phải dùng LINK2 để link tới Site 3 tạo tài khoản cho pKeToan
            if (role == Program.role.PKT.ToString() && (Program.servername == ((DataRowView)Program.bds_dspm[0])["TENSERVER"].ToString() || Program.servername == ((DataRowView)Program.bds_dspm[1])["TENSERVER"].ToString()))
            {
                // site 1,2 ---> sử dụng LINK2
                subLenh = " EXEC @return_value = LINK2.QLSVTC.[dbo].[SP_TAOLOGIN] " +
                            " @LGNAME = N'" + login + "', " +
                            " @PASS = N'" + pass + "', " +
                            " @USERNAME = N'" + user + "', " +
                            " @ROLE = N'" + role + "' ";
            }
           
            String strLenh = " DECLARE @return_value int " + subLenh +
                         " SELECT  'Return Value' = @return_value ";

            int resultCheckLogin = Ultils.CheckDataHelper(strLenh);

            if (resultCheckLogin == -1)
            {
                XtraMessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultCheckLogin == 1)
            {
                errorProvider.SetError(this.txtLogin, "Login bị trùng . Mời bạn nhập login khác !");
            }
            else if (resultCheckLogin == 2)
            {
                errorProvider.SetError(this.lookUpUser, "Giảng viên đã có tài khoản rồi !");

            }
            else if (resultCheckLogin == 3)
            {
                XtraMessageBox.Show("Lỗi thực thi trong cơ sơ dữ liệu !", "", MessageBoxButtons.OK);
            }
            else if (resultCheckLogin == 0)
            {
                XtraMessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);

            }
            return;
        }

        // true: ko empty, false : empty
        private Boolean isEmptyorNullTextBox()
        {
            Boolean check = true;


            //check từng textbox

            if (string.IsNullOrEmpty(this.txtLogin.Text))
            {
                errorProvider.SetError(this.txtLogin, "Trường dữ liệu không được để trống !");
                check = false;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                errorProvider.SetError(this.txtPassword, "Trường dữ liệu không được để trống !");
                check = false;
            }

            if (string.IsNullOrEmpty(this.txtConfirm.Text))
            {
                errorProvider.SetError(this.txtConfirm, "Trường dữ liệu không được để trống !");
                check = false;
            }
            if(string.IsNullOrEmpty(this.lookUpUser.Text))
            {
                errorProvider.SetError(this.lookUpUser, "Trường dữ liệu không được để trống !");
                check = false;
            }
            return check;
        }


        // true: ko empty, false : empty
        private Boolean isEmptyorNullRadioButtons()
        {
            //check từng radiobutton

            if (this.rbtnKhoa.Checked || this.rbtnPGV.Checked || this.rbtnPKT.Checked)
            {
                return true;
            }

            errorProvider.SetError(this.pnRole, "Bạn chưa chọn nhóm quyền !");

            return false;

        }


        private bool ValidateInfo()
        {
            bool isValid = true;

            // xóa hết thông báo ở errorProvider
            errorProvider.Clear();


            // check khoảng trống ở textbox
            if (!isEmptyorNullTextBox())
            {
                isValid = false;
            }


            // check khớp mật khẩu
            if (txtConfirm.Text != txtPassword.Text)
            {
                this.errorProvider.SetError(txtConfirm, "Mật khẩu không khớp");
                isValid = false;
            }

            // check khoảng trống ở radiobutton
            if (!isEmptyorNullRadioButtons())
            {
                isValid = false;
            }

            // login không được chứa khoảng trống
            if (txtLogin.Text.Contains(" "))
            {
                this.errorProvider.SetError(txtLogin, "Tên login không được chứa khoảng trăng !");
                isValid = false;
            }


            return isValid;
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = (chkShowPass.Checked) ? false : true;
            txtConfirm.UseSystemPasswordChar = (chkShowPass.Checked) ? false : true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn thật sự muốn hủy thao tác đăng ký tài khoản?",
                      "Xác thực", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                this.Close();

            }
        }
    }

}