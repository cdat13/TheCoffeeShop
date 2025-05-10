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

namespace PresentationLayer
{
    public partial class QuanLyHoaDon: Form
    {
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void LoadOrders()
        {
            string connectionString = "Data Source=DESKTOP-AHU5FGU;Initial Catalog=CoffeShop;Integrated Security=True;";
            string query = "SELECT id, user_id, total, date, phuong_thuc FROM [Order]";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Tùy chọn: tự động fit cột
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadOrders();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadOrderDetails(int orderId)
        {
            string connectionString = "Data Source=DESKTOP-AHU5FGU;Initial Catalog=CoffeShop;Integrated Security=True;";

            string query = @"
        SELECT 
            od.product_id,
            p.name AS product_name,
            od.price,
            od.quantity,
            (od.price * od.quantity) AS total
        FROM OrderDetail od
        JOIN Product p ON od.product_id = p.id
        WHERE od.order_id = @orderId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@orderId", orderId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView2.DataSource = dt;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy ID hóa đơn từ dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int orderId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                LoadOrderDetails(orderId);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa.");
                return;
            }

            // Lấy ID hóa đơn được chọn
            int orderId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            // Xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string connectionString = "Data Source=DESKTOP-AHU5FGU;Initial Catalog=CoffeShop;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // 1. Xóa chi tiết hóa đơn
                        string deleteDetails = "DELETE FROM OrderDetail WHERE order_id = @orderId";
                        SqlCommand cmdDetail = new SqlCommand(deleteDetails, conn, transaction);
                        cmdDetail.Parameters.AddWithValue("@orderId", orderId);
                        cmdDetail.ExecuteNonQuery();

                        // 2. Xóa hóa đơn
                        string deleteOrder = "DELETE FROM [Order] WHERE id = @orderId";
                        SqlCommand cmdOrder = new SqlCommand(deleteOrder, conn, transaction);
                        cmdOrder.Parameters.AddWithValue("@orderId", orderId);
                        cmdOrder.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Xóa hóa đơn thành công.");

                        // Tải lại danh sách hóa đơn và xóa chi tiết
                        LoadOrders();
                        dataGridView2.DataSource = null;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message);
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpFilter.Value;
            int month = selectedDate.Month;
            int year = selectedDate.Year;

            string query;
            SqlCommand cmd;

            string connectionString = "Data Source=DESKTOP-AHU5FGU;Initial Catalog=CoffeShop;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                if (chkUseExactDay.Checked)
                {
                    // Lọc chính xác theo ngày (ngày/tháng/năm)
                    query = @"
                SELECT id, user_id, total, date, phuong_thuc
                FROM [Order]
                WHERE CAST(date AS DATE) = @selectedDate";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate.Date);
                }
                else
                {
                    // Lọc theo tháng và năm
                    query = @"
                SELECT id, user_id, total, date, phuong_thuc
                FROM [Order]
                WHERE MONTH(date) = @month AND YEAR(date) = @year";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  // Tạo instance của Form1
            form1.Show();               // Hiển thị Form1
            this.Hide();
        }
    }
}
