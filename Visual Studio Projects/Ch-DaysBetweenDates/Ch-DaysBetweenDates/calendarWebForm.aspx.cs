using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch_DaysBetweenDates
{
    public partial class calendarWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime firstDate = dateOne.SelectedDate;
            DateTime secDate = dateTwo.SelectedDate;

            int days = (firstDate.DayOfYear >= secDate.DayOfYear) ? firstDate.DayOfYear - secDate.DayOfYear : secDate.DayOfYear - firstDate.DayOfYear;


            resultLabel.Text = days.ToString();
        }
    }
}