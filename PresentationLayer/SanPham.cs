using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BusinessLayer;
using DataTranfer;

namespace PresentationLayer
{
    public partial class SanPham : Form
    {
        private SanPhamBL bl = new SanPhamBL();

        public SanPham()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dgvsanpham.DataSource = bl.GetAll();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var p = new DataTranfer.SanPham
            {
                Name = txbname.Text,
                Price = double.Parse(txbprice.Text),
                Category = txbcategory.Text
            };
            bl.Add(p);
            LoadData();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgvsanpham.CurrentRow != null)
            {
                var p = new DataTranfer.SanPham
                {
                    Id = (int)dgvsanpham.CurrentRow.Cells["Id"].Value,
                    Name = txbname.Text,
                    Price = double.Parse(txbprice.Text),
                    Category = txbcategory.Text
                };
                bl.Update(p);
                LoadData();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvsanpham.CurrentRow != null)
            {
                int id = (int)dgvsanpham.CurrentRow.Cells["Id"].Value;
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xoá sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    bl.Delete(id);
                    LoadData();
                }
            }
        }

        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvsanpham.CurrentRow != null)
            {
                txbname.Text = dgvsanpham.CurrentRow.Cells["Name"].Value.ToString();
                txbprice.Text = dgvsanpham.CurrentRow.Cells["Price"].Value.ToString();
                txbcategory.Text = dgvsanpham.CurrentRow.Cells["Category"].Value.ToString();
            }
        }
    }
}
