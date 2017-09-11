using System;

namespace megaLotterySlots
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] reels = new string[] { spinTheReel(), spinTheReel(), spinTheReel() };
                displayReelImage(reels);
                ViewState.Add("PlayerMoney", 100);
                displayPlayMoney();
            }
        }

        protected void lever_Button_Click(object sender, EventArgs e)
        {
            int bet = 0;
            if (!int.TryParse(BetBox.Text, out bet)) return;

            int totalWinnings = pullLever(bet);
            displayResult(bet, totalWinnings);
            adjustPlayerMoney(bet, totalWinnings);
            displayPlayMoney();
        }

        private void adjustPlayerMoney(int bet, int totalWinnings)
        {
            int playersMoney = int.Parse(ViewState["PlayerMoney"].ToString());
            playersMoney -= bet;
            playersMoney += totalWinnings;
            ViewState["PlayerMoney"] = playersMoney;
        }

        private int pullLever(int bet)
        {
            string[] reels = new string[] {spinTheReel(), spinTheReel(), spinTheReel()};
            displayReelImage(reels);
            int multiplier = evaluateReelSpin(reels);
            return bet * multiplier;
        }

        private int evaluateReelSpin(string[] reels)
        {
            if (IsBar(reels)) return 0;
            if (IsJackpot(reels)) return 100;
            int multiplier = 0;
            if (IsWinner(reels, out multiplier)) return multiplier;
            else return 0;
        }

        private bool IsWinner(string[] reels, out int multiplier)
        {
            multiplier = GetMultiplier(reels);
            if (multiplier > 0) return true;
            else return false;
        }

        private bool IsBar(string[] reels)
        {
            if (reels[0] == "Bar" || reels[1] == "Bar" || reels[2] == "Bar")
                return true;
            else return false;            
        }

        private bool IsJackpot(string[] reels)
        {
            if (reels[0] == "Seven" && reels[1] == "Seven" && reels[2] == "Seven")
                return true;
            else return false;
        }

        private int CherryTotal(string[] reels)
        {
            int cherryCount = 0;
            if (reels[0] == "Cherry") cherryCount++;
            if (reels[1] == "Cherry") cherryCount++;
            if (reels[2] == "Cherry") cherryCount++;
            return cherryCount;
        }

        private int GetMultiplier(string[] reels)
        {
            int cherryCount = CherryTotal(reels);
            if (cherryCount == 1) return 2;
            if (cherryCount == 2) return 3;
            if (cherryCount == 3) return 4;
            else return 0;                
        }

        private string spinTheReel()
        {
            string[] images = new string[]
                { "Bar", "Bell", "Cherry", "Clover",
                    "Diamond", "HorseShoe", "Lemon", "Orange",
                    "Plum", "Seven", "Strawberry", "Watermelon"};
            return images[random.Next(11)];
        }

        private void displayPlayMoney()
        {
            moneyLabel.Text = String.Format("Player's Money : {0:C}", ViewState["PlayerMoney"]);
        }

        private void displayReelImage(string[] reels)
        {
            reelBox1.ImageUrl = "/Images/" + reels[0] + ".png";
            reelBox2.ImageUrl = "/Images/" + reels[1] + ".png";
            reelBox3.ImageUrl = "/Images/" + reels[2] + ".png";
        }
        private void displayResult(int bet, int totalWinnings)
        {
            if (totalWinnings > 0)
            {
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", bet, totalWinnings);
            }
            else resultLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time...", bet);
        }
    }
}