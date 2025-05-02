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
    public class NhanVienBL
    {
        private NhanVienDL nhanVienDL;
        public NhanVienBL()
        {
            nhanVienDL = new NhanVienDL();
        }
        public List<NhanVien> GetsNhanVien()
        {
            try
            {
                return (nhanVienDL.GetNhanViens());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
