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
        double betAmount, betResult, startingBalance, playerBalance;

        //Random works up here - but also works in DisplayRandomImages
        // ... since it's only used there I thought it better to keep the code together
        //Random getRandomSlotImage = new Random();


//  ============   priming the pump ... err...page ...  ============ 
        public void Page_Load(object sender, EventArgs e)
        {
           if (!Page.IsPostBack)
            {   /*
                ViewState.Add("startingBalance", 100);
                playerBalanceLabel.Text = string.Format("Your starting balance is {0:C}", 
                    ViewState["startingBalance"]);       */

                startingBalance = 100.0;
                playerBalance = startingBalance;
                displayRandomImages();
                playerBalanceLabel.Text = String.Format("{0:N2}", playerBalance);
            }
        }


//  ============   Image array for random selection   ============  
        private void displayRandomImages()
        {   
            string [] slotImages = new string[12]  
            {   "Watermelon","Strawberry", "Seven", "Plum", "Orange", "Lemon",
                "HorseShoe", "Diamond", "Clover", "Cherry", "Bell", "Bar" };

            // This doesn't return unrandom or duplicates ... each image separate random
            Random getRandomSlotImage = new Random();
            leftImage.ImageUrl = "Images/" + slotImages[getRandomSlotImage.Next(12)] + ".png";
            middleImage.ImageUrl = "Images/" + slotImages[getRandomSlotImage.Next(12)] + ".png";
            rightImage.ImageUrl = "Images/" + slotImages[getRandomSlotImage.Next(12)] + ".png";
        }


//  ============   User clicks the "make bet" button and the process starts   ============  
        public void makeBetButton_Click(object sender, EventArgs e)
        {
            updatePlayerBalance(out playerBalance);
            clearPlayerBalanceLabel();
            clearBetOutcomeLabel();
            displayRandomImages();
            confirmBetEntered();                     
        }


//  ============   update player balance   ============
        private void updatePlayerBalance(out double playerBalance)
        {  playerBalance = double.Parse(playerBalanceLabel.Text);  }


//  ============   clearing - makes sure an old result isn't still on screen   ============ 
        private void clearBetOutcomeLabel()
        { betOutcomeLabel.Text = ""; }
        private void clearPlayerBalanceLabel()
        { betOutcomeLabel.Text = ""; }
        private void clearBetAmount()
        { amountBetTextBox.Text = ""; }


//  ============  Was a valid bet number amount actually entered?   ============  
        private void confirmBetEntered()
        {
            // is anything at all in the amount bet text box?
            if (amountBetTextBox.Text.Trim().Length == 0)
            { betOutcomeLabel.Text = "Please place a bet amount.";
                return; }

            // is what is typed an int(double)? Separate message for that ...
            else if (!Double.TryParse(amountBetTextBox.Text, out betAmount))
            { betOutcomeLabel.Text = "Please enter only numbers";
                return; }

            else  getBetAmount();
        }


//  ============   What is the amount bet?   ============  
        private void getBetAmount()
        {
            if (Double.TryParse(amountBetTextBox.Text, out betAmount))
            {  loanShark();  }
        }


//  ============   Can the bettor cover the amount bet?   ============  
        private void loanShark()
        {
            if (betAmount > playerBalance)
            {
                betOutcomeLabel.Text = "No loan sharks here.  Place an amount within your balance.";
                return;
            }
            else
            {
                betOutcomeLabel.Text = string.Format("Your bet of {0:N2} is within your balance of {1:N2}",
                    betAmount, playerBalance);               
                checkForBars();
            }
        }


//  ============   Now that we have a player ... does the spin rule them out with bars?   ============  
        private void checkForBars()
        {
            if (leftImage.ImageUrl == "Images/Bar.png" ||
                middleImage.ImageUrl == "Images/Bar.png" ||
                rightImage.ImageUrl == "Images/Bar.png")
            {  calcLosses();  }

            else  checkForSevens();  
        }


//  ============   If the bars weren't Game Over; what about JACKPOT three sevens?   ============  
        private void checkForSevens()
        {
            if (leftImage.ImageUrl == "Images/Seven.png" &&
                middleImage.ImageUrl == "Images/Seven.png" &&
                rightImage.ImageUrl == "Images/Seven.png")
            {
                betResult = betAmount * 100;
                calcWinnings();
            }

            else  checkForCherries();
        }


//  ============   Did they get cherries and make money??   ============  
        private void checkForCherries()
        {
            //  UGH.  WAY too big/long. NOT DRY either ...
            // splitting into 1 cherry vs. 2 or 3 cherries seems more error-prone

            //Three(3) Cherries quadruples your bet!
            if (leftImage.ImageUrl == "Images/Cherry.png" &&
                middleImage.ImageUrl == "Images/Cherry.png" &&
                rightImage.ImageUrl == "Images/Cherry.png")
            {
                betResult = betAmount * 4;
                calcWinnings();
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
                calcWinnings();
            }

            //One (1) Cherry gets your bet doubled
            else if (leftImage.ImageUrl == "Images/Cherry.png" ||
                middleImage.ImageUrl == "Images/Cherry.png" ||
                rightImage.ImageUrl == "Images/Cherry.png")
            {
                betResult = betAmount * 2;
                calcWinnings();
            }
              
            else  calcLosses();
        }


//  ============   Output losses   ============  
        private void calcLosses()
        {
            betOutcomeLabel.Text = String.Format("Sorry Charlie, you lost ${0:N2}", betAmount);
            betResult = betAmount * (-1);
            calcPlayerBalance();
        }


//  ============   Output winnings   ============  
        private void calcWinnings()
        {
            betOutcomeLabel.Text = String.Format("Congrats! You bet {0:N2} and won {1:N2}",
                betAmount, betResult);
            calcPlayerBalance();
        }


//  ============   Calculate the player's balance   ============  
        private void calcPlayerBalance()
        {

            //playerBalance = double.Parse(ViewState["startingBalance"].ToString());
            //playerBalance = playerBalance + betResult;
            //ViewState["startingBalance"] = playerBalance;

            playerBalance = playerBalance + betResult;
            playerBalanceLabel.Text = String.Format("{0:N2}", playerBalance);
            return;
        }
    }
}