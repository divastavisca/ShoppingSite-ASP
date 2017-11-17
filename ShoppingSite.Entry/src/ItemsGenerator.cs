using ShoppingSite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSite.Entry.src
{
    public class ItemsGenerator
    {
        public List<IItem> Items { get; private set; }

        public Dictionary<string, int> ItemPrice { get; private set; }
        public Dictionary<string, List<string>> ItemMap { get; private set; }

        public ItemsGenerator()
        {
            int i;
            Items = new List<IItem>();
            ItemMap = new Dictionary<string, List<string>>();
            string[] airConditioners = new string[] { "Blue Star AC", "Hitachi AC", "Voltas AC", "Kenstar AC" };
            int[] acPrice = new int[] { 20000, 14000, 23000, 21300 };
            string[] laptops = new string[] {"Dell laptop","Hp laptop","Lenovo laptop","Mac" };
            int[] laptopPrice = new int[] { 32000,23000,24400,67000 };
            string[] mobiles = new string[] {"iPhone 5","One plus 3T","Yureka Plus","iPhone 7" };
            int[] mobilePrice = new int[] {30000,26000,7000,56000 };
            string[] powerBanks = new string[] { "Sony power bank", "Intex Power Bank", "Samsung power bank", "Ambrane power bank" };
            int[] pbPrice = new int[] {2000,1200,2100,1000 };
            ItemPrice = new Dictionary<string, int>();
            for (i= 1;i<=4;i++)
            {
                int j;
                for (j = 1; j < 10; j++)
                {
                    IItem ac = new AirConditioner((i * j).ToString(), airConditioners[i - 1],acPrice[i-1]);
                    Items.Add(ac);
                    if (!ItemMap.ContainsKey(ac.GetItemInfo()))
                        ItemMap.Add(ac.GetItemInfo(),new List<string>());
                    ItemMap[ac.GetItemInfo()].Add(ac.GetItemId());

                    IItem laptop = new Laptop((i * j * 2).ToString(), laptops[i - 1],laptopPrice[i-1]);
                    Items.Add(laptop);
                    if (!ItemMap.ContainsKey(laptop.GetItemInfo()))
                        ItemMap.Add(laptop.GetItemInfo(), new List<string>());
                    ItemMap[laptop.GetItemInfo()].Add(laptop.GetItemId());

                    IItem mobile = new Mobile((i * j * 3).ToString(), mobiles[i - 1],mobilePrice[i-1]);
                    Items.Add(mobile);
                    if (!ItemMap.ContainsKey(mobile.GetItemInfo()))
                        ItemMap.Add(mobile.GetItemInfo(),new List<string>());
                    ItemMap[mobile.GetItemInfo()].Add(mobile.GetItemId());

                    IItem powerBank = new PowerBank((i * j * 4).ToString(), powerBanks[i - 1],pbPrice[i-1]);
                    Items.Add(powerBank);
                    if (!ItemMap.ContainsKey(powerBank.GetItemInfo()))
                        ItemMap.Add(powerBank.GetItemInfo(), new List<string>());
                    ItemMap[powerBank.GetItemInfo()].Add(powerBank.GetItemId());
                }
                ItemPrice.Add(airConditioners[i - 1], acPrice[i - 1]);
                ItemPrice.Add(laptops[i - 1], laptopPrice[i - 1]);
                ItemPrice.Add(mobiles[i - 1], mobilePrice[i - 1]);
                ItemPrice.Add(powerBanks[i - 1], pbPrice[i - 1]);
            }
        }
    }
}