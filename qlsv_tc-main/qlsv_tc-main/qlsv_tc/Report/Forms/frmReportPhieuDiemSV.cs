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
    public partial class frmReportPhieuDiemSV : DevExpress.XtraEditors.XtraForm
    {
        public frmReportPhieuDiemSV()
        {
            InitializeComponent();
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
            this.dS1.EnforceConstraints = false;
            this.tableAdapterSV.Connection.ConnectionString = Program.connstr;
            this.tableAdapterSV.Fill(this.dS1.SINHVIEN);
        }
        private void frmReportPhieuDiemSV_Load(object sender, EventArgs e)
        {
            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Ultils.BindingDataToComBo(cmbKhoa, Program.bds_dspm.DataSource);
            this.loadInitializeData();
            if (Program.mGroup.Equals(Program.role.KHOA.ToString()))
            {
                this.cmbKhoa.Enabled = false;
            }
        }

        private void btnInLTC_Click(object sender, EventArgs e)
        {
            if (cmbKhoa.Text.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn Khoa");
                return;
            }
            if (lookUpEditMASV.Text.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn MÃ SV");
                return;
            }

            Xrpt_PhieuDiemSinhVien xrpt = new Xrpt_PhieuDiemSinhVien(lookUpEditMASV.GetColumnValue("MASV").ToString());
            xrpt.lbKHOA.Text = cmbKhoa.Text.ToUpper();
            xrpt.lbMASV.Text = $"MÃ SV: {lookUpEditMASV.GetColumnValue("MASV").ToString().ToUpper()}";
            ReportPrintTool print = new ReportPrintTool(xrpt);
            print.ShowPreviewDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}