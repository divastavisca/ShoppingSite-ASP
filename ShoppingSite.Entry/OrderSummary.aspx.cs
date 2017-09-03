using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingSite.Entry
{
    public partial class OrderSummary : System.Web.UI.Page
    {
        private readonly string _container = "CartContainer";
        private readonly string _totalPrice = "CartReady";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[_totalPrice] != null)
            {
                Dictionary<string, int> items = (Dictionary<string, int>)Session[_container];
                OrderRef.Text = Guid.NewGuid().ToString();
                OrderAmount.Text = Session[_totalPrice].ToString();
                foreach(KeyValuePair<string,int>item in items)
                {
                    OrderList.Text = OrderList.Text + ", ("+item.Key+") X "+item.Value;
                }
            }
            else Response.Redirect("Home.aspx");
        }
    }
}