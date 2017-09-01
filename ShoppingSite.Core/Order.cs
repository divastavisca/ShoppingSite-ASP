using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSite.Core
{
    public class Order
    {
        public string OrderId { get; }

        public List<IItem> Items { get; }
       
        public DateTime OrderDate { get; }

        public double OrderAmount { get; }

        public string CustomerId { get; }

        public Order(string orderId,List<IItem> orderItems,DateTime orderTime,double orderAmount,string customerId)
        {
            OrderId = orderId;
            Items = orderItems;
            OrderDate = orderTime;
            OrderAmount = orderAmount;
            CustomerId = customerId;
        }
    }
}
