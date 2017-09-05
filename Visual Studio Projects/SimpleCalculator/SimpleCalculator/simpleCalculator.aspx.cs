using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleCalculator
{
    public partial class simpleCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {   //variables need to be assigned to the textBox
            string a = oneTextBox.Text;
            string b = twoTextBox.Text;
            //textBox variables converted to int
            double aNumber = double.Parse(a);
            double bNumber = double.Parse(b);
            //to keep numbers eligible for decimal points, double must be added to the operands of the addResult variable
            double addResult = aNumber + bNumber;
            //convert the integer back into a string for the resultLabel
            resultLabel.Text = addResult.ToString();

        }

        protected void subButton_Click(object sender, EventArgs e)
        {
            
            string c = oneTextBox.Text;
            string d = twoTextBox.Text;
            double cNumber = double.Parse(c);
            double dNumber = double.Parse(d);
            double subResult = cNumber - dNumber;
            resultLabel.Text = subResult.ToString();
        }

        protected void multButton_Click(object sender, EventArgs e)
        {
            string g = oneTextBox.Text;
            string f = twoTextBox.Text;
            double gNumber = double.Parse(g);
            double fNumber = double.Parse(f);
            double multResult = gNumber * fNumber;
            resultLabel.Text = multResult.ToString();
        }

        protected void divdButton_Click(object sender, EventArgs e)
        {
            string h = oneTextBox.Text;
            string i = twoTextBox.Text;
            double hNumber = double.Parse(h);
            double iNumber = double.Parse(i);
            double divdResult = hNumber * iNumber;
            resultLabel.Text = divdResult.ToString();
        }
    }
}