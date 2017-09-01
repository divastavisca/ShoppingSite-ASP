using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoppingSite.Entry.src;
using ShoppingSite.Core;
using System.Data;
using System.Reflection;

namespace ShoppingSite.Entry
{
    public partial class Home : System.Web.UI.Page
    {
        private readonly string _session = "Identified";
        private readonly string _inventoryManager = "IManager";
        private readonly string _cart = "ShoppingCart";
        private readonly string _inventory = "Inventory";
        private readonly string _inventoryCount = "InventoryCount";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session[_session]==null)
            {
                InventoryManagerGenerator generator = new InventoryManagerGenerator();
                Session[_inventoryManager] = generator.InventoryManager;
                Session[_inventory] = generator.Inventory;
                Session[_inventoryCount] = generator.InventoryCount;
                Session[_cart] = new ShoppingCart();
            }
            List<KeyValuePair<string, int>> inventoryCount = (List<KeyValuePair<string, int>>)Session[_inventoryCount];
            GridPanel.DataSource = inventoryCount;
            GridPanel.DataBind();
        }

        protected void AddToCart(object sender, EventArgs e)
        {
            //FieldInfo field = (sender.GetType()).GetField("DataItemContainer");
            //FieldInfo field1 = (field.GetType()).GetField("Cells[0].Text");
        }
    }
}