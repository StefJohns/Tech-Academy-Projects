using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace battleForXMEN
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";
            int largeNumber = 0;
            int smallNumber = 0;
            
            for (int index = 0; index < names.Length; index++)
            {
                if (numbers[index] > numbers[largeNumber])
                {
                    largeNumber = index;
                }
                if (numbers[index] < numbers[smallNumber])
                {
                    smallNumber = index;
                }
              
            }
            result = String.Format("Most battles belong to: {0} (Value: {1})", names[largeNumber], numbers[largeNumber]);
            result += String.Format("<br />Least battles belong to: {0} (Value: {1})", names[smallNumber], numbers[smallNumber]);
            resultLabel.Text = result;
        }
    }
}