using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   // Requirements:
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast",
                "Phoenix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";



            //   ==========  My solution  ==========  
            //   ... works great, other options below
            ///*
            for (int i = 0; i < numbers.Length; i++)
            {
                int warMonger = numbers.Max();
                int mongerIndex = System.Array.IndexOf(numbers, warMonger);
                string mongerName = names[mongerIndex];

                int pacifist = numbers.Min();
                int patsyIndex = System.Array.IndexOf(numbers, pacifist);
                string patsyName = names[patsyIndex];

                result = String.Format("Most battles are done by {0}. (Value: {1})" +
                        "<br />The fewest battles are done by {2}. (Value: {3})",
                        mongerName, warMonger, patsyName, pacifist);

                    resultLabel.Text = result;
              }
             
               //*/


            //   ==========  Best solution (IMO)  ==========  
            //   ... works great, from comments section via another student
            /*
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers.Max())
                {  result = String.Format("Most battles are fought by {0}. " + 
                    "(Values: {1}) <br />", names[i], numbers[i]); }

                if (numbers[i] == numbers.Min())
                {  result += String.Format("The fewest battles are fought by {0}. " + 
                    "(Values: {1}) <br />", names[i], numbers[i]);
                }

                resultLabel.Text = result;
             }
               */



            //   ==========  Instructor solution  ==========  
            //   ... works great, not my favorite; 
            /*
            int largestNumberIndex = 0;
            int smallestNumberIndex = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] > numbers[largestNumberIndex])
                { largestNumberIndex = i; }

                if (numbers[i] < numbers[smallestNumberIndex])
                { smallestNumberIndex = i; }
            }

            result = String.Format("Most battles are fought by {0}. (Value: {1})<br />",
                names[largestNumberIndex], numbers[largestNumberIndex]);
            result += String.Format("The fewest battles are fought by {0}. (Value: {1})",
                names[smallestNumberIndex], numbers[smallestNumberIndex]);

            resultLabel.Text = result;
            */







        }
    }
}
