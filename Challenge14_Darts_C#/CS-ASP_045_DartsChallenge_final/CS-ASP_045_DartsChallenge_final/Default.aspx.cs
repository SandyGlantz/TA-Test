using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Darts;


namespace CS_ASP_045_DartsChallenge_final
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {

            //access the outside class
            Players player = new Players();

            // gets the result string, which can go into the local resultLabel
            player.Gamers();

            resultLabel.Text += player.Winner + "<br/>";

        }
    }
}