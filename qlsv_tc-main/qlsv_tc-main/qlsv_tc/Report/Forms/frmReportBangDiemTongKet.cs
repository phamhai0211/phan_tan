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

namespace qlsv_tc.Report.Forms
{
    public partial class frmReportBangDiemTongKet : DevExpress.XtraEditors.XtraForm
    {
        public frmReportBangDiemTongKet()
        {
            InitializeComponent();
        }

        private void frmReportBangDiemTongKet_Load(object sender, EventArgs e)
        {
            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Ultils.BindingDataToComBo(cboxKhoa, Program.bds_dspm.DataSource);

            loadInitializeData();
            if (Program.mGroup.Equals(Program.role.KHOA.ToString()))
            {
                this.cboxKhoa.Enabled = false;
            }

            

        }

        private void loadInitializeData()
        {
            this.dS1.EnforceConstraints = false;
            this.tableAdapterLop.Connection.ConnectionString = Program.connstr;
            this.tableAdapterLop.Fill(this.dS1.LOP);
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

        private void btnInLTC_Click(object sender, EventArgs e)
        {
            if (lookupEditMalop.Text.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn mã lớp");
                return;
            }
            Xrpt_BangDiemTongKEt xrpt = new Xrpt_BangDiemTongKEt(lookupEditMalop.GetColumnValue("MALOP").ToString());
            xrpt.lbMaLopKhoaHoc.Text = $"LỚP: {lookupEditMalop.GetColumnValue("MALOP").ToString().ToUpper()} - KHÓA HỌC: {lookupEditMalop.GetColumnValue("KHOAHOC").ToString()}";
            xrpt.lbKhoa.Text = $"KHOA: {cboxKhoa.Text.ToUpper()}";
            ReportPrintTool print = new ReportPrintTool(xrpt);
            print.ShowPreviewDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}