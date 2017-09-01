using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSite.Core
{
    public class Address
    {
        public string PlotNo { get; }
        public string Locality { get; }
        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public string Country { get; }
        public string PinCode { get; }
        public string LandMark { get; }

        public static bool IsPinCodeValid(string pinCode)
        {
            int value;
            if(Int32.TryParse(pinCode,out value))
            {
                if (pinCode.Length == 6)
                    return true;
                return false;
            }
            return false;
        }

        public Address(string plotNo,string locality,string street,string city,string state,string country,string pinCode,string landMark)
        {
            PlotNo = plotNo;
            Locality = locality;
            Street = street;
            City = city;
            State = state;
            Country = country;
            PinCode = pinCode;
            LandMark = landMark;
        }
    }
}
