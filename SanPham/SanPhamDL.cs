using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranfer;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{

    public class SanPhamDL : DataProvider
    {
        public List<SanPham> GetSanPhams()
        {
            string sql = "SELECT * FROM Product";
            List<SanPham> list = new List<SanPham>();

            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    SanPham sp = new SanPham
                    {
                        Id = (int)reader["id"],
                        Name = reader["name"].ToString(),
                        Price = Convert.ToDouble(reader["price"]),
                        Category = reader["category"].ToString(),
                        Picture = reader["picture"] as byte[]
                    };
                    list.Add(sp);
                }
                reader.Close();
                return list;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int ThemSanPham(SanPham p)
        {
            string sql = "INSERT INTO Product(name, price, category, picture) VALUES (@n, @p, @c, @pic)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@n", p.Name),
                new SqlParameter("@p", p.Price),
                new SqlParameter("@c", p.Category),
                new SqlParameter("@pic", p.Picture ?? (object)DBNull.Value)
            };

            return MyExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        public int CapNhatSanPham(SanPham p)
        {
            string sql = "UPDATE Product SET name=@n, price=@p, category=@c, picture=@pic WHERE id=@id";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@n", p.Name),
                new SqlParameter("@p", p.Price),
                new SqlParameter("@c", p.Category),
                new SqlParameter("@pic", p.Picture ?? (object)DBNull.Value),
                new SqlParameter("@id", p.Id)
            };

            return MyExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        public int XoaSanPham(int id)
        {
            string sql = "DELETE FROM Product WHERE id=@id";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@id", id)
            };

            return MyExecuteNonQuery(sql, CommandType.Text, parameters);
        }
    }

}
