using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frmReportBangDiemMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmReportBangDiemMonHoc()
        {
            InitializeComponent();
        }

        private void frmReportBangDiemMonHoc_Load(object sender, EventArgs e)
        {
            this.dS1.EnforceConstraints = false;
            Program.bds_dspm.Filter = "TENKHOA LIKE 'Khoa%'";
            Ultils.BindingDataToComBo(cmbKhoa, Program.bds_dspm.DataSource);

            loadInitializeData();
            if (Program.mGroup.Equals(Program.role.KHOA.ToString()))
            {
                this.cmbKhoa.Enabled = false;
            }
        }

        private void btnInLTC_Click(object sender, EventArgs e)
        {
            if (txtNienKhoa.Text.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng nhập niên khóa");
                return;
            }
            if (cmbKhoa.Text.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn Khoa");
                return;
            }
            if (lookUpEditMH.Text.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn môn học");
                return;
            }
            // nien khoa hoc ky mamh nhom
            Xrpt_BangDiemMonHoc xrpt = new Xrpt_BangDiemMonHoc(txtNienKhoa.Text, int.Parse(txtHocKy.Text), lookUpEditMH.GetColumnValue("MAMH").ToString(), int.Parse(txtNhom.Text));
            xrpt.lbKhoa.Text = cmbKhoa.Text.ToUpper();
            xrpt.lbNienKhoaHocKy.Text = $"NIÊN KHÓA: {txtNienKhoa.Text}  HỌC KỲ: {txtHocKy.Text}";
            xrpt.lbMonHocNhom.Text = $"MÔN HỌC: {lookUpEditMH.GetColumnValue("TENMH").ToString().ToUpper()}  NHÓM: {txtNhom.Text}";
            ReportPrintTool print = new ReportPrintTool(xrpt);
            print.ShowPreviewDialog();
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

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ultils.ComboboxHelper(this.cmbKhoa);

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
            this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
            this.tableAdapterMonHoc.Fill(this.dS1.MONHOC);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}