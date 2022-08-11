using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace qlsv_tc
{
    public partial class Xrpt_BangDiemMonHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangDiemMonHoc()
        {
            InitializeComponent();
        }
        public Xrpt_BangDiemMonHoc(string nienkhoa,int hocky,string mamh,int nhom)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = mamh;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = nhom;
            this.sqlDataSource1.Fill();
        }

    }
}
