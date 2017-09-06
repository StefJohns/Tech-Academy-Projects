using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace spyAssignment
{
    public partial class EpicSpiesAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Now.Date;
                Calendar2.SelectedDate = DateTime.Now.Date.AddDays(14);
                Calendar3.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
            
            
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            TimeSpan lengthAssignment = Calendar3.SelectedDate.Subtract(Calendar2.SelectedDate);
            double totalBudget = lengthAssignment.TotalDays * 500.0;
            

            
            if (lengthAssignment.TotalDays > 21)
            {
                totalBudget += 1000.0;
            }

            assignLabel.Text = String.Format("Agent {0}, has been authorized for '{1}' Assignment. Budget Total for Mission: {2:C}", TextBox1.Text, TextBox2.Text, totalBudget);

            TimeSpan betweenAssignments = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate);
            
            if (betweenAssignments.TotalDays < 14)
            {
                assignLabel.Text = "ERROR: You must allow two weeks bewtween assignments.";
            }
        }

        protected void buttonClear_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }
    }
}