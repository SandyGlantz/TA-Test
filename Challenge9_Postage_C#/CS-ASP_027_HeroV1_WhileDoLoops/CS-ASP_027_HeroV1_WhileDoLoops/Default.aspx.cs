using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_027
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            int heroHealth = 30;
            int monsterHealth = 30;

            string result = "";

            // Hero gets bonus first attack 
            monsterHealth -= random.Next(1, 10);

            int round = 0;
            result += "<br />Round: " + round;
            result += String.Format("<br />Hero attacks first, leaving monster with {0} health.", 
                monsterHealth);


            // Battle logic 

            /*   ===== original =====
            while (heroHealth > 0 && monsterHealth > 0)
            {
                int heroDamage = random.Next(1, 10);
                int monsterDamage = random.Next(1, 10);

                monsterHealth -= heroDamage;
                heroHealth -= monsterDamage;

                result += "<br />Round: " + ++round;
                result += String.Format("<br />Hero causes {0} damage, leaving monster with {1} health.", heroDamage, monsterHealth);
                result += String.Format("<br />Monster causes {0} damage, leaving hero with {1} health.", monsterDamage, heroHealth);
            }
             */

            //   =====  v.2;  using do in the while loop
            // allows monster to get a strike back regardless of outcome on the first strike.
            do
            {
                int heroDamage = random.Next(1, 10);
                int monsterDamage = random.Next(1, 10);

                monsterHealth -= heroDamage;
                heroHealth -= monsterDamage;

                // putting the ++ in front keeps from two first round being round 0
                result += "<br />Round: " + ++round;
                result += String.Format("<br />Hero causes {0} damage, leaving monster with {1} health.", heroDamage, monsterHealth);
                result += String.Format("<br />Monster causes {0} damage, leaving hero with {1} health.", monsterDamage, heroHealth);  
            } while (heroHealth > 0 && monsterHealth > 0);


            // this gives edge to Hero - when reversed order gives advantage to monster
            if (monsterHealth > 0)
            {  result += "<br /> Monster wins!";  }
            else
            {  result += "<br /> Hero wins!";  }


            resultLabel.Text = result;

        }
    }
}