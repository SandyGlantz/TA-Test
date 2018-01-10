using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_030
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int heroHealth = 50;
            int monsterHealth = 50;

            displayBattleHeader();

            // Hero gets first attack 
            monsterHealth = performAttack(monsterHealth, 10, "Cute Kittens", "Bad Dog");

            while (heroHealth > 0 && monsterHealth > 0)
            {
                displayRoundHeader();

                // battle ensues here
                heroHealth = performAttack(heroHealth, 10, 
                    "Bad Dog", "Cute Kittens");
                monsterHealth = performAttack(monsterHealth, 10, 
                    "Cute Kittens", "Bad Dog");               
            }
            displayResult(heroHealth, monsterHealth);
        }



        // Page headline
        private void displayBattleHeader()
        {  resultLabel.Text += 
                "<h3>Battle Between the Hero (super cute kittens)" 
                + " and the Monster (bad dog)</h3>";  }



        // shows clean way to delineate between attacks
        private void displayRoundHeader()
        {  resultLabel.Text += "<hr /><p>Round begins ...</p>";  }



        //  methodology for battle 
        //  see notes below why random sits here
        Random random = new Random();
        private int performAttack(int defenderHealth, int attackerDamageMax, 
            string attackerName, string defenderName)
        {
            // the line below moved to outside of method to create (better) random
            //  random determined using base ("seed value") 
            //     of (computer) time (so not truly random)
            //  when inside it pulls the seed repeatedly,
            //     uses the same base time and that results in a pattern
            //  moving it outside the method means a different time time each time
            //     because random pulled once, and the .next does "random"
            //     thus, a better random.
            //Random random = new Random();

          
            int damage = random.Next(1, attackerDamageMax);
            defenderHealth -= damage;
            //  To see the damage pattern from having random in the original location:
            //resultLabel.Text += "<hr /><p style='color:red;'>Roll: "
             //   + damage.ToString() + "</p>";

            describeRound(attackerName, defenderName, defenderHealth);
            return defenderHealth;
        }



        // methodology for displaying rounds (attacks) in the game
        private void describeRound(string attackerName, string defenderName, int defenderHealth)
        {
            if (defenderHealth <= 0)
                resultLabel.Text += 
                    String.Format("<br />{0} attacks {1} and vanquishes the {2}.", 
                    attackerName, defenderName, defenderName);
            else
                resultLabel.Text += 
                    String.Format("<br />{0} attacks {1}, leaving {2} with {3} health.", 
                    attackerName, defenderName, defenderName, defenderHealth);
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


//    =======   Method Overloads starts here: (CS-ASP_31)  ========
      // These all have the same name but take different params, aka, Overloads
      //     these all must have different data types (aka "method signature")

      // !!!!!!!!!!! shift control space shows overload options
            

        public void displayMonsterStats(string monsterName, 
                int health, int damageMaximum, double criticalHitChance)
        {  resultLabel.Text += String.Format("<p>{0} Current Stats<br />" + 
            "Health: {1}<br />Damage Max: {2}<br />Critical Hit Chance: {3:P}</p>", 
            monsterName, health, damageMaximum, criticalHitChance);
        }

        public void displayMonsterStats(string monsterName, 
            int health, int damageMaximum)
        {  resultLabel.Text += String.Format("<p>{0} Current Stats<br />" +
            " Health: {1}<br />Damage Max: {2}</p>", 
            monsterName, health, damageMaximum);
        }

        public void displayMonsterStats(string monsterName, 
            int health)
        {  resultLabel.Text += String.Format("<p>{0} Current Stats<br />" + 
            " Health: {1}</p>", monsterName, health);
        }
    }
}