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
            btt.Width = 175 ;
            btt.Height = 115 ;
            btt.Text = "Bàn " + tableNumber;
            btt.Margin = new Padding(5); 
            btt.TextAlign = ContentAlignment.MiddleCenter;

            Ban banChon = banBL.BanSo(tableNumber);
            if (banChon.Status == false)
                btt.BackColor = Color.Red;

            btt.Click += new EventHandler(this.Table_Click);

            return btt;
        }
        void Table_Click(object sender, EventArgs e)
        {
            // Catch click button event
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                // Get Number of table
                string text = clickedButton.Text;
                int tableNumber = int.Parse(text.Split(' ')[1]);

                // Get Table
                Ban banSo = banBL.BanSo(tableNumber);
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
            }
        }

        private void Table_Load(object sender, EventArgs e)
        {
            // Add button to flow panel = number of table
            for (int i = 1; i < 7; i++)
            {
                flpnl_Table.Controls.Add(tableSetUp(i)); 
            }
        }

        
    }
}
