using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlsv_tc
{
    class Ultils
    {

        public static void BindingDataToComBo(ComboBox combo, Object data)
        {
            combo.DataSource = data;
            combo.DisplayMember = "TENKHOA";
            combo.ValueMember = "TENSERVER";

            // nếu login vào là khoa cntt, thì combox sẽ hiện khoa cntt
            // nếu login vào là khoa vt, thì combox sẽ hiện khoa vt
            combo.SelectedIndex = Program.mKhoa;
        }

        // hỗ trợ trong combobox chọn chi nhánh
        public static void ComboboxHelper(ComboBox cmb)
        {
            // bắt lỗi khi giá trị của selectedvalue = "sysem.data.datarowview"  ==> lỗi hay gặp của combobox winform
            if (cmb.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            // gán server đã chọn vào biến toàn cục.
            Program.servername = cmb.SelectedValue.ToString();
            Console.WriteLine("Servername : " + Program.servername);

            // đoạn code hỗ trợ chuyển chi nhánh
            // ở chi nhánh A qua B thì dùng RemoteLogin,
            if (cmb.SelectedIndex != Program.mKhoa)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            { // ở B về lại A dùng login ban đầu
                Program.mlogin = Program.mloginDN;
                Program.password = Program.mPasswordDN;
            }
        }

        public static string ShowPromt(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 250,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            textLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            textBox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Button cancelConfirm = new Button() { Text = "Cancel", Left = 250, Width = 100,Height = 40, Top = 100, DialogResult = DialogResult.Cancel };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Height = 40, Top = 100, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancelConfirm.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancelConfirm);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        // -1 lỗi kết nối csdl --  0 không có dữ liệu trả về -- > 0 có dữ liệu trả về
        public static int CheckDataHelper(String query)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);

            // nếu null thì thoát luôn  ==> lỗi kết nối
            if (dataReader == null)
            {
                return -1;
            }

            if (dataReader.Read())
            {
                try
                {
                    int result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();
                    return result;
                }
                catch (System.FormatException)
                {
                    // true
                }
            }
            dataReader.Close();
            return 0;
        }
        public static string GetMaKhoa()
        {
            string sql = "SELECT MAKHOA FROM KHOA";
            SqlDataReader dataReader = Program.ExecSqlDataReader(sql);
            dataReader.Read();
            return dataReader.GetString(0);
        }
    }

}
