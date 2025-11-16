using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4GenericCollections
{
    public class Order
    {
        private static int orderIdCounter = 1;
        public int OrderId { get; private set; }
        public List<MenuItem> OrderItems { get; private set; }
        public int TableNumber { get; private set; }

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            OrderId = orderIdCounter++;
            OrderItems = orderItems;
            TableNumber = tableNumber;
        }
    }
}