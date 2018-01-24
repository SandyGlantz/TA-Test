using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_036_Classes_HeroMnstr_pt2_final

{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Cute Kittens";
            hero.Health = 50;
            hero.DamageMax = 20;
            hero.AttackBonus = true;

            Character monster = new Character();
            monster.Name = "Bad Dog";
            monster.Health = 50;
            monster.DamageMax = 20;
            monster.AttackBonus = true;

            //this brings the Dice class and its methods into this class.
            Dice dice = new Dice();


            // setting a baseline ... 
            // *repeating* bonus T/F and DamageMax is irrelevant when it doesn't change.
            resultLabel.Text = "<h3>Our game begins with the Adorable Kittens " +
                "facing an evil Bad Dog ...</h3><br /><br />";
            printStartStats(hero);
            printStartStats(monster);
            resultLabel.Text += "<br /> <hr color=\"blue\" width= \"60%\"> <br />";

            // bonus round version 1 ...
            if (hero.AttackBonus)
            {
                int damage = hero.Attack(dice);
                monster.Defend(damage);
                resultLabel.Text += string.Format("The {0} wake up from their nap" +
                    " and want to play, scoring {1} bonus points! <br />", hero.Name, damage);
            }

            if (monster.AttackBonus)
            {
                int damage = monster.Attack(dice);
                hero.Defend(damage);
                resultLabel.Text += string.Format("{0} doesn't want to play, " +
                    "but gets {2} bonus points anyway.<br /> <br />",
                    monster.Name, hero.Name, damage);
            }

            printStats(hero);
            printStats(monster);
            // added this in to separate rounds:
            resultLabel.Text += "<br /><br />Bonus round is over." +
                " Wasn't that meaningful? <br /><br />" +
                "<hr color=\"blue\" width= \"60%\"><br /><br />";
       




    
            // ending to the game
            while (hero.Health > 0 && monster.Health > 0)
            {
                int damage = hero.Attack(dice);
                monster.Defend(damage);
                resultLabel.Text += string.Format("The {0} cuddle and purr attack" +
                    " scores {1} points! <br />", hero.Name, damage);

                damage = monster.Attack(dice);
                hero.Defend(damage);
                resultLabel.Text += string.Format("{0} is grumpy and growls at the " +
                    "innocent {1}, causing {2} points damage.<br /> <br />",
                    monster.Name, hero.Name, damage);

                printStats(hero);       printStats(monster);
                // added this in to separate rounds:
                resultLabel.Text += "<br /><br /><br /><br />";
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
            resultLabel.Text += string.Format("{0} new score is: {1} ... ",
                character.Name, character.Health);
        }


        private void finalScore(Character contestant, Character opponent)
        {
            if (contestant.Health <= 0 && opponent.Health <= 0)
                resultLabel.Text += "They were both distracted by squirrels, "
                    + "and played together nicely the rest of the day.";
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

        //multiple dice = di ... r = random
        Random rDi = new Random();

        public int Roll()
            // added one so the points could go the full amount of DamageMax.
        { return rDi.Next(1, this.Sides + 1);     }

//  ===============  end Dice class  ===============
    }





    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMax { get; set; }
        public bool AttackBonus { get; set; }


        public int Attack(Dice dice)
        {
            dice.Sides = this.DamageMax;
            int damage = dice.Roll();
            return damage;
        }


        public void Defend(int damage)
        { this.Health -= damage; }



//  ===============  end Character class  ===============
    }

//  ===============  end  namespace  ===============
}