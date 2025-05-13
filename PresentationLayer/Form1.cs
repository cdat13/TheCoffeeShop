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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NguyenVatLieu nguyenVatLieu = new NguyenVatLieu();
            nguyenVatLieu.ShowDialog();
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

        private void button4_Click(object sender, EventArgs e)
        {
            SanPham sanpham = new SanPham();
            sanpham.ShowDialog();
        }
    }
}

