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
    public partial class frmDIEM : DevExpress.XtraEditors.XtraForm
    {
        public frmDIEM()
        {
            InitializeComponent();
        }

        private void frmDIEM_Load(object sender, EventArgs e)
        {
            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Ultils.BindingDataToComBo(cboxKhoa, Program.bds_dspm.DataSource);
            loadInitializeData();
            // TODO : Role Action
            if (Program.mGroup == Program.role.PGV.ToString())// PGV
            {
                cboxKhoa.Visible = true;
                cboxKhoa.Enabled = true;

                btnGhi.Enabled = true;
            }
            else if (Program.mGroup == Program.role.KHOA.ToString()) // KHOA
            {
                cboxKhoa.Visible = false;
                btnGhi.Enabled = true;

                cboxKhoa.Visible = true;
                cboxKhoa.Enabled = false;
            }
            btnGhi.Enabled = false;
        }
        private void loadInitializeData()
        {
            dS1.EnforceConstraints = false;
            this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
            this.tableAdapterMonHoc.Fill(this.dS1.MONHOC);
            DiemGridControl.Enabled = false;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            string nienkhoa = txtNienKhoa.Text.Trim();
            int hocky = (int)spinEditHocKi.Value;
            int nhom = (int)spinEditNhom.Value;
            string mamh = lookUpMonHoc.Text.Equals("") ? "" : lookUpMonHoc.GetColumnValue("MAMH").ToString();

            if (nienkhoa.Equals(""))
            {
                XtraMessageBox.Show("Niên khóa không được để trống");
                return;
            }
            if(hocky < 1 || hocky > 3)
            {
                XtraMessageBox.Show("Học kỳ phải lớn hơn 1 và nhỏ hơn 3");
                return;
            }
            if(nhom < 1)
            {
                XtraMessageBox.Show("Nhóm phải lớn hơn 0");
                return;
            }
            if (mamh.Equals(""))
            {
                XtraMessageBox.Show("Mã môn học không được để trống");
                return;
            }
            // fill data
            this.tableAdapterDIEMSV.Connection.ConnectionString = Program.connstr;
            this.tableAdapterDIEMSV.Fill(this.dS1.GetDanhSachDiemSV, nienkhoa, hocky, mamh, nhom);
            DiemGridControl.Enabled = true;
            btnGhi.Enabled = false;
        }

        private void cboxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cboxKhoa.SelectedValue.ToString();
            if (cboxKhoa.SelectedIndex != Program.mPhongBan)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.mPasswordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                //loadcbNienkhoa();

            }
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

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            btnGhi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(Program.connstr);
                try
                {
                    if (!this.Validate()) return;
                    this.bdsDIEMSV.EndEdit();
                    this.bdsDIEMSV.ResetCurrentItem();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("MALTC", typeof(int));
                    dt.Columns.Add("MASV", typeof(string));
                    dt.Columns.Add("DIEM_CC", typeof(int));
                    dt.Columns.Add("DIEM_GK", typeof(float));
                    dt.Columns.Add("DIEM_CK", typeof(float));
                    dt.Columns.Add("HUYDANGKY", typeof(bool));

                    conn.Open();
                    for (int i=0; i < dS1.GetDanhSachDiemSV.Rows.Count; i++)
                    {
                        dt.Rows.Add(dS1.GetDanhSachDiemSV.Rows[i]["MALTC"], 
                            dS1.GetDanhSachDiemSV.Rows[i]["MASV"], 
                            dS1.GetDanhSachDiemSV.Rows[i]["DIEM_CC"], 
                            dS1.GetDanhSachDiemSV.Rows[i]["DIEM_GK"], 
                            dS1.GetDanhSachDiemSV.Rows[i]["DIEM_CK"], false);
                    }
                    SqlParameter param = new SqlParameter();
                    param.SqlDbType = SqlDbType.Structured;
                    param.TypeName = "dbo.DANGKYType";
                    param.Value = dt;
                    param.ParameterName = "DIEMTHI";

                    SqlCommand sqlCommand = new SqlCommand("SP_Update_Diem",conn);
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(param);
                    sqlCommand.ExecuteNonQuery();
                    XtraMessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGhi.Enabled = false;
                    btnBatDau.PerformClick();
                }
                catch (Exception ex)
                {
                    bdsDIEMSV.RemoveCurrent();
                    XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnGhi.Enabled)
            {
                if (XtraMessageBox.Show("Thoát mà không lưu", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    this.Close();
            }else
            {
                this.Close();
            }
            
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnGhi.Enabled)
            {
                if (XtraMessageBox.Show("Bạn chưa lưu. Bạn có muốn lưu trước khi làm mới không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    btnGhi.PerformClick();
                }
                btnBatDau.PerformClick();
            }else
            {
                btnBatDau.PerformClick();
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView drv = (DataRowView)bdsDIEMSV.Current;
            object[] obj = drv.Row.ItemArray;
            if (!obj[2].ToString().Equals(""))
            {
                if(((int)obj[2] < 0 || (int)obj[2] > 10))
                {
                    e.ErrorText = "DIEM_CC phải >= 0 && <= 10";
                    e.Valid = false;
                    bdsDIEMSV.Position = e.RowHandle;
                    return;
                }
            }
            else
            {
                drv.Row.SetField<int>("DIEM_CC", 0);
            }

            if (!obj[3].ToString().Equals(""))
            {
                if(((double)obj[3] < 0 || (double)obj[3] > 10))
                {
                    e.ErrorText = "DIEM_GK phải >= 0 && <= 10";
                    e.Valid = false;
                    bdsDIEMSV.Position = e.RowHandle;
                    return;
                }
            }
            else
            {
                drv.Row.SetField<double>("DIEM_GK", 0.0);
            }


            if (!obj[4].ToString().Equals(""))
            {
                if(((double)obj[4] < 0.0 || (double)obj[4] > 10.0))
                {
                    e.ErrorText = "DIEM_CK phải >= 0 && <= 10";
                    e.Valid = false;
                    bdsDIEMSV.Position = e.RowHandle;
                    return;
                }
            }
            else
            {
                drv.Row.SetField<double>("DIEM_CK", 0.0);
            }
        }

        private void txtNienKhoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}