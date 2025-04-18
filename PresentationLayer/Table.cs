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
            btt_Table.BackColor = Color.Red;

            BanBL banBL = new BanBL();
            Ban banChon = banBL.BanSo(1);

            txtTrangThai.Text = banChon.Status.ToString();
            txtThoiGian.Text = banChon.Status.ToString();

        }
    }
}
