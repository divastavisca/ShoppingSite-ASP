using ShoppingSite.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ShoppingSite.Entry.src
{
    public class InventoryManagerGenerator
    {
        public InventoryManager InventoryManager { get; }
        public Inventory Inventory { get; }
        public Dictionary<string,List<string>> InventoryMap { get; }
        public List<KeyValuePair<string,int>> InventoryCount { get; }

        public InventoryManagerGenerator()
        {
            InventoryGenerator inventory = new InventoryGenerator();
            Inventory = inventory.Inventory;
            InventoryMap = inventory.ItemsGenerator.ItemMap;
            InventoryCount = new List<KeyValuePair<string, int>>();
            foreach (KeyValuePair<string,List<string>> keyValue in InventoryMap)
            {
                InventoryCount.Add(new KeyValuePair<string, int>(keyValue.Key,keyValue.Value.Count));
            }
            Dictionary<string, Dispachment> inventoryLog = new Dictionary<string, Dispachment>();
            InventoryManager= new InventoryManager(Inventory, inventory.ItemsGenerator.ItemMap, inventoryLog);
        }
    }
}