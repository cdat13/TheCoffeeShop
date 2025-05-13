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
    public partial class TaoHoaDon: Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-AHU5FGU;Initial Catalog=CoffeShop;Integrated Security=True;";
        public TaoHoaDon()
        {
            InitializeComponent();
        }
        DataTable invoiceTable = new DataTable();

        private void UpdateTotalPrice()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    decimal rowTotal;
                    if (decimal.TryParse(row.Cells["Total"].Value.ToString(), out rowTotal))
                    {
                        total += rowTotal;
                    }
                }
            }

            txtTotalPrice.Text = total.ToString("N0"); // Hiển thị có phân cách ngàn, ví dụ: 150,000
        }
        private void LoadProductData()
        {
            //string connectionString = "Data Source=DESKTOP-AHU5FGU;Initial Catalog=CoffeShop;Integrated Security=True";
            string query = "SELECT id, name, price, category FROM Product"; // Bỏ hình ảnh ở đây

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void TaoHoaDon_Load(object sender, EventArgs e)
        {
            LoadProductData();
            // Tạo cột cho dataGridView2
            invoiceTable.Columns.Add("Product ID");
            invoiceTable.Columns.Add("Product Name");
            invoiceTable.Columns.Add("Price");
            invoiceTable.Columns.Add("Quantity");
            invoiceTable.Columns.Add("Total");
            dataGridView2.DataSource = invoiceTable;

            cboPayment.Items.Clear();
            cboPayment.Items.Add("Tiền mặt");
            cboPayment.Items.Add("Chuyển khoản");
            cboPayment.Items.Add("Momo");

            cboPayment.SelectedIndex = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtProductID.Text = row.Cells["id"].Value.ToString();
                txtProductName.Text = row.Cells["name"].Value.ToString();
                txtPrice.Text = row.Cells["price"].Value.ToString();
                nudQuantity.Value = 1; // mặc định số lượng là 1
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "" || txtProductName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước khi thêm.");
                return;
            }

            string id = txtProductID.Text;
            string name = txtProductName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = (int)nudQuantity.Value;
            decimal total = price * quantity;

            // Thêm dòng vào invoiceTable
            invoiceTable.Rows.Add(id, name, price, quantity, total);
            UpdateTotalPrice(); 
        }
        int selectedInvoiceRowIndex = -1;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedInvoiceRowIndex = e.RowIndex;
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (selectedInvoiceRowIndex >= 0 && selectedInvoiceRowIndex < dataGridView2.Rows.Count)
            {
                invoiceTable.Rows.RemoveAt(selectedInvoiceRowIndex);
                UpdateTotalPrice(); // Cập nhật tổng giá sau khi xóa
                selectedInvoiceRowIndex = -1; // reset sau khi xóa
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa trong danh sách hóa đơn.");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            invoiceTable.Clear();            // Xóa toàn bộ dữ liệu
            txtTotalPrice.Text = "0";        // Reset tổng tiền (nếu có)
            selectedInvoiceRowIndex = -1;    // Reset dòng đã chọn
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (invoiceTable.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm trong hóa đơn.");
                return;
            }

            //string connectionString = "Data Source=DESKTOP-AHU5FGU;Initial Catalog=CoffeShop;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Thêm vào bảng Order
                    string insertOrderQuery = @"
                INSERT INTO [Order] (user_id, total, date, table_id, phuong_thuc)
                OUTPUT INSERTED.id
                VALUES (@user_id, @total, @date, NULL, @phuong_thuc)";

                    SqlCommand cmdOrder = new SqlCommand(insertOrderQuery, conn, transaction);
                    cmdOrder.Parameters.AddWithValue("@user_id", 1); // Giả sử user ID = 1
                    cmdOrder.Parameters.AddWithValue("@total", decimal.Parse(txtTotalPrice.Text));
                    cmdOrder.Parameters.AddWithValue("@date", DateTime.Now);
                    cmdOrder.Parameters.AddWithValue("@phuong_thuc", cboPayment.Text);

                    int orderId = (int)cmdOrder.ExecuteScalar(); // Lấy ID của hóa đơn mới

                    // 2. Thêm từng dòng vào OrderDetail
                    foreach (DataRow row in invoiceTable.Rows)
                    {
                        string insertDetailQuery = @"
                    INSERT INTO OrderDetail (order_id, product_id, price, quantity)
                    VALUES (@order_id, @product_id, @price, @quantity)";

                        SqlCommand cmdDetail = new SqlCommand(insertDetailQuery, conn, transaction);
                        cmdDetail.Parameters.AddWithValue("@order_id", orderId);
                        cmdDetail.Parameters.AddWithValue("@product_id", row["Product ID"]);
                        cmdDetail.Parameters.AddWithValue("@price", row["Price"]);
                        cmdDetail.Parameters.AddWithValue("@quantity", row["Quantity"]);
                        cmdDetail.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Thanh toán thành công!");

                    // Xóa hóa đơn hiện tại khỏi giao diện
                    invoiceTable.Clear();
                    txtTotalPrice.Text = "0";

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi thanh toán: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  // Tạo instance của Form1
            form1.Show();               // Hiển thị Form1
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon qlhd = new QuanLyHoaDon();
            qlhd.ShowDialog();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }


}
