using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataTranfer;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class NguyenVatLieuBL
    {
        private NguyenVatLieuDL nguyenVatLieuDL;
        public NguyenVatLieuBL()
        {
            nguyenVatLieuDL = new NguyenVatLieuDL();
        }

        public List<NguyenVatLieu> GetNguyenVatLieuBLs()
        {
            try
            {
     
                return (nguyenVatLieuDL.GetNguyenVatLieus());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<NguyenVatLieu> BaoCaoThang(DateTime date)
        {
            try
            {
                return (nguyenVatLieuDL.BaoCaoThang(date));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int LayNguyenVatLieu(int id, int quantity)
        {
            try
            {
                return nguyenVatLieuDL.LayNguyenVatLieu(id, quantity);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

    }
}
