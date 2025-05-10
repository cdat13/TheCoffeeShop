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
using BusinessLayer;
using System.IO;
using DataTranfer;

namespace PresentationLayer
{
    public partial class WorkDay : Form
    {
        public WorkDay()
        {
            InitializeComponent();
        }

        private void WorkDayLoad()
        {

            var list = new WorkDayBL().GetWorkDays();
            if (list != null && list.Count > 0)
            {
                dgv_NgayCong.DataSource = list;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu ca làm.");
            }
        }

        private DataGridView CustomeDataGridView(DataGridView dgv, List<String> names, List<String> ten)
        {
            dgv.Rows.Clear();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoGenerateColumns = false;
            dgv.RowHeadersVisible = false;


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

        private void WorkDay_Load(object sender, EventArgs e)
        {
            // Khoi tao full man hinh
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            // Khoi tao ten column dgv
            List<String> names = new List<String>() { "Id", "Workday_Name", "User_Name", "User_Role", "Date" };
            List<String> ten = new List<String>() { "Id", "Ca", "Nhân viên", "Chức vụ", "Ngày" };

            dgv_NgayCong = CustomeDataGridView(dgv_NgayCong, names, ten);

            // Load combox Ca lam
            FillComboCaLam();
            //Load combobox Nhan vien
            FillComboSearch();

            WorkDayLoad();
        }

        private void FillComboCaLam()
        {
            comboBox_CaLam.Items.Clear();
            comboBox_CaLam.Items.Add("Ca sáng");
            comboBox_CaLam.Items.Add("Ca chiều");
            comboBox_CaLam.Items.Add("Ca tối");
        }

        private void FillComboSearch()
        {
            comboBox_NhanVien.Items.Clear();
            var list = new NhanVienBL().GetsNhanVien();
            if (list != null && list.Count > 0)
            {
                comboBox_NhanVien.DataSource = list;
                comboBox_NhanVien.DisplayMember = "name";
                comboBox_NhanVien.ValueMember = "id";
            }
        }

        private void btt_Tao_Click(object sender, EventArgs e)
        {
            if (comboBox_CaLam != null && comboBox_NhanVien != null && datePicker != null)
            {
                int user_id = (int)comboBox_NhanVien.SelectedValue;
                string calam_id = comboBox_CaLam.SelectedItem.ToString();
                DateTime date = datePicker.Value.Date;
                WorkDayBL workDayBL = new WorkDayBL();

                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;

                result = MessageBox.Show("Bạn có muốn thêm ca làm?", "Lựa chọn", buttons);
                if (result == DialogResult.OK)
                {
                    workDayBL.ThemCaLam(user_id, calam_id, date);
                    WorkDayLoad();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin trước khi tạo.");
                return;
            }
        }

        private void btt_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_NgayCong.SelectedCells.Count != 0)
            {
                int rowIndex = dgv_NgayCong.CurrentCell.RowIndex;

                int id = Convert.ToInt32(dgv_NgayCong.Rows[rowIndex].Cells[0].Value);
                WorkDayBL workDayBL = new WorkDayBL();

                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;
                result = MessageBox.Show("Bạn đã chắc?", "Lựa chọn", buttons);
                if (result == DialogResult.OK)
                {
                    workDayBL.XoaCaLam(id);
                    WorkDayLoad();
                }

            }
        }

        private void dgv_NgayCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_NgayCong.Rows[e.RowIndex];

                comboBox_CaLam.Text = row.Cells["Workday_Name"].Value?.ToString();
                comboBox_NhanVien.Text = row.Cells["User_Name"].Value?.ToString();
                datePicker.Value = DateTime.Parse(row.Cells["Date"].Value.ToString());
            }
        }

        private void btt_SuaCaLam_Click(object sender, EventArgs e)
        {
            string workday_name = comboBox_CaLam.Text;
            string user_name = comboBox_NhanVien.Text;
            DateTime date = datePicker.Value;

            int rowIndex = dgv_NgayCong.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgv_NgayCong.Rows[rowIndex].Cells["Id"].Value);

            if (dgv_NgayCong.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa?", "Xác nhận", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    WorkDayBL workDayBL = new WorkDayBL();
                    workDayBL.SuaCaLam(id, date, workday_name, user_name);
                    WorkDayLoad();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.");
            }
        }

    }
}
