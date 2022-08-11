using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace qlsv_tc
{
    public partial class Xrpt_PhieuDiemSinhVien : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_PhieuDiemSinhVien()
        {
            InitializeComponent();
        }

        public Xrpt_PhieuDiemSinhVien(string masv)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = masv;
            this.sqlDataSource1.Fill();
        }

    }
}
