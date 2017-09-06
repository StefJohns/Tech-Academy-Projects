using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pizzaAndSoftware
{
    public partial class pizzaMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            
            double total;

            if (size1.Checked)
                total = 10.00;
            else if (size2.Checked)
                total = 13.00;
            else total = 16.00;

            if (crust2.Checked)
                total += 2.00;

            total = (topping1.Checked) ? total + 1.50 : total;
            total = (topping2.Checked) ? total + 0.75 : total;
            total = (topping3.Checked) ? total + 0.50 : total;
            total = (topping4.Checked) ? total + 0.75 : total;
            total = (topping5.Checked) ? total + 2.00 : total;

            if ((topping1.Checked && topping3.Checked && topping5.Checked) || (topping1.Checked && topping2.Checked && topping4.Checked))
                total -= 2.00;

            totalLabel.Text = "$" + total.ToString();


        }
    }
}