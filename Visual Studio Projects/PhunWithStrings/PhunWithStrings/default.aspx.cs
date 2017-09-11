using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhunWithStrings
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1. Reverse your name
            string name = "Stefon Johns";
            string nameReversed = ReverseName(name);
            resultLabel.Text = nameReversed;

            // 2. Reverse this sequence:
            //string names = "Luke,Leia,Han,Chewbacca";
            string names = "Luke,Leia,Han,Chewbacca";
            string[] starWarsOne = names.Split(',');
             string result = "";
             for (int s = starWarsOne.Length - 1; s >= 0; s--)
             {
                 result += starWarsOne[s] + ",";
             }
             result = result.Remove(result.Length - 1, 1);
             resultLabel.Text = result;
             

            // 3. Use the sequence to create ascii art:
            string[] mainCast = names.Split(',');
            string result = "";
            for (int l = 0; l < mainCast.Length; l++)
            {
                int leftPad = (14 - mainCast[l].Length) / 2;
                string temp = mainCast[l].PadLeft(mainCast[l].Length + leftPad, '*');
                result += temp.PadRight(14, '*');
                result += "<br/>";
                }
            resultLabel.Text = result;

            // 4. Solve this pouzle
            //string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            //Now is the time for all good men to come to the aid of their country.

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            string result = "";
            int index = puzzle.IndexOf("remove-me");
            result = puzzle.Remove(index, 9).Replace("Z", "T").ToLower().Replace("now", "Now");
            resultLabel.Text = result;

        }

        public static string ReverseName(string name)
        { // method for reversing name
            // create a character array with a new array of the characters length in the variable name
            char[] chars = new char[name.Length];
            for (int a = 0, b = name.Length - 1; a <= b; a++, b--)
            {
                chars[a] = name[b];
                chars[b] = name[a];
            }
            return new string(chars);
        }
    }
}