using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_036_Classes_HeroMnstr_pt1_final
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Cat"; 
            hero.Health = 100;  
            hero.DamageMax = 20;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Dog";  
            monster.Health = 100;  
            monster.DamageMax = 20; 
            monster.AttackBonus = false; 

            // this was my 1 round battle that didn't work
            //int heroAttack = monster.Health - hero.Defend(damage);
            //int monsterAttack = hero.Health - monster.Defend(damage);

            //solution:
            int damage = hero.Attack();
            monster.Defend(damage);

            damage = monster.Attack();
            hero.Defend(damage);          


            printStats(hero);
            printStats(monster);
            // added in to separate rounds (future)
            resultLabel.Text += "<br /><br />";
        }




        private void printStats(Character character)
        {
            // solution used ToString AND string.Format ???
            resultLabel.Text += string.Format("{0} health is: {1}, max damage is {2}," +
                " and bonus attack is {3}<br />", character.Name, character.Health,
                character.DamageMax, character.AttackBonus);
        }

    }







    class Character
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMax { get; set; }
            //LOL - thought AttackBonus was an additional amount & set as int
            public bool AttackBonus { get; set; }


            public int Attack()
            {   
                Random rDamage = new Random();

                // returns 1-20 (20 set as Max)
                int damage = rDamage.Next(1, 21);
                //solution used:
                //int damage = rDamage.Next(this.DamageMaximum);
                return damage;
            }


            public void Defend(int damage)
            {   
                // deducts damage from character Health
                int charHealth = this.Health - damage;
                this.Health -= charHealth;
                //solution used:
                //this.Health -= damage;
            }



        }
    }

