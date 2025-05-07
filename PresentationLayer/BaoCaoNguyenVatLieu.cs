using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class BaoCaoNguyenVatLieu: Form
    {
        public BaoCaoNguyenVatLieu()
        {
            InitializeComponent();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomPercent = 100;
            reportViewer1.ZoomMode = ZoomMode.Percent;

        }

        private void BaoCaoNguyenVatLieu_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            var list = new NguyenVatLieuBL().GetNguyenVatLieuBLs();

            reportViewer1.LocalReport.ReportPath = @"C:\Users\ASUS\Downloads\HocKy2-Nam3\TheCoffeeShop\PresentationLayer\ReportNguyenLieu.rdlc";


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("NguyenLieu", list));
            reportViewer1.RefreshReport();

        }
    }
}
