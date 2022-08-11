using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace qlsv_tc
{
    public partial class Xrpt_BangDiemTongKEt : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangDiemTongKEt()
        {
            InitializeComponent();
        }
        public Xrpt_BangDiemTongKEt(string malop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Fill();
        }
    }
}
