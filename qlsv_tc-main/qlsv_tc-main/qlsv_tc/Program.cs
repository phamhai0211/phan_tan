using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace qlsv_tc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        public static string servername = "DESKTOP-ATC1VAQ";
        public static string username = "";
        public static string password;
        public static string database = "QLSVTC";
        public static string mlogin;
        public static string mGroup;
        public static string mHoten = "";
        public static int mKhoa;
        public static string mloginDN = "";
        public static string mPasswordDN = "";
        public static string rootConnstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";Integrated Security=true";
        public static string connstr = rootConnstr;

        public static string remoteLogin = "HTKN";
        public static string remotePassword = "123456";
        public static int mPhongBan = 0;//khoa cntt hay vt
        public static BindingSource bds_dspm = new BindingSource();
        public static frmMain frmMain;

        public enum role
        {
            PGV,
            KHOA,
            SV,
            PKT
        }


        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open) Program.conn.Close();
            try
            {
                Program.connstr = Program.connstr = "Data Source=" + Program.servername + ";MultipleActiveResultSets=true;Initial Catalog=" + Program.database + ";User ID=" +
                      mlogin + ";password=" + password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            // đối tượng chỉ cho đọc dữ liệu
            SqlDataReader myreader;

            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.Connection = Program.conn;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = System.Data.CommandType.Text;

            /* ghi nhớ thi vấn đáp: 
               Nếu muốn thực thi một SP, Function hoặc gọi view trong CDSL
               Ta tạo 1 đối tượng SqlCommand và nhúng hoặc qua phương thức khởi tạo gồm 2 tham số (chuỗi lệnh,đối tượng SqlConnection);
               Gán đối tượng SqlCommand là kiểu câu lệnh (CommandType = ? (SP,TEXT ....))

            */


            if (Program.conn.State == System.Data.ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static System.Data.DataTable ExecSqlQuery(String query)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            conn.Close();
            return dt;

            /*
              Có thể sử dụng SqlCommand gồm 2 tham số như ở trên và load dữ liệu vào dataTable bằng phương thước loadData
              cách này thường sử dụng khi dữ liệu đã được tải từ trc và dưới dạng là SqlDataReader và mình muốn chuyển về DataTable
             */
        }


        public static int ExecSqlNonQuery(String cmd, String connectionstring)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.Connection = conn;
            Sqlcmd.CommandText = cmd;
            Sqlcmd.CommandType = System.Data.CommandType.Text;


            // thực thi câu lệnh tối đa 5 phút. Nếu 5 phút chưa xong thì thất bại
            Sqlcmd.CommandTimeout = 300; // 5 phút
            //  Những câu lệnh thực thi không truy vấn có thể làm hàng loạt bên csdl có khả năng thì quá 1 phút

            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            try
            {

                Sqlcmd.ExecuteNonQuery(); conn.Close(); return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 0;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMain = new frmMain();
            frmMain.WindowState = FormWindowState.Maximized;
            Application.Run(frmMain);
        }
    }
}
