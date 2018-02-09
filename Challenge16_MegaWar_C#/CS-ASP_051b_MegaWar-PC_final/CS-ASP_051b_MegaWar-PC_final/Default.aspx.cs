using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_051b_MegaWar_PC_final
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {







// This was to test the cards were dealt out randomly

            Game game = new Game("Kitten", "Puppy");
            resultLabel.Text = "<br/><br/><strong> We start by dealing out the cards in the deck ...</strong>";
            resultLabel.Text += game.Play();



// This was when Deck was set to public and used to test the cards output the right number by suit
            /*
            Deck deck = new Deck();
            foreach (var card in deck._deck)
            {
                resultLabel.Text += "<br/>" + card.Kind + " of " + card.Suit;
            }
            */

        }   // end okButton
    }       // end Default
}           // end namespace