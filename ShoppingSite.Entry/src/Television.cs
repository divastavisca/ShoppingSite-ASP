using ShoppingSite.Core;

namespace ShoppingSite.Entry.src
{
    public class Television : Item, IItem
    {
        public Television(string id, string info) : base(id)
        {
            Info = info;
        }
    }
}