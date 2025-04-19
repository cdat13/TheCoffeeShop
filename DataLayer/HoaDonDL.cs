using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTranfer;

namespace DataLayer 
{
    public class HoaDonDL : DataProvider
    {
       public List<HoaDon> GetHoaDons(int table_id)
        {
            string sql = "SELECT * FROM OrderDetail WHERE table_id='" + table_id + "'";
            int id, order_id, product_id, quantity;
            float price;
            List<HoaDon> hoadons = new List<HoaDon>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader[0]);
                    order_id = Convert.ToInt32(reader[1]);
                    product_id = Convert.ToInt32(reader[2]);
                    price = Convert.ToSingle(reader[3]);
                    quantity = Convert.ToInt32(reader[4]);
                    table_id = Convert.ToInt32(reader[5]);
                    HoaDon hoadon = new DataTranfer.HoaDon(id,order_id,product_id,table_id,price,quantity);
                    hoadons.Add(hoadon);
                }
                reader.Close();
                return hoadons;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                Disconnect();
            }

            
        }
    }
}
