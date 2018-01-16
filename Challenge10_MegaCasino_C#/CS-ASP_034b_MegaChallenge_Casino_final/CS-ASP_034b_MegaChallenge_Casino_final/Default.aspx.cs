using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_034b_MegaChallenge_Casino_final
{
    public partial class Default : System.Web.UI.Page
    {

//  ============   setting primary variables   ============   
        double betAmount, betResult;
        double playerBalance = 0; // or should this be 100??




//  ============   priming the pump ... err...page ...  ============ 
        public void Page_Load(object sender, EventArgs e)
        {
            ViewState.Add("balance", playerBalance);
            playerBalance = 100.0;

            if (!Page.IsPostBack)
            {
                //playerBalance = 100.0;
                //ViewState.Add("balance", playerBalance);
                displayRandomImages();
                playerBalanceLabel.Text = String.Format("Starting player balance is ${0:N2}", playerBalance);
            }
        }





//  ============   Image array for random selection   ============  
        private void displayRandomImages()
        {   
            string [] slotImages = new string[12]  
            { "Images/Watermelon.png","Images/Strawberry.png", "Images/Seven.png",
              "Images/Plum.png", "Images/Orange.png", "Images/Lemon.png",
              "Images/HorseShoe.png", "Images/Diamond.png", "Images/Clover.png",
              "Images/Cherry.png", "Images/Bell.png", "Images/Bar.png" };

            // This isn't returning duplicates ... so left inside method
            Random getRandomSlotImage = new Random();
            leftImage.ImageUrl = slotImages[getRandomSlotImage.Next(0, 12)];
            middleImage.ImageUrl = slotImages[getRandomSlotImage.Next(0, 12)];
            rightImage.ImageUrl = slotImages[getRandomSlotImage.Next(0, 12)];
        }





//  ============   User clicks the "make bet" button and the process starts   ============  
        public void makeBetButton_Click(object sender, EventArgs e)
        {
            clearPlayerBalanceLabel();
            clearBetOutcomeLabel();
            displayRandomImages();
            confirmBetEntered(playerBalance);
                     
        }


//  ============   clearing - makes sure an old result isn't still on screen   ============ 
        public void clearBetOutcomeLabel()
        { betOutcomeLabel.Text = ""; }
        public void clearPlayerBalanceLabel()
        { betOutcomeLabel.Text = ""; }
        public void clearBetAmount()
        { amountBetTextBox.Text = ""; }
    




        //  ============  Was a valid bet number amount actually entered?   ============  
        public void confirmBetEntered(double playerBalance)
        {
            if (amountBetTextBox.Text.Trim().Length == 0)
            { betOutcomeLabel.Text = "Please place a bet amount.";
                return; }

            else if (!Double.TryParse(amountBetTextBox.Text, out betAmount))
            { betOutcomeLabel.Text = "Please enter only numbers";
                return; }

            else
                getBetAmount(playerBalance);
        }



//  ============   What is the amount bet?   ============  
        public void getBetAmount(double playerBalance)
        {
            if (Double.TryParse(amountBetTextBox.Text, out betAmount))
            {
                //playerBalanceLabel.Text = string.Format("This is a test from GetBetAmount" +
                //    " ... You bet {0:N2}", betAmount);
                loanShark(betAmount, playerBalance);
            }
        }



//  ============   Can the bettor cover the amount bet?   ============  
        public void loanShark(double betAmount, double playerBalance)
        {
            if (betAmount > playerBalance)
            {
                betOutcomeLabel.Text = "No loans here.  Place an amount within your balance.";
                return;
            }
            else
            {
                betOutcomeLabel.Text = string.Format("Your bet of {0:N2} is within your balance of {1:N2}",
                    betAmount, playerBalance);
                
                checkForBars(betAmount, playerBalance);
            }
        }



//  ============   Now that we have a player ... does the luck of spin rule them out with bars?   ============  
        public void checkForBars(double betAmount, double playerBalance)
        {

            if (leftImage.ImageUrl == "Images/Bar.png" ||
                middleImage.ImageUrl == "Images/Bar.png" ||
                rightImage.ImageUrl == "Images/Bar.png")

            {
                //betOutcomeLabel.Text = String.Format("Sorry Charlie, there's a bar." +
                //    " You lost ${0:N2}", betAmount);
                //betResult = betResult * (-1);
                calcLosses(betAmount, playerBalance, betResult);
            }

            else
              checkForSevens(betAmount, playerBalance);  
        }





//  ============   If the bars weren't Game Over - what about three sevens?   ============  
        public void checkForSevens(double betAmount, double playerBalance)
        {
            if (leftImage.ImageUrl == "Images/Seven.png" &&
                middleImage.ImageUrl == "Images/Seven.png" &&
                rightImage.ImageUrl == "Images/Seven.png")
            {
                betResult = betAmount * 100;
                calcWinnings(betAmount, playerBalance, betResult);
            }


            else
                checkForCherries(betAmount, playerBalance);
        }


        //  ============   Did they get cherries and make money??   ============  
        public void checkForCherries(double betAmount, double playerBalance)
        {
            //  UGH.  WAY too big/long. NOT DRY either ...
            // splitting into 1 cherry vs. 2 or 3 cherries seems like more error-prone


            //Three(3) Cherries quadruples your bet!
            if (leftImage.ImageUrl == "Images/Cherry.png" &&
                middleImage.ImageUrl == "Images/Cherry.png" &&
                rightImage.ImageUrl == "Images/Cherry.png")
            {
                betResult = betAmount * 4;
                calcWinnings(betAmount, playerBalance, betResult);
            }

            //Two(2) Cherries and your bet is tripled!
            else if (leftImage.ImageUrl == "Images/Cherry.png" &&
                middleImage.ImageUrl == "Images/Cherry.png" ||
                leftImage.ImageUrl == "Images/Cherry.png" &&
                rightImage.ImageUrl == "Images/Cherry.png" ||
                middleImage.ImageUrl == "Images/Cherry.png" &&
                rightImage.ImageUrl == "Images/Cherry.png")
            {
                betResult = betAmount * 3;
                calcWinnings(betAmount, playerBalance, betResult);
            }

            //One (1) Cherry gets your bet doubled
            else if (leftImage.ImageUrl == "Images/Cherry.png" ||
                middleImage.ImageUrl == "Images/Cherry.png" ||
                rightImage.ImageUrl == "Images/Cherry.png")
            {
                betResult = betAmount * 2;
                calcWinnings(betAmount, playerBalance, betResult);
            }
       
        
            else
            calcLosses(betAmount, playerBalance,betResult);
        }




//  ============   Output losses   ============  
        public void calcLosses(double betAmount, double playerBalance, double betResult)
        {
            betOutcomeLabel.Text = String.Format("Sorry Charlie, you lost ${0:N2}", betAmount);

            betResult = betAmount * (-1);
            calcPlayerBalance(playerBalance, betResult);
        }



//  ============   Output winnings   ============  
        public void calcWinnings(double betAmount, double playerBalance, double betResult)
        {
            betOutcomeLabel.Text = String.Format("Congrats! You bet {0:N2} and won {1:N2}",
                betAmount, betResult);
            calcPlayerBalance(playerBalance, betResult);
        }




//  ============   Calculate the player's balance   ============  
        public void calcPlayerBalance(double playerBalance, double betResult)
        {
            //ViewState["balance"] = (double)ViewState["balance"] + betResult;

            playerBalance = playerBalance + betResult;

            playerBalanceLabel.Text = String.Format("Your new balance is {0:N2}", playerBalance);

            return;

        }






    }
}