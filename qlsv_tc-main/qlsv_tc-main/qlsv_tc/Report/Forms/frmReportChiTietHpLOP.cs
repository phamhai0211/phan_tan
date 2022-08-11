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
    public partial class frmReportChiTietHpLOP : DevExpress.XtraEditors.XtraForm
    {
        public frmReportChiTietHpLOP()
        {
            InitializeComponent();
        }

        private void frmReportChiTietHpLOP_Load(object sender, EventArgs e)
        {
            this.dS3.EnforceConstraints = false;
            this.tableAdapterKhoa.Connection.ConnectionString = Program.connstr;
            this.tableAdapterKhoa.Fill(this.dS3.KHOA);

           if(cmbKhoa.SelectedValue != null)
            {
                this.tableAdapterLop.Connection.ConnectionString = Program.connstr;
                this.tableAdapterLop.FillByMaKhoa(this.dS3.LOP, cmbKhoa.SelectedValue.ToString());
            }
        }

        private void btnInLTC_Click(object sender, EventArgs e)
        {
            if (cmbMaLop.Text.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn Mã Lớp");
                return;
            }
            if (txtNienKhoa.Text.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng nhập niên khóa");
                return;
            }
            
           
            Xrpt_ChiTietHPLop xrpt = new Xrpt_ChiTietHPLop(txtNienKhoa.Text, int.Parse(txtHocKy.Text), cmbMaLop.GetColumnValue("MALOP").ToString());
            xrpt.lbKhoa.Text = $"KHOA: {cmbKhoa.Text.ToUpper()}";
            xrpt.lbMaLop.Text = $"MÃ LỚP: {cmbMaLop.GetColumnValue("MALOP").ToString()}";
            ReportPrintTool print = new ReportPrintTool(xrpt);
            print.ShowPreviewDialog();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // tránh trường hợp khi cmbKhoa null mà vẫn lấy giá trị
            if(cmbKhoa.SelectedValue != null)
            {
                this.tableAdapterLop.Connection.ConnectionString = Program.connstr;
                this.tableAdapterLop.FillByMaKhoa(this.dS3.LOP, cmbKhoa.SelectedValue.ToString());
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}