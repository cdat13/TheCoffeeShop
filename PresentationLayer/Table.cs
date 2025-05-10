using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTranfer;
using System.Data.SqlClient;
using BusinessLayer;
using QRCoder;

namespace PresentationLayer
{
    public partial class Table: Form
    {
        public Table()
        {
            InitializeComponent();
        }
        BanBL banBL = new BanBL();

        private Button tableSetUp(int tableNumber)
        {
            Button btt = new Button();

            btt.Name = "btt_Table" + tableNumber;
            btt.AutoSize = false;
            btt.Width = 200 ;
            btt.Height = 180 ;
            btt.Text = "Bàn " + tableNumber;
            btt.Margin = new Padding(5); 
            btt.TextAlign = ContentAlignment.MiddleCenter;

            Ban banChon = banBL.BanSo(tableNumber);
            if (banChon.Status == false)
                btt.BackColor = Color.Red;

            btt.Click += new EventHandler(this.Table_Click);

            return btt;
        }
        private void GenerateQRCode(string content)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(4);
            if (qrCodeImage != null)
            {
                pic_QR.Image = qrCodeImage;
            }
            else
            {
                MessageBox.Show("QR Code image is null!");
            }

        }
        private void Table_Click(object sender, EventArgs e)
        {
            // Load dgv
            List<string> names = new List<string>() {"Name", "Quantity", "Order_price", "Total_price" };
            List<string> ten = new List<string>() {"Tên", "Số lượng", "Giá", "Tổng giá" };

            dgv_HoaDon = CustomeDataGridView(dgv_HoaDon, names, ten);

            // Catch click button event
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                // Get Number of table
                string text = clickedButton.Text;
                int tableNumber = int.Parse(text.Split(' ')[1]);

                // Get Table
                Ban banSo = banBL.BanSo(tableNumber);
                text_TableNumber.Text = tableNumber.ToString();
                if (banSo.Status == true)
                {
                    text_TrangThai.Text = "Trống";
                    text_ThoiGian.Text = "";
                    text_HoaDon.Text = "";
                    dgv_HoaDon.DataSource = null ;
                }
                else
                {
                    text_TrangThai.Text = "Không trống";
                    text_ThoiGian.Text = banSo.Datetime.ToString("dd/MM/yyyy HH:mm");
                    List<HoaDon> dsHoaDon = new HoaDonBL().GetHoaDons(tableNumber);
                    if (dsHoaDon != null && dsHoaDon.Count > 0)
                    {
                        text_HoaDon.Text = dsHoaDon[0].Order_Id.ToString();
                        dgv_HoaDon.DataSource = dsHoaDon;
                    }
                }
                GenerateQRCode(tableNumber.ToString());
            }

        }

        private void Table_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            // Add button to flow panel = number of table
            for (int i = 1; i < 7; i++)
            {
                flpnl_Table.Controls.Add(tableSetUp(i)); 
            }
        }
        private void LoadTables()
        {
            // Clear existing buttons from the flow panel
            flpnl_Table.Controls.Clear();

            // Add buttons again (number of tables)
            for (int i = 1; i < 7; i++)
            {
                flpnl_Table.Controls.Add(tableSetUp(i));
            }

            text_TrangThai.Text = "Trống";
            text_ThoiGian.Text = "";
            text_HoaDon.Text = "";
            dgv_HoaDon.DataSource = null;
        }

        private void btt_ClearTable_Click(object sender, EventArgs e)
        {
            int id = int.Parse(text_TableNumber.Text);
            Ban banChon = banBL.BanSo(id);


            if (text_TrangThai.Text == "Không trống")
            {
                try
                {
                    banBL.Update(banChon);
                    LoadTables();
                    MessageBox.Show("Bàn đã được làm trống.");
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
            }
        }

        private DataGridView CustomeDataGridView(DataGridView dgv, List<string> names, List<string> ten)
        {
            // Ngắt kết nối nếu có DataSource
            dgv.DataSource = null;

            dgv.Rows.Clear();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AutoGenerateColumns = false;

            // Xóa các cột hiện có trước khi thêm mới
            dgv.Columns.Clear();


            for (int i = 0; i < names.Count; i++)
            {
                dgv.Columns.Add(new DataGridViewTextBoxColumn());
            }
            for (int i = 0; i < names.Count; i++)
            {
                dgv.Columns[i].Name = names[i];
                dgv.Columns[i].DataPropertyName = names[i];
                dgv.Columns[i].HeaderText = ten[i];
            }
            return dgv;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
