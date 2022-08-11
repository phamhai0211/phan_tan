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
    public partial class frmLoginSV : DevExpress.XtraEditors.XtraForm
    {
        public static Boolean isLogin = false;
        public static string MASV;
        public frmLoginSV()
        {
            InitializeComponent();
            simpleButton1.DialogResult = DialogResult.OK;
            simpleButton2.DialogResult = DialogResult.Cancel;
        }

        private bool isLoginSV()
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            {
                string sql = "SELECT COUNT(*) AS returnVal FROM dbo.SINHVIEN WHERE MASV = @MASV AND PASSWORD = @PASSWORD";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.Add("@MASV", SqlDbType.NVarChar);
                command.Parameters["@MASV"].Value = txtMASV.Text.Trim();

                command.Parameters.Add("@PASSWORD", SqlDbType.NVarChar);
                command.Parameters["@PASSWORD"].Value = txtPassword.Text.Trim();
                command.Connection.Open();
                try
                {
                    int returnVal = 0;
                    SqlDataReader dataReader = command.ExecuteReader();
                    dataReader.Read();
                    returnVal = dataReader.GetInt32(0);
                    // nhập đúng tài khoản sv
                    if (returnVal > 0) return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return false;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (isLoginSV())
            {
                MASV = txtMASV.Text.Trim().ToUpper();
                isLogin = true;
                this.Close();
            }else
            {
                isLogin = false;
                XtraMessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {       
            this.Close();
        }
    }
}