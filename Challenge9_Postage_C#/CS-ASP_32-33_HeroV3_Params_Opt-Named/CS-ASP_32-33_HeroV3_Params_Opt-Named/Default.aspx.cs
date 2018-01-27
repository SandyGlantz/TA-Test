using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_032
// CS-ASP-032 = Optional Params (Parameters) 
//     ... defaults set to kick into params if not supplied
//
// CS-ASP-033 = Named Params (Parameters)
//     ... uses name and colons so order doesn't matter
//     ... also allows for skipping optional params
//

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




//   ========  Optional Param version (032) version  ========
                
                heroHealth = performAttack(heroHealth, 10,
                    "Bad Dog", "Cute Kittens");
                monsterHealth = performAttack(monsterHealth, 10,
                    "Cute Kittens", "Bad Dog");
               

                
//   ========  Parameter Names/ Named Params (033) info below  ========
                
                //  this allows skipping of CritcalHit
                //  NOTE: didn't have to name all - just out of order
                //     ... so *all* could be out of order if paramName:provided
                //performAttack(heroHealth, 10, "Bad Dog", 
                //   "Cute Kittens", defenderArmorBonus: 10);
               


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



        //  methodology for battle


//   ========  Optional Parameters (032) info below  ========
//   ========  Also used this block in (033)  ========

        Random random = new Random(); // I moved this here from below (=better random)
        private int performAttack(
            int defenderHealth, 
            int attackerDamageMax,
            string attackerName, 
            string defenderName,
            // added below line as the "optional" param; i.e., default set
            //     intellisense will show opt params in [] part of descript prompt
            double criticalHitChance = .1,
            //  NOTE: opt.param(s) MUST be last
            //  AND you can't supply the ArmorBonus w/o ALSO including the HitChance
            double defenderArmorBonus = 5)
        {
            int damage = random.Next(1, attackerDamageMax);
            defenderHealth -= damage;

            describeRound(attackerName, defenderName, defenderHealth);
            return defenderHealth;
        }
        


        // methodology for displaying rounds (attacks) in the game
        private void describeRound(
            string attackerName, string defenderName, int defenderHealth)
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
    }
}