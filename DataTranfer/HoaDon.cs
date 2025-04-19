using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranfer
{
    public class HoaDon
    {
        public int Id { get; set; }
        public int Order_Id { get; set; }
        public int Product_Id { get; set; }
        public int Table_Id { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public HoaDon(int id, int order_Id, int product_Id, int table_Id, float price, int quantity)
        {
            Id = id;
            Order_Id = order_Id;
            Product_Id = product_Id;
            Table_Id = table_Id;
            Price = price;
            Quantity = quantity;
        }
    }
}
