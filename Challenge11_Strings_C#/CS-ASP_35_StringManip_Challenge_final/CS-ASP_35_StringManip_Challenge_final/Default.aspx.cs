using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_35_StringManip_Challenge_final
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

// ============  1.  Reverse your/a name  ============
            //string name = "Bob Tabor"; ... the output s/be:  robaT boB

            string name = "Senge Alexander Sterling, Cat";
            string reversed = "";
            outputLabel.Text = "Challenge, part 1: Reverse a name. <br />" +
                "The name to be reversed: \"Senge Alexander Sterling, Cat\"";

            // *** Favorite!: (but I think we're supposed to use a for statement?)
            reversed = new string(name.Reverse().ToArray());
            outputLabel.Text += "<br /><br />Favorite code solution: &nbsp&nbsp&nbsp&nbsp&nbsp" + reversed;


            // For statement version
            reversed = ""; // clears earlier version
            for (int i = name.Length-1; i>=0 ; i--)
             {   reversed = reversed + name[i];  }
            outputLabel.Text += "<br /><br />For statement solution: &nbsp&nbsp&nbsp&nbsp&nbsp" + reversed;


            // While statement version
            reversed = ""; // clears earlier version
            int len = name.Length - 1;
            while (len>=0)
            {   reversed = reversed + name[len--];  }
            outputLabel.Text += "<br /><br />While statement solution: &nbsp&nbsp&nbsp&nbsp&nbsp" + reversed;




// ============  2.  Reverse this sequence:  ============
            // string names = "Luke,Leia,Han,Chewbacca"; s/be:  Chewbacca,Han,Leia,Luke
            outputLabel.Text += "<br /><br /><br />Challenge, part 2: Reverse names. <br />" +
                "The names to be reversed: \"Luke,Leia,Han,Chewbacca\"<br />";
            
            //approach 1   
            string[] names1 = { "Luke", "Leia", "Han", "Chewbacca" };
            Array.Reverse(names1);
            outputLabel.Text += "<br />Right direction, list is reversed ... for *one* name <br />" ;
            outputLabel.Text += names1[0].ToString() + "<br />" ;

            // approach 2
            outputLabel.Text += "<br />Getting close ... but has a comma at the end<br />" ;
            foreach (string hero in names1)
            { outputLabel.Text += hero + ","; }  // this has a comma at the end
           
            //approach 3
            //these three lines result in no commas at all. :-/
            outputLabel.Text += "<br /><br />Right order, but wrong ... without any commas! <br />" ;
            foreach (string hero2 in names1)
            {   string list = hero2 + ",";
                int index = list.Length -1;
                outputLabel.Text += list.Substring(0, index);       } 
            


// ============  2vB.  Reverse this sequence:  ============
            // string names = "Luke,Leia,Han,Chewbacca"; s/be:  Chewbacca,Han,Leia,Luke

            string names = "Luke,Leia,Han,Chewbacca";
            string[] heroes = names.Split(',');
            Array.Reverse(heroes);
            string reversedNames = String.Join(",", heroes);// this could be set to used reversed above
            outputLabel.Text += "<br /><br />And the winner is!: <br />";
            outputLabel.Text += reversedNames + "<br /><br />" ;




 // ============  3. Use the names from #2 to create ascii art:  ============
            // 14 characters per line .. examples:
            // *****luke***** 
            // **Chewbacca*** 

            outputLabel.Text += "<br />Challenge, part 3: " 
                + "Use names above for ASCII art <br />" +
                "\"Art\" (??) was their wording - not mine ... <br /> ";

            //re-setting the variables
            names = "Luke,Leia,Han,Chewbacca";
            heroes = names.Split(',');// this puts the names back in the specified order

            foreach (var hero in heroes)
            {   int nameLength = hero.Length;
                outputLabel.Text += "<br />" 
                    + hero.PadLeft(((14 -nameLength)/2 +nameLength), '*').PadRight(14, '*');  };





            // ============  4. Solve this puzzle:  ============
            //string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            // not really a puzzle .. s/be: 
            // Now is the time for all good men to come to the aid of their country.

            outputLabel.Text += "<br /><br /><br />Challenge, part 4: " 
                + "Fix this and make it read proper: <br />" +
                "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.<br /> ";

            // and the variable:
            string sentence2fix = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            int selectedTextIndex = sentence2fix.IndexOf("remove-me");

            // this could all be one long line in the output label ... split it up for readability.
            sentence2fix = sentence2fix.Remove(selectedTextIndex, 9).Replace("Z", "T");
            sentence2fix = sentence2fix.ToLower().Remove(0, 1).Insert(0, "N");

            outputLabel.Text += "<br />"
                + sentence2fix;


        }
    }
}
 