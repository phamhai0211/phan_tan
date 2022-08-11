using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace qlsv_tc
{
    public partial class Xrpt_SP_GetDanhSachDkyLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_SP_GetDanhSachDkyLTC()
        {
            InitializeComponent();
        }

        public Xrpt_SP_GetDanhSachDkyLTC(string nienkhoa,int hocky)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Fill();
        }


    }
}
