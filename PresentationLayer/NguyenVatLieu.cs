using BusinessLayer;
using PresentationLayer.FormBaoCao;
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

        private void LayNguyenLieu_Load()
        {
            var list = new NguyenVatLieuBL().GetNguyenVatLieuBLs();
            if(list != null && list.Count > 0)
            {
                dgv_NguyenVatLieu.DataSource = list;

            }
            else
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }

        private DataGridView CustomDGV(DataGridView dgv, List<String> names, List<String> ten)
        {
            dgv.Rows.Clear();
            dgv.RowHeadersVisible = false;
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
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;


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

        private void bttSoLuong_Click(object sender, EventArgs e)
        {

            if (dgv_NguyenVatLieu.SelectedCells.Count != 0)
            {
                var selectedRow = dgv_NguyenVatLieu.CurrentRow;
                if (selectedRow == null)    
                {
                    MessageBox.Show("Không thể lấy dòng đang chọn.", "Lỗi");
                }

                if (!int.TryParse(txtSoLuong.Text.Trim(), out int laySoLuong) && laySoLuong <= 0 && string.IsNullOrWhiteSpace(txtSoLuong.Text))
                {
                    MessageBox.Show("Số lượng phải là một số nguyên hợp lệ!", "Cảnh báo");
                    return;
                }
                
                laySoLuong = int.Parse(txtSoLuong.Text);
                int product_id = int.Parse(dgv_NguyenVatLieu.SelectedCells[0].Value.ToString());
                int soLuongKho = int.Parse(dgv_NguyenVatLieu.SelectedCells[3].Value.ToString());

                if (laySoLuong <= soLuongKho)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result;
                    result = MessageBox.Show("Bạn đã chắc chắn về số lượng?", "Lựa chọn", buttons);

                    if (result == DialogResult.OK)
                    {
                        NguyenVatLieuBL nguyenVatLieuBL = new NguyenVatLieuBL();
                        nguyenVatLieuBL.LayNguyenVatLieu(product_id, laySoLuong);
                        LayNguyenLieu_Load();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn đầy đủ thông tin trước khi tạo.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng yêu cầu vượt quá số lượng trong kho!", "Lỗi");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng nguyên vật liệu.", "Thông báo");
                return;
            }
            
        }

        private void btt_In_Click(object sender, EventArgs e)
        {
            BaoCaoNguyenVatLieu bc = new BaoCaoNguyenVatLieu();
            bc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaoCaoThang bct = new BaoCaoThang();
            bct.ShowDialog();
        }


    }
}
