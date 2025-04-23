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
            string sql = "SELECT ord.id, p.name, quantity, quantity * p.price as total_price, ordd.price " +
                "\r\nFROM OrderDetail as ordd" +
                "\r\nINNER JOIN [Product] as p ON ordd.product_id = p.id" +
                "\r\nINNER JOIN [Order] as ord ON ordd.order_id = ord.id" +
                "\r\nWHERE table_id = '" + table_id +"'";
            int ord_id, quantity, total_price, order_price;
            string name;
            List<HoaDon> hoadons = new List<HoaDon>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    ord_id = Convert.ToInt32(reader[0]);
                    name = Convert.ToString(reader[1]);
                    quantity = Convert.ToInt32(reader[2]);
                    total_price = Convert.ToInt32(reader[3]);
                    order_price = Convert.ToInt32(reader[4]);
                    HoaDon hoadon = new DataTranfer.HoaDon(ord_id,name,quantity,total_price,order_price);
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
