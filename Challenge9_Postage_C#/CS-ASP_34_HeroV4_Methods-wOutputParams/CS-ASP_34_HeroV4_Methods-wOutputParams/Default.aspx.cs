using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_034
// CS-ASP-034 = Methods with Output Params (Parameters)
//     ... i.e.: double try.parse = returns bool T/F -AND- value parsed
//     ... "out" is the keyword ... similar to "return" 


{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int heroHealth = 50;
            int monsterHealth = 50;

            displayBattleHeader();

            while (heroHealth > 0 && monsterHealth > 0)
            {
                displayRoundHeader();

                // battle logic
                // "out" is the output param key word
                if (defeatEnemy(heroHealth, 10, "Monster", "Hero", out heroHealth))
                    lootEnemy();
            }
            displayResult(heroHealth, monsterHealth);
        }



        // Page headline
        private void displayBattleHeader()
        {  resultLabel.Text += 
                "<h3>Battle Between the Hero (super cute kittens)" 
                + " and the Monster (bad dog)</h3>";  }

        // clean way to delineate between attacks
        private void displayRoundHeader()
        {  resultLabel.Text += "<hr /><p>Round begins ...</p>";  }


        // replaces performAttack - enables T/F to loot opponent
        // is the enemy defeated? = defeatEnemy

        Random random = new Random(); // I moved this here from below (=better random)
        private bool defeatEnemy(int defenderHealth,
            int attackerDamageMax,
            string attackerName,
            string defenderName,
            out int remainingDefenderHealth)
        {
            // Random random = new Random(); //I moved this to top = better random
            int damage = random.Next(1, attackerDamageMax);
            remainingDefenderHealth = defenderHealth - damage;

            if (remainingDefenderHealth <= 0) return true;
            else return false;
        }


        // methodology for displaying rounds (attacks) in the game
        private void describeRound(string attackerName, string defenderName, int defenderHealth)
        {
            if (defenderHealth <= 0)
                resultLabel.Text += String.Format("<br />{0} attacks {1} and vanquishes the {2}.", attackerName, defenderName, defenderName);
            else
                resultLabel.Text += String.Format("<br />{0} attacks {1}, leaving {2} with {3} health.", attackerName, defenderName, defenderName, defenderHealth);
        }


        // methodology for displaying/winning (completing) of the game
        private void displayResult(int heroHealth, int monsterHealth)
        {
            if (heroHealth <= 0)
                resultLabel.Text += "<h3>Bad Dog wins. </h3>";
            else if (monsterHealth <= 0)
                resultLabel.Text += "<h3>The Cute and Adorable Kittens win! </h3>";
            else
                resultLabel.Text += "<h3>They both get distracted by squirrels,"
                    + " and stop fighting each other</h3>";
        }

        private void lootEnemy()
        {  resultLabel.Text += 
                "<p style='color:red;'>" + 
                " The fresh gravy and giblets goes to the victor!</p>";
        }
    }
}