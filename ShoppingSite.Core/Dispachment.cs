using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSite.Core
{
    public class Dispachment
    {
        public string ItemId { get; }
        public DateTime DispachTime { get; }

        public Dispachment(string itemId,DateTime dispatchTime)
        {
            ItemId = itemId;
            DispachTime = dispatchTime;
        }
    }
}
