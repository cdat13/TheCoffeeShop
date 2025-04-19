using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataTranfer;

namespace BusinessLayer
{
    public class HoaDonBL
    {
        private HoaDonDL hoadonDL;
        public HoaDonBL()
        {
            hoadonDL = new HoaDonDL();
        }
        
        public List<HoaDon> GetHoaDons(int SoBan)
        {
            try
            {
                return (hoadonDL.GetHoaDons(SoBan));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        
    }
}
