using PapaBobs.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs.Web
{
    public partial class OrderManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        protected void ordersGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = ordersGridView.Rows[index];
            var value = row.Cells[1].Text.ToString();

            var orderId = Guid.Parse(value);
            Domain.OrderManager.CompleteOrder(orderId);
            RefreshGridView();
        }
        private void RefreshGridView()
        {
            var orders = Domain.OrderManager.GetOrders();
            ordersGridView.DataSource = orders;
            ordersGridView.DataBind();
        }
    }
}