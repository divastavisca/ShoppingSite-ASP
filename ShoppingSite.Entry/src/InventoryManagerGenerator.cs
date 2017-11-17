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
        public InventoryManager InventoryManager { get; private set; }
        public Inventory Inventory { get; private set; }
        public Dictionary<string, List<string>> InventoryMap { get; private set; }
        public Dictionary<string, int> ProductMap { get; private set; }

        public ItemsGenerator ItemsGenerator { get; private set; }
        public InventoryManagerGenerator()
        {
            InventoryGenerator inventory = new InventoryGenerator();
            ItemsGenerator = inventory.ItemsGenerator;
            ProductMap = new Dictionary<string, int>();
            Inventory = inventory.Inventory;
            InventoryMap = inventory.ItemsGenerator.ItemMap;
            int i = 1;
            foreach (string key in InventoryMap.Keys)
            {
                ProductMap.Add(key,i++);
            }
            Dictionary<string, Dispachment> inventoryLog = new Dictionary<string, Dispachment>();
            InventoryManager= new InventoryManager(Inventory, inventory.ItemsGenerator.ItemMap, inventoryLog);
        }
    }
}