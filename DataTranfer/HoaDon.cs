using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranfer
{
    public class HoaDon
    {
        public int Order_Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Total_price { get; set; }
        public int Order_price { get; set; }
        
        public HoaDon(int order_id, string name, int quantity, int total_price, int order_price)
        {
            Order_Id = order_id;
            Name = name;
            Quantity = quantity;
            Total_price = total_price;
            Order_price = order_price;
        }
    }
}
