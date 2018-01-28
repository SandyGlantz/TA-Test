using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonster
{

    public class Dice
    {
        public int Sides { get; set; }

        //multiple dice = di ... r = random
        Random rDi = new Random();

        public int Roll()
        // added one so the points could go the full amount of DamageMax.
        { return rDi.Next(1, this.Sides + 1); }

//  ===============  end Dice class  ===============
    }





    public class Character
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
}
