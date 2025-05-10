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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WorkDay workDay = new WorkDay();
            workDay.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NguyenVatLieu nguyenVatLieu = new NguyenVatLieu();
            nguyenVatLieu.ShowDialog();
        }

        private void Emp_mag_btn_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement();
            employeeManagement.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TaoHoaDon taoHoaDon = new TaoHoaDon();
            taoHoaDon.ShowDialog();
            this.Hide();
        }
    }
}
