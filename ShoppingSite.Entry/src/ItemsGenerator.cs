using ShoppingSite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSite.Entry.src
{
    public class ItemsGenerator
    {
        public List<IItem> Items { get; }
        public Dictionary<string, List<string>> ItemMap { get; }

        public ItemsGenerator()
        {
            int i;
            Items = new List<IItem>();
            ItemMap = new Dictionary<string, List<string>>();
            string[] airConditioners = new string[] { "Blue Star AC", "Hitachi AC", "Voltas AC", "Kenstar AC" };
            string[] laptops = new string[] {"Dell laptop","Hp laptop","Lenovo laptop","Mac" };
            string[] mobiles = new string[] {"iPhone 5","One plus 3T","Yureka Plus","iPhone 7" };
            string[] powerBanks = new string[] { "Sony power bank", "Intex Power Bank", "Samsung power bank", "Ambrane power bank" };
            for (i= 1;i<=4;i++)
            {
                int j;
                for (j = 1; j < 10; j++)
                {
                    IItem ac = new AirConditioner((i * j).ToString(), airConditioners[i - 1]);
                    Items.Add(ac);
                    if (!ItemMap.ContainsKey(ac.GetItemInfo()))
                        ItemMap.Add(ac.GetItemInfo(),new List<string>());
                    ItemMap[ac.GetItemInfo()].Add(ac.GetItemId());

                    IItem laptop = new Laptop((i * j * 2).ToString(), laptops[i - 1]);
                    Items.Add(laptop);
                    if (!ItemMap.ContainsKey(laptop.GetItemInfo()))
                        ItemMap.Add(laptop.GetItemInfo(), new List<string>());
                    ItemMap[laptop.GetItemInfo()].Add(laptop.GetItemId());

                    IItem mobile = new Mobile((i * j * 3).ToString(), mobiles[i - 1]);
                    Items.Add(mobile);
                    if (!ItemMap.ContainsKey(mobile.GetItemInfo()))
                        ItemMap.Add(mobile.GetItemInfo(),new List<string>());
                    ItemMap[mobile.GetItemInfo()].Add(mobile.GetItemId());

                    IItem powerBank = new PowerBank((i * j * 4).ToString(), powerBanks[i - 1]);
                    Items.Add(powerBank);
                    if (!ItemMap.ContainsKey(powerBank.GetItemInfo()))
                        ItemMap.Add(powerBank.GetItemInfo(), new List<string>());
                    ItemMap[powerBank.GetItemInfo()].Add(powerBank.GetItemId());
                }
            }
        }
    }
}