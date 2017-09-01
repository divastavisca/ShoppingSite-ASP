using ShoppingSite.Core;

namespace ShoppingSite.Entry.src
{
    public class Item : IItem
    {
        public string Id;
        public string Info;

        public string GetItemId()
        {
            return Id;
        }

        public string GetItemInfo()
        {
            return Info;
        }

        public Item(string id)
        {
            Id = id;
        }
    }
}