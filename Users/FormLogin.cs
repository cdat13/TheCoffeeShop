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
using System.Windows.Forms.VisualStyles;
using BusinessLayer;
using DataTranfer;

namespace PresentationLayer
{
    public partial class FormLogin : Form
    {
        public static User u;

        public FormLogin()
        {
            InitializeComponent();
            txbpass.PasswordChar = '*';
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txbusername.Text.Trim();
            string password = txbpass.Text.Trim();

            try
            {
                UserBL userBL = new UserBL();
                u = userBL.Login(username, password);

                if (u != null)
                {
                    MessageBox.Show($"Đăng nhập thành công với vai trò: {u.User_role}", "Thành công");

                    this.Hide();
                    Form1 f = new Form1(u.User_role, u.Name);
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.\nChi tiết: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FormLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
