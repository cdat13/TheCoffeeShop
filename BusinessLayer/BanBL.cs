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
    public class BanBL
    {
        private BanDL banDL;
        public BanBL()
        {
            banDL = new BanDL();
        }

        public Ban BanSo(int SoBan)
        {
            try
            {
                try
                {
                    List<Ban> danhSachBan = banDL.GetBans();
                    Ban banSo = danhSachBan.FirstOrDefault(ban => ban.Id == SoBan);
                    return banSo;
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
