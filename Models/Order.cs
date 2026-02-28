using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchLibrary.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public double Amount { get; set; }

        public Order(int id, string customerName, double amount)
        {
            Id = id;
            CustomerName = customerName;
            Amount = amount;
        }
    }
}