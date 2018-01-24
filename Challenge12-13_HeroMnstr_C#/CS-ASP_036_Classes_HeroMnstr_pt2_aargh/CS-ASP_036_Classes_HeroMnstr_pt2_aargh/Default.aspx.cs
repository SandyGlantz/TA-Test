using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_036_Classes_HeroMnstr_pt2_aargh

{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Cute Kittens";
            hero.Health = 50;
            hero.DamageMax = 20;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Bad Dog";
            monster.Health = 50;
            monster.DamageMax = hero.DamageMax;
            monster.AttackBonus = false;

            Dice diceMax = new Dice();
            //diceMax.Sides = 20; // why hard-code when it's supposed to be the same as the Damage Max?
            diceMax.Sides = hero.DamageMax;


            // setting a baseline ... 
            // *repeating* bonus T/F and DamageMax is irrelevant when it doesn't change.
            resultLabel.Text = "Our game begins with the Adorable Kittens facing an evil Bad Dog...<br /><br />";
            printStartStats(hero);
            printStartStats(monster);
            resultLabel.Text += "<br /> <hr color=\"blue\" width= \"60%\"> <br />";

            while (hero.Health > 0 && monster.Health > 0)
            {
                int damage = hero.Attack(diceMax.Roll());
                monster.Defend(damage);
                resultLabel.Text += string.Format("The {0} cuddly and adorable attack" +
                    " scores {1} points! <br />", hero.Name, damage);

                damage = hero.Attack(diceMax.Roll());
                hero.Defend(damage);
                resultLabel.Text += string.Format("{0} is grumpy and attacks the " +
                    "innocent {1}, causing {2} points damage.<br /> <br />",
                    monster.Name, hero.Name, damage);

                printStats(hero);
                printStats(monster);
                // added this in to separate rounds:
                resultLabel.Text += "<br /><br />";
            }

            finalScore(hero, monster);



//  ===============  end Page_Load  ===============
        }





        private void printStartStats(Character character)
        {
            resultLabel.Text += string.Format("{0}'s starting score is: {1}, " +
                "and the maximum damage inflicted each battle is: {2}."
                + "<br />{0}'s bonus attack availability is {3}.<br /><br />", 
                character.Name, character.Health, 
                character.DamageMax, character.AttackBonus);
        }


        private void printStats(Character character)
        {
            resultLabel.Text += string.Format("{0} new score is: {1}, ",
                character.Name, character.Health);
        }


        private void finalScore(Character contestant, Character opponent)
        {
            if (contestant.Health <= 0 && opponent.Health <= 0)
                resultLabel.Text += "They were both distracted by squirrels, and" 
                    + " live to play another day.";
            else if (contestant.Health <= 0)
                resultLabel.Text += string.Format("{0} won.", opponent.Name);
            else
                resultLabel.Text += string.Format("{0} won.", contestant.Name);
        }


//  ===============  end Default class ... and printing methods  ===============
    }



    class Dice
    {
        public int Sides { get; set; }

        Random rDice = new Random();

        public int Roll()
        {
            int diceAmount = rDice.Next(1, this.Sides);
            return diceAmount;
        }

//  ===============  end Dice class  ===============
    }





    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMax { get; set; }
        public bool AttackBonus { get; set; }


        public int Attack(int diceRoll)
        {
            int damage = diceRoll;
            return damage;
        }


        public void Defend(int damage)
        { this.Health -= damage; }

//  ===============  end Character class  ===============
    }

//  ===============  end  namespace  ===============
}
