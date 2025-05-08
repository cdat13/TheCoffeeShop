using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer.FormBaoCao
{
    public partial class BaoCaoThang: Form
    {
        public BaoCaoThang()
        {
            InitializeComponent();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomPercent = 100;
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }

        private void BaoCaoThang_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "MM/yyyy";
        }

        private void btt_Loc_Click(object sender, EventArgs e)
        {
            if(datePicker.Value != null)
            {

                var list = new NguyenVatLieuBL().BaoCaoThang(datePicker.Value);

                reportViewer1.LocalReport.ReportPath = @"C:\Users\ASUS\Downloads\HocKy2-Nam3\TheCoffeeShop\PresentationLayer\ReportNguyenLieu.rdlc";

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("NguyenLieu", list));
                reportViewer1.RefreshReport();
            }
        }
    }
}
