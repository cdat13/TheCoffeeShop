using DataTranfer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLayer
{
    public class NguyenVatLieuDL : DataProvider
    {
        public List<NguyenVatLieu> GetNguyenVatLieus()
        {
            string sql = "SELECT * \r\nFROM NguyenLieu";
            int id, quantity;
            string name, category;
            DateTime product_date;
            List<NguyenVatLieu> nguyenVatLieus = new List<NguyenVatLieu>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, System.Data.CommandType.Text);
                while(reader.Read())
                {
                    id = (int)reader[0];
                    name = reader[1].ToString();
                    category = reader[2].ToString();
                    quantity = (int)reader[3];
                    product_date = (DateTime)reader[4];

                    NguyenVatLieu nguyenVatLieu = new NguyenVatLieu(id, name, category, quantity, product_date);
                    nguyenVatLieus.Add(nguyenVatLieu);
                }
                reader.Close();
                return nguyenVatLieus;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int LayNguyenVatLieu(int id, int quantity)
        {
            string sql = "LayNguyenVatLieu";
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@layNVL", quantity));
            parameters.Add(new SqlParameter("@product_id", id));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }

}
