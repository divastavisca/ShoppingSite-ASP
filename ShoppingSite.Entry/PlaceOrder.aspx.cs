using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingSite.Entry
{
    public partial class PlaceOrder : System.Web.UI.Page
    {
        private readonly string _session = "Identified";
        private readonly string _inventoryManager = "IManager";
        private readonly string _cart = "ShoppingCart";
        private readonly string _inventory = "Inventory";
        private readonly string _inventoryMap = "InventoryMap";
        private readonly string _productMap = "ProductMap";
        private readonly string _productPrice = "ProductPrice";
        private readonly string _container = "CartContainer";
        private readonly string _totalPrice = "CartReady";
        protected void Page_Load(object sender, EventArgs e)
        {
            Pay.Visible = false;
            if(Session[_container]==null)
            {
                OrderSummary.Text = "Invalid order request";
            }
            else
            {
                OrderSummary.Text = "Thank you for shopping with us please pay " + Session[_totalPrice].ToString()+".";
                Pay.Visible = true;
                Pay.Text = "Pay " + Session[_totalPrice].ToString();
            }
        }
    }
}