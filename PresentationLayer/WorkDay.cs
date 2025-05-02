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
    public partial class WorkDay: Form
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
            List<String> names = new List<String>() { "Id", "Workday_Name", "User_Name", "User_Role", "Date" };
            List<String> ten = new List<String>() { "Id", "Ca", "Nhân viên", "Chức vụ", "Ngày" };

            dgv_NgayCong = CustomeDataGridView(dgv_NgayCong, names, ten);

            //Load combobox
            FiillComboSearch();

            WorkDayLoad();
        }

        private void FiillComboSearch()
        {
            comboBox_NhanVien.Items.Clear();
            var list = new NhanVienBL().GetsNhanVien();
            if(list != null && list.Count > 0)
            {
                comboBox_NhanVien.DataSource = list;
                comboBox_NhanVien.DisplayMember = "name" ;
                comboBox_NhanVien.ValueMember = "id";
            }
            
            
        }

        private void btt_Tao_Click(object sender, EventArgs e)
        {
            if(comboBox_CaLam != null && comboBox_NhanVien != null && datePicker != null)
            {
                int user_id = (int)comboBox_NhanVien.SelectedValue;
                string calam_id = comboBox_CaLam.SelectedItem.ToString();
                DateTime date = datePicker.Value.Date;
                WorkDayBL workDayBL = new WorkDayBL();
             
                workDayBL.ThemCaLam(user_id, calam_id, date);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin trước khi tạo.");
                return;
            }    
        }
    }
}
