using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using DataTranfer;
namespace PresentationLayer
{
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cboRole.Text.Trim();
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            NhanVienDL dal = new NhanVienDL();
            if (dal.IsUsernameExists(username))
            {
                MessageBox.Show("Username đã tồn tại. Vui lòng chọn username khác.");
                return;
            }

            bool success = dal.InsertUser(username, password, role, name);
            if (success)
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                dataGridView1.DataSource = dal.GetNhanViens_Full(); // load lại
                ClearForm(); // xóa form
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm nhân viên.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NhanVienDL NhanVienDAL = new NhanVienDL();
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            // Thêm các lựa chọn vai trò
            cboRole.Items.Clear();
            cboRole.Items.Add("Cashier");
            cboRole.Items.Add("Employee");
            cboRole.Items.Add("Admin");

            NhanVienDL dal = new NhanVienDL();
            List<NhanVien> nhanViens = dal.GetNhanViens_Full();
            dataGridView1.DataSource = nhanViens;
        }
        int selectedUserId = -1;

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật.");
                return;
            }

            string newPassword = txtPassword.Text.Trim();
            string newRole = cboRole.Text;
            string newName = txtName.Text.Trim();

            // Gọi hàm cập nhật
            NhanVienDL dal = new NhanVienDL();
            bool success = dal.UpdateUser(selectedUserId, newPassword, newRole, newName);

            if (success)
            {
                MessageBox.Show("Cập nhật thành công!");

                // Load lại bảng
                dataGridView1.DataSource = dal.GetNhanViens_Full();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.");
            }
        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                NhanVienDL dal = new NhanVienDL();
                bool result = dal.DeleteUser(selectedUserId);

                if (result)
                {
                    MessageBox.Show("Đã xóa thành công.");
                    dataGridView1.DataSource = dal.GetNhanViens_Full();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }
        private void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtName.Clear();
            cboRole.SelectedIndex = -1;
            txtUsername.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lưu ID để sau này dùng khi cập nhật
                selectedUserId = Convert.ToInt32(row.Cells["Id"].Value);

                // Gán dữ liệu vào các control
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                cboRole.Text = row.Cells["Role"].Value.ToString(); // Hoặc "Role" nếu đã đổi tên
            }
        }

        private void homebt_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  // Tạo instance của Form1
            form1.Show();               // Hiển thị Form1
            this.Hide();                // Ẩn form hiện tại
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
