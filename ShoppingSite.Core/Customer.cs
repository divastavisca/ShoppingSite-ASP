using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSite.Core
{
    public class Customer
    {
        public string CustomerId { get; }

        public Name CustomerName { get; }

        public List<Address> AddressList { get; }

        public string ContactDetails { get; }

        public Customer(Name customerName, List<Address> addressList,string customerContact)
        {
            CustomerName = customerName;
            AddressList = addressList;
            ContactDetails = customerContact;
        }
    }
}
