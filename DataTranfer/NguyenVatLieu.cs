using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranfer
{
    public class NguyenVatLieu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public DateTime Product_date { get; set; }

        public NguyenVatLieu(int id, string name, string category, int quantity, DateTime product_date)
        {
            Id = id;
            Name = name;
            Category = category;
            Quantity = quantity;
            Product_date = product_date;
        }

        public NguyenVatLieu(int id, int quantity)
        {
            Id = id;
            Quantity = quantity;
        }
        

    }
}
