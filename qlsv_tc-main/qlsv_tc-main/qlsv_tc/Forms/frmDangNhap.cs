using DevExpress.XtraEditors;
using qlsv_tc.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlsv_tc
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {

        private SqlConnection conn_publisher = new SqlConnection();
        public frmDangNhap()
        {
            InitializeComponent();
        }


        private void LayDSPM(String sql)
        {
            DataTable dataTable = new DataTable();
            // tự động đóng kết nối
            using(conn_publisher)
            {
                conn_publisher.ConnectionString = Program.connstr;
                conn_publisher.Open();
                // thực thi chuỗi sql và trả về DataTable
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn_publisher);// khởi tạo 
                sqlDataAdapter.Fill(dataTable);// lấy dữ liệu đổ vào
                /*
                 các cách lấy dữ liệu từ database
                  1: sử dụng SqlDataAdapter bằng phương thức khởi tạo gồm 2 tham số new SqlDataAdapter(chuỗi truy vấn,đối tượng SqlConnection đang mở)
                     sau đó dùng phương thức Fill(đối tượng DataTable) để lấy dữ liệu từ view hoặc table lưu vào đối tượng DataTable   
                 */

            }
           
            // đưa dữ liệu từ view(lúc này đã lưu vào dataTable) vào đối tượng BindingSource
            Program.bds_dspm.DataSource = dataTable;

            // set dữ liệu vào combo box
            /*
               Lưu ý dùng combobox: 
                1: Dùng method DataSource để chứa danh sách dữ liệu cung cấp cho nó
                2: 2 thuộc tính quan trọng là 
                    DisplayMember: chứa dữ liệu của 1 field trong view trả về. 
                    ValueMember: chứa dữ liệu của field view luôn. Nhưng khi chọn click vào 1 field tương ứng thì nó sẽ trả về dữ liệu cột kế theo nó. Ví dụ click vào khoa CNTT thì ValueMember = tên server tương ứng với khoa cntt
             */
            Ultils.BindingDataToComBo(cboxKhoa, dataTable);
        }

        private int KetNoi_CSDLGOC()
        {
            using(conn_publisher)
            {
                try
                {
                    conn_publisher.ConnectionString = Program.connstr;
                    conn_publisher.Open();
                    return 1;

                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi kết nối database. \n Bạn xem lại tên Server của Publisher, và Tên CSDL trong chuỗi kết nối. \n" + e.Message);
                }
            }
            return 0;
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // nếu kết nối đến database lỗi thì thoát
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("select * from GET_Subscribes");

            cboxKhoa.SelectedIndex = 1;
            cboxKhoa.SelectedIndex = 0;
           

            // auto focus textbox tài khoản
            this.ActiveControl = txtTaiKhoan;
        }
        private void cboxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // lấy giá trị trên combobox gán vào biến toàn cục
                Program.servername = cboxKhoa.SelectedValue.ToString();
                Program.mKhoa = cboxKhoa.SelectedIndex;

            } catch (Exception) { }
        }
      
        private void btnDangNhap_Click(object sender, EventArgs e)
         {

            if(txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống","",MessageBoxButtons.OK);
                return;
            }  

            // lưu thông tin đăng nhập vào 2 biến toàn cục để kết nối database 
            Program.mlogin = txtTaiKhoan.Text;
            Program.password = txtMatKhau.Text;

            // nếu kết nối thất bại thì thoát
            if (Program.KetNoi() == 0) return;


            //để dùng cho các form sau này
            Program.mloginDN = Program.mlogin;
            Program.mPasswordDN = Program.password;


            // đăng nhập với Sinh viên. Mọi sinh viên đều dùng chung 1 tài khoản SinhVien pass 123
            if(Program.mlogin == "SINHVIEN")
            {
                // kiểm tra kết nối tới server
                try
                {
                    using(conn_publisher)
                    {
                        conn_publisher.ConnectionString = Program.connstr;
                        conn_publisher.Open();
                    }

                    frmLoginSV frmSV = new frmLoginSV();
                    if (frmSV.ShowDialog(this) == DialogResult.OK && frmLoginSV.isLogin)
                    {
                        Program.mGroup = Program.role.SV.ToString();
                        Program.mHoten = "";
                        Program.username = frmLoginSV.MASV;
                        Program.frmMain.HienThiMenu();
                        // đóng cửa sổ đăng nhập
                        Close();
                        return;
                    }else return;
                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("Đăng nhập thất bại.\nVui lòng nhập đúng tài khoản được cấp cho Sinh Viên");
                    return;
                }
            }



            // đoạn ở trên dùng để kết nối vào server với tài khoản tương ứng

            String str = "EXEC SP_DANGNHAP  '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(str);
            /* 
              có 3 dạng kết quả trả về khi thực thi 1 câu lệnh lênh csdl
                Trả về dữ liệu chỉ cho đọc ko cho phép hiệu chỉnh. SqlDataReader (chỉ cho đi xuống) ưu điểm: Tải rất nhanh
                Trả về DataTable. Cho phép thêm xoá sửa trên table đi lên xuống thoải mái. Tải chậm hơn datareader
                Thực thi mà không trả về giá trị

             */

            if (Program.myReader == null) return;

            Program.myReader.Read();
            // nếu bảng trả về nhiều dòng thì tạo 1 vòng lặp. Lặp  Program.myReader.Read(); cho đến khi đọc đến dòng cuối cùng (= null)

            
            Program.username = Program.myReader.GetString(0); // lấy username tương ứng với cột thứ 1

            // kiểm tra dữ liệu có phải là null hay không
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn không có quyền truy cập dữ liệu. \n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                Program.mHoten = Program.myReader.GetString(1); // 
                Program.mGroup = Program.myReader.GetString(2);
            }catch(System.Data.SqlTypes.SqlNullValueException)
            {
                MessageBox.Show("Đăng nhập thất bại");
                return;
            }

            Program.myReader.Close();
            Program.conn.Close();

            // đóng cửa sổ đăng nhập
            Close();

            // tắt nút đăng nhập
            btnDangNhap.Enabled = false;

            // hiển thị main
            Program.frmMain.HienThiMenu();


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Program.connstr = Program.rootConnstr;
            Close();
        }

        private void _KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(this.txtTaiKhoan.Text))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản");
                    this.ActiveControl = this.txtTaiKhoan;
                    return;
                    
                }else if(string.IsNullOrWhiteSpace(this.txtMatKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                    this.ActiveControl = this.txtMatKhau;
                    return;
                    
                }
                this.btnDangNhap.PerformClick();
            }
                
        }
    }
}