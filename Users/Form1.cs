using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataTranfer;

namespace PresentationLayer
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string role;
        private string name;

        public Form1(string userRole, string userName)
        {
            InitializeComponent();
            role = userRole;
            name = userName;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Xin chào {name} ({role})";

            if (role != "Admin")
            {
                button3.Visible = false;
            }
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
    }
}
