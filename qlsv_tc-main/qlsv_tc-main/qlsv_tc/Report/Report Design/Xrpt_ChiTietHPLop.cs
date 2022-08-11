using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace qlsv_tc
{
    public partial class Xrpt_ChiTietHPLop : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_ChiTietHPLop()
        {
            InitializeComponent();
        }

        public Xrpt_ChiTietHPLop(string nienkhoa,int hocky,string malop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = malop;
            this.sqlDataSource1.Fill();
        }

    }
}
