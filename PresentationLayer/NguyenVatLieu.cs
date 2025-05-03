using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class NguyenVatLieu: Form
    {
        public NguyenVatLieu()
        {
            InitializeComponent();
        }

        private DataGridView CustomDGV(DataGridView dgv, List<String> names, List<String> ten)
        {
            dgv.Rows.Clear();

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoGenerateColumns = false;

            for(int i = 0; i < names.Count; i++)
            {
                dgv.Columns.Add(new DataGridViewTextBoxColumn());
            }
            
            for(int i = 0; i< names.Count; i++)
            {
                dgv.Columns[i].Name = names[i];
                dgv.Columns[i].DataPropertyName = names[i];
                dgv.Columns[i].HeaderText = ten[i];
            }

            return dgv;

        }
        private void NguyenVatLieu_Load(object sender, EventArgs e)
        {
            List<String> names = new List<String>() {"Id", "name", "category", "quantity", "product_date" };
            List<String> ten = new List<String>() { "Id", "Tên sản phẩm", "Loại sản phẩm", "Số lượng", "Hạn sử dụng" };

            dgv_NguyenVatLieu = CustomDGV(dgv_NguyenVatLieu, names, ten);

            var list = new NguyenVatLieuBL().GetNguyenVatLieuBLs();
            if (list != null && list.Count > 0)
            {
                dgv_NguyenVatLieu.DataSource = list;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu.");

            }
        }
        
    }
}
