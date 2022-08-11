using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
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
    public partial class frmDongHocPhi : DevExpress.XtraEditors.XtraForm
    {
        private int _position;
        private int _positionHP = 0;
        private string _flagOption = "";
        private string NIENKHOA = "";
        private int HOCKY = 1;
        private string MASV = "";
        private int SOTIENCANDONG = 0; // dùng để so sánh khi nhập đóng học phó
        public frmDongHocPhi()
        {
            InitializeComponent();
        }

       
        private void loadInitializeData(string masv)
        {
            this.dS3.EnforceConstraints = false;
            this.tableAdapterHP.Connection.ConnectionString = Program.connstr;
            this.tableAdapterHP.FillBy(this.dS3.HOCPHI, masv);

            this.tableAdapterCTHP.Connection.ConnectionString = Program.connstr;
            this.tableAdapterCTHP.Fill(this.dS3.CT_DONGHOCPHI);

            this.tableAdapterCTHP.Connection.ConnectionString = Program.connstr;
            this.tableAdapterCTHP.Fill(this.dS3.CT_DONGHOCPHI);

            barBtnThem.Enabled = barBtnThoat.Enabled = barBtnReload.Enabled = true;
            barBtnGhi.Enabled = barBtnHuy.Enabled = false;
            HPGridControl.Enabled = true;
            this.bdsHP.Position = _positionHP;
        }

        private void frmDongHocPhi_Load(object sender, EventArgs e)
        {
            this.tableAdapterSV.Connection.ConnectionString = Program.connstr;
            this.tableAdapterSV.Fill(this.dS3.SINHVIEN);
            barBtnThem.Enabled = barBtnReload.Enabled 
            = barBtnGhi.Enabled = barBtnHuy.Enabled =  false;
        }

       

        private void hOCPHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS3);

        }

       

        private void cmbMASV_EditValueChanged(object sender, EventArgs e)
        {
            var selectedSV = cmbMASV.GetSelectedDataRow() as DataRowView;

            txtHoTen.Text = selectedSV.Row["HO"] + " " + selectedSV.Row["TEN"];
            txtMaLop.Text = selectedSV.Row["MALOP"].ToString();

            _position = this.bdsSV.Find("MASV", selectedSV.Row["MASV"].ToString());
            this.btnThem.Enabled = true;
           
            MASV = selectedSV.Row["MASV"].ToString();
            loadInitializeData(MASV);
            this.bdsSV.Position = _position;
        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _flagOption = "ADD_HP";
            bdsHP.AddNew();
            barBtnThem.Enabled  = barBtnReload.Enabled = false;
        }

        private void barBtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Ghi Vào CSDL","Thông Báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_flagOption.Equals("ADD_HP"))
                {
                    if (checkValidateHP())
                    {
                        try
                        {
                            this.bdsHP.EndEdit();
                            if (!this.Validate()) return;
                            int check = this.tableAdapterHP.Update(this.dS3.HOCPHI);
                            if (check > 0)
                            {
                                XtraMessageBox.Show("Ghi Thành Công");
                                loadInitializeData(MASV);
                            }

                        }
                        catch(SqlException ex)
                        {
                            // nếu thêm vào mà đã tồn tại niên khoá và học kì đó trong csdl thì thông báo
                            // mã lối là 2627
                            if(ex.Number == 2627)
                            {
                               if(XtraMessageBox.Show($"NIENKHOA: {NIENKHOA} VÀ HOCKY: {HOCKY} Đã Tồn Tại Học Phí Trong CSDL\nBạn Có Muốn Hiểu Chỉnh Không", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    this.loadInitializeData(MASV);
                                    int length = this.dS3.HOCPHI.Count;
                                    int index = 0;
                                    for (int i = 0; i < length; i++)
                                        if (this.dS3.HOCPHI.Rows[i].Field<string>("MASV").Equals(MASV) &&
                                                this.dS3.HOCPHI.Rows[i].Field<string>("NIENKHOA").Equals(NIENKHOA) &&
                                                 this.dS3.HOCPHI.Rows[i].Field<int>("HOCKY").Equals(HOCKY))
                                        {
                                            index = i;
                                            break;
                                        }
                                    
                                    this.bdsHP.Position = index;
                                } else
                                {
                                    XtraMessageBox.Show("Ghi Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show($"Lỗi Ghi Vào CSDL {ex.Message}");
                        }
                    }
                }
                if (_flagOption.Equals("ADD_CTHP"))
                {
                    if (checkValidateCTHP())
                    {
                        try
                        {
                            this.bdsCTHP.EndEdit();
                            if (!this.Validate()) return;
                            int check = this.tableAdapterCTHP.Update(this.dS3.CT_DONGHOCPHI);
                            if (check > 0)
                            {
                                XtraMessageBox.Show("Ghi Thành Công");
                                loadInitializeData(MASV);
                            }

                        }
                         catch (Exception ex)
                        {
                            XtraMessageBox.Show($"Lỗi Ghi Vào CSDL {ex.Message}");
                        }
                    }
                }
                


            }
            
        }

        private Boolean checkValidateHP()
        {
            DataRowView dataRowView = (DataRowView)this.bdsHP.Current;
            if (dataRowView.Row.Field<object>("NIENKHOA") == null)
            {
                XtraMessageBox.Show("Niên Khoá Không Được Để Trống");
                return false;
            }
            if (dataRowView.Row.Field<object>("HOCPHI") == null)
            {
                XtraMessageBox.Show("Học Phí Lớn Hơn 0");
                return false;
            }
            return true;
        }

        private Boolean checkValidateCTHP()
        {
            DataRowView dataRowView = (DataRowView)this.bdsCTHP.Current;
            if (dataRowView.Row.Field<object>("NGAYDONG") == null)
            {
                XtraMessageBox.Show("Vui Lòng Chọn NGAYDONG");
                return false;
            }
            if (dataRowView.Row.Field<object>("SOTIENDONG") == null)
            {
                XtraMessageBox.Show("Số Tiền Đóng Lớn Hơn 0");
                return false;
            }
            return true;
          
        }

        private void barBtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsHP.CancelEdit();
            bdsCTHP.CancelEdit();
            // load lại cả form...
            this.loadInitializeData(MASV);
        }

        private void barBtnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.loadInitializeData(MASV);
            XtraMessageBox.Show("Làm mới thành công");
        }

        private void barBtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Xác nhận thoát","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
            this.Close();
        }

        private void viewHP_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            // auto set MASV
            viewHP.SetRowCellValue(e.RowHandle, viewHP.Columns["MASV"], MASV);
            viewHP.SetRowCellValue(e.RowHandle, viewHP.Columns["HOCKY"], 1);
            viewHP.SetRowCellValue(e.RowHandle, viewHP.Columns["SOTIENDADONG"], 0);
            viewHP.SetRowCellValue(e.RowHandle, viewHP.Columns["SOTIENCANDONG"], 0);
        }
        private void btnDongHocPhi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRowView dataRowView = (DataRowView) this.bdsHP.Current;
            if(dataRowView.IsNew)
            {
                _positionHP = this.bdsHP.Position;
                XtraMessageBox.Show("Vui lòng ghi trước khi đóng học phí");
                return;
            }
            bool check = true;
            if(dataRowView.Row.Field<object>("SOTIENCANDONG") != null)
            {
                if(dataRowView.Row.Field<int>("SOTIENCANDONG") == 0)
                {
                    check = XtraMessageBox.Show("Đã Đóng Đủ Học Phí. Bạn Muốn Đóng Tiếp", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes ?
                             true : false;

                }else
                {
                    SOTIENCANDONG = dataRowView.Row.Field<int>("SOTIENCANDONG");
                }
            }  

            if(check)
            {
                if (dataRowView.Row.Field<object>("NIENKHOA") != null && dataRowView.Row.Field<object>("HOCKY") != null)
                {

                    NIENKHOA = dataRowView.Row.Field<string>("NIENKHOA");
                    HOCKY = dataRowView.Row.Field<int>("HOCKY");
                    _flagOption = "ADD_CTHP";
                    this.bdsCTHP.AddNew();
                    // thao tác trước khi thêm
                    DataRowView drv = (DataRowView)this.bdsCTHP.Current;
                    drv.Row.SetField<DateTime>("NGAYDONG", DateTime.Now);

                    barBtnThem.Enabled = barBtnReload.Enabled = false;
                    _positionHP = this.bdsHP.Position;
                    barBtnHuy.Enabled = true;
                    HPGridControl.Enabled = false;
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng nhập NIENKHOA và HOCKY trước khi đóng học phí");
                }
            }
        }

      
        private void viewHP_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            _flagOption = "ADD_HP";
            if (e.Column.FieldName.Equals("NIENKHOA")) NIENKHOA = e.Value.ToString();
            else if (e.Column.FieldName.Equals("HOCKY")) HOCKY = Convert.ToInt32(e.Value.ToString());
            else if(e.Column.FieldName.Equals("HOCPHI"))
            // set dữ liệu vào cột SOTIENCANDONG = HOCPHI
            {
                int sotiencandong = int.Parse(e.Value.ToString()) - int.Parse(this.viewHP.GetRowCellValue(e.RowHandle, "SOTIENDADONG").ToString());
                this.viewHP.SetRowCellValue(e.RowHandle, "SOTIENCANDONG", sotiencandong);
            }  
            barBtnGhi.Enabled = barBtnHuy.Enabled = true;
            _positionHP = this.bdsHP.Position;
        }

        private void viewCTHP_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(SOTIENCANDONG == 0)
            {
                DataRowView drv = (DataRowView)bdsHP.Current;
                SOTIENCANDONG = drv.Row.Field<int>("SOTIENCANDONG");
            }


            if(e.Column.FieldName == "SOTIENDONG")
            {
                if(Convert.ToInt32(e.Value.ToString()) > SOTIENCANDONG)
                {
                    if(XtraMessageBox.Show("Đóng quá số tiền cần đóng thêm.\nBạn có muốn tiếp tục không?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        // set lại giá trị cần đóng
                        if (_flagOption.Equals("ADD_CTHP"))
                        {
                            DataRowView dataRow = (DataRowView)this.bdsCTHP.Current;
                            dataRow.Row.SetField<int>("SOTIENDONG", SOTIENCANDONG);
                        }else
                        {
                            bdsCTHP.CancelEdit();
                        }
                           
                    }
                }
            }
            _flagOption = "ADD_CTHP";
            barBtnGhi.Enabled = barBtnHuy.Enabled = true;
            barBtnThem.Enabled = false;
            _positionHP = this.bdsHP.Position;
        }

        private void rTxtHocPhi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void rTxtNienKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('-')) return;
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTHP.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa vì đã đóng học phí.", "", MessageBoxButtons.OK);
                return;
            }
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsHP.RemoveCurrent();
                    this.tableAdapterHP.Connection.ConnectionString = Program.connstr;
                    int check = this.tableAdapterHP.Update(this.dS3.HOCPHI);
                    if (check > 0) XtraMessageBox.Show("Xoá Thành Công");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa học phí.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterHP.Fill(this.dS3.HOCPHI);
                    return;

                }
            }
            if (bdsHP.Count == 0) btnXoa.Enabled = btnHieuChinh.Enabled = btnHuy.Enabled = false;
            btnReload.Enabled = true;
            if (_position > 0)
            {
                bdsHP.Position = _position;
            }
        }
    }
}