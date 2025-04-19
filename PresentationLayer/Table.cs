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
        private void btt_Table_Click(object sender, EventArgs e)
        {
            Button btt = sender as Button;
            int soBan = (int)btt.Tag;
            btt.BackColor = Color.Red;

            // Lay Table
            BanBL banBL = new BanBL();
            Ban banChon = banBL.BanSo(soBan);

            if (banChon.Status == false)
                txtTrangThai.Text = "Không Trống";
            else
                txtTrangThai.Text = "Trống";
            txtThoiGian.Text = banChon.Datatime.ToString();

            // Lay Order Detail
            dgv_HoaDon.DataSource = new HoaDonBL().GetHoaDons(soBan);
            
            

        }
    }
}
