using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridMasterDetail
{
    public class Order
    {
        public string Supplier { get; set; }
        public DateTime Date { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public Order(string supplier, DateTime date, string productName, int quantity)
        {
            Supplier = supplier;
            Date = date;
            ProductName = productName;
            Quantity = quantity;
        }
    }
}
