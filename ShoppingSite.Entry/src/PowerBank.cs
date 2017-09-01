using ShoppingSite.Core;

namespace ShoppingSite.Entry.src
{
    public class PowerBank : Item, IItem
    {
        public PowerBank(string id, string info) : base(id)
        {
            Info = info;
        }
    }
}