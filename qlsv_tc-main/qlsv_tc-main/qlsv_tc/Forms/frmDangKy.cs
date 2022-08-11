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
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        private static string MASV = "";
       public frmDangKy()
        {
            InitializeComponent();
        }

        private void initDataDsLTC(string nienkhoa, int hocki)
        {
            if (Program.KetNoi() != 1)
            {
                MessageBox.Show("Kết nối tới csdl thất bại");
                return;
            }

            // fill vào bảng đăng kí để đối chiếu so sánh cập nhật vào database. *Bảng này ko hiện thị trên client ẩn đi để xử lí
            this.tableAdapterDK.Connection.ConnectionString = Program.connstr;
            this.tableAdapterDK.FillBy(this.dS.DANGKY, MASV, nienkhoa, hocki);

            this.tableAdapterDKLTC.Connection.ConnectionString = Program.connstr;
            this.tableAdapterDKLTC.Fill(this.dS.DanhSachDkyLTC, nienkhoa, hocki);

            this.tableAdapterDKLTCSV.Connection.ConnectionString = Program.connstr;
            this.tableAdapterDKLTCSV.Fill(this.dS.DanhSachDkyLTCSV, MASV, nienkhoa, hocki);
        }

        private void initData()
        {
            this.tableAdapterSV.Connection.ConnectionString = Program.connstr;
            this.tableAdapterSV.Fill(this.dS.SINHVIEN);
            pnContent.Visible = false;
            pnNienKhoaHocKi.Visible = false;
        }
        private void DkyLTC_Load(object sender, EventArgs e)
        {
            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Ultils.BindingDataToComBo(cboxKhoa, Program.bds_dspm.DataSource);

            initData();
            if (Program.mGroup.Equals(Program.role.SV.ToString()))
            {
                cmbMASV.Enabled = false;
                cmbMASV.EditValue = Program.username.ToUpper();
                cboxKhoa.Enabled = false;
            }
            else if (Program.mGroup.Equals(Program.role.KHOA.ToString()))
            {
                cboxKhoa.Enabled = false;
            } else
            {
                cboxKhoa.Enabled = true;
                cmbMASV.Enabled = true;
            }
        }

        private void btnTimLTC_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() != 1)
            {
                MessageBox.Show("Kết nối tới csdl thất bại");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNienKhoa.Text))
            {
                MessageBox.Show("Niên Khoá Không Được Để Trống");
                return;
            }
            else if (Convert.ToInt32(spHocKi.Text) < 1 || Convert.ToInt32(spHocKi.Text) > 3)
            {
                MessageBox.Show("Học Kỳ Trong Khoảng 1 - 3");
                return;
            }
            this.initDataDsLTC(txtNienKhoa.Text.Trim(), Convert.ToInt32(spHocKi.Text));
            pnContent.Visible = true;

        }

        private void rbtnDangKy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            object[] rows = gridView1.GetFocusedDataRow().ItemArray; // MALTC MAMH TENMH NHOM GV SoLuongDK SOSVTOITHIEU
            int MALTC = Convert.ToInt32(rows[0].ToString());
            string MAMH = rows[1].ToString();
            int NHOM = Convert.ToInt32(rows[3]);

            // kiểm tra còn được đăng kí không
            string query = "DECLARE	@return_value INT " +
                $"EXEC @return_value = [dbo].[SP_KiemTraDANGKY] @maltc = {MALTC}" +
                "SELECT 'Return Value' = @return_value";
            if (Program.KetNoi() == -1)
            {
                XtraMessageBox.Show("Kết Nối CSDL Thất Bại. Vui lòng thử lại");
                return;
            }

            SqlDataReader dataReader = Program.ExecSqlDataReader(query);
            dataReader.Read();
            int returnVal = dataReader.GetInt32(0);

            // returnVal = 1 có thể đăng ký
            // returnVal = 0 Đã đủ số lượng
            if (returnVal == 0)
            {
                XtraMessageBox.Show("Môn Học Đã Đầy Vui Lòng Chọn Môn Khác");
                return;
            }

            int indexBdsDK = bdsDK.Find("MALTC", MALTC);
            // tìm thấy trong bdsDK
            if (indexBdsDK > -1)
            {
                // Nếu trạng thái tắt thì bật
                bool isHuyDangKy = this.dS.DANGKY.Rows[indexBdsDK].Field<Boolean>("HUYDANGKY");
                if (isHuyDangKy)
                {
                    this.dS.DANGKY.Rows[indexBdsDK].SetField<Boolean>("HUYDANGKY", false);
                    this.dS.DANGKY.AcceptChanges();
                    addNewRowBdsDSDKSV(rows);
                }

            }
            // chưa có trong bdsDK
            else
            {
                // thêm vào gridControl DS đã đăng ký hiển thị lên client
                if (addNewRowBdsDSDKSV(rows)) // nếu thêm thành công thì mới thêm vào bdsDK
                    newRowBdsDK(MALTC, MASV);
            }



        }

        private void newRowBdsDK(int MALTC, string MASV)
        {
            object[] newRow = new object[6]; // MALTC MASV DIEM_CC DIEM_GK DIEM_CK HUYDANGKY
            newRow[0] = MALTC;
            newRow[1] = MASV;
            newRow[2] = 0; // thêm dòng mới thì DIEM_CC = 0
            newRow[3] = 0; // DIEM_GK = 0
            newRow[4] = 0; // DIEM_CK = 0
            newRow[5] = 0; // HUYDK
            this.dS.DANGKY.Rows.Add(newRow);
            this.dS.DANGKY.AcceptChanges();
        }

        private Boolean addNewRowBdsDSDKSV(object[] rows)
        {
            // MALTC MAMH TENMH NHOM GV SoLuongDK SOSVTOITHIEU

            int MALTC = Convert.ToInt32(rows[0].ToString());
            string MAMH = rows[1].ToString();
            string TENMH = rows[2].ToString();
            int NHOM = Convert.ToInt32(rows[3]);
            string GV = rows[4].ToString();

            // kiểm tra xem có môn nào cùng nhóm không. Nếu có thì loại bỏ nhóm cũ
            try
            {
                for (int i = 0; i < this.dS.DanhSachDkyLTCSV.Rows.Count; i++)
                {
                    if (this.dS.DanhSachDkyLTCSV.Rows[i].Field<string>("MAMH") == MAMH)
                    {
                        if (this.dS.DanhSachDkyLTCSV.Rows[i].Field<int>("NHOM") != NHOM)
                        {
                            int index = bdsDK.Find("MALTC", this.dS.DanhSachDkyLTCSV.Rows[i].Field<int>("MALTC"));
                            if (index != -1)
                            {
                                // kiểm tra đã có điểm chưa. nếu có không cho đăng kí nhóm khác
                                int diem_cc = this.dS.DANGKY.Rows[index].Field<int>("DIEM_CC");
                                float diem_gk = float.Parse(this.dS.DANGKY.Rows[index].Field<object>("DIEM_GK").ToString());
                                float diem_ck = float.Parse(this.dS.DANGKY.Rows[index].Field<object>("DIEM_CK").ToString());

                                // nếu đã nhập điểm thì không cho huỷ đăng kí hoặc đăng kí cùng môn khác nhóm
                                if (diem_cc > 0 || diem_gk > 0.0 || diem_ck > 0.0)
                                {
                                    MessageBox.Show($"Môn học {TENMH} đã có điểm.\nKhông được đăng kí nhóm khác");
                                    return false;
                                }


                                // huỷ DK ở nhóm cũ bằng cách bật huỷ dk bằng true 
                                this.dS.DANGKY.Rows[index].SetField<bool>("HUYDANGKY", true);
                                this.dS.DANGKY.AcceptChanges();
                            }
                            // remove môn học ở nhóm cũ ở bảng DSDKLTCSV
                            this.dS.DanhSachDkyLTCSV.Rows.RemoveAt(i);
                            this.dS.DanhSachDkyLTCSV.AcceptChanges();
                        }
                    }
                }
            }
            catch (System.Data.DeletedRowInaccessibleException) // tránh trường hợp đã xoá mà vẫn tìm lại
            {
                // true logic 
            }

            this.dS.DanhSachDkyLTCSV.Rows.Add(MALTC, MAMH, TENMH, NHOM, GV);
            this.dS.DanhSachDkyLTCSV.AcceptChanges();
            return true;
        }

        private void rbtnHuyDangKy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // kiểm tra môn học đã có điểm chưa
            int maltc = gridView2.GetFocusedDataRow().Field<int>("MALTC");
            string TENMH = gridView2.GetFocusedDataRow().Field<string>("TENMH");
            int index = bdsDK.Find("MALTC", maltc);
            if (index != -1)
            {
                int diem_cc = this.dS.DANGKY.Rows[index].Field<int>("DIEM_CC");
                float diem_gk = float.Parse(this.dS.DANGKY.Rows[index].Field<object>("DIEM_GK").ToString());
                float diem_ck = float.Parse(this.dS.DANGKY.Rows[index].Field<object>("DIEM_CK").ToString());

                // nếu đã nhập điểm thì không cho huỷ đăng kí hoặc đăng kí cùng môn khác nhóm
                if (diem_cc > 0 || diem_gk > 0.0 || diem_ck > 0.0)
                {
                    MessageBox.Show($"Môn học {TENMH} :MALTC {maltc} đã có điểm.\nKhông được huỷ đăng ký");
                    return;
                }
                else
                {
                    // đánh dấu huỷ dk vào bdkDK
                    this.dS.DANGKY.Rows[index].SetField<Boolean>("HUYDANGKY", true);

                    // cập nhật lại bdsDKLTCSV
                    bdsDKLTCSV.RemoveCurrent();
                    bdsDKLTCSV.ResetCurrentItem(); // reset lại list
                }
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    this.Validate();
                    this.bdsDK.EndEdit();
                    this.bdsDK.ResetCurrentItem();
                    int check = tableAdapterDK.SP_UpdateInsertDANGKY(this.dS.DANGKY);
                    MessageBox.Show("Ghi Thành Công");
                }
                catch (Exception ex)
                {
                    bdsDK.RemoveCurrent();
                    XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbMASV_EditValueChanged(object sender, EventArgs e)
        {
            var selectedSV = cmbMASV.GetSelectedDataRow() as DataRowView;
            MASV = selectedSV.Row["MASV"].ToString();
            txtHoTen.Text = selectedSV.Row["HO"] + " " + selectedSV.Row["TEN"];
            txtMaLop.Text = selectedSV.Row["MALOP"].ToString();
            pnNienKhoaHocKi.Visible = true;
            pnContent.Visible = false;
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
                initData();
            }
        }

        private void txtNienKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
             // chỉ cho phép nhập số và dấu - 
            if (e.KeyChar.Equals('-')) return;
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
    }
}