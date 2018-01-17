using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImagesTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Random getRandomImage = new Random();

        protected void click4RandImageButton_Click(object sender, EventArgs e)
        {
            string[] imageChoices = new string[6] { "Bar", "Bell", "Cherry", "Clover", "Diamond", "Horseshoe" };

            Random getRandomImage = new Random();
            Image1.ImageUrl = "Images/" + imageChoices[getRandomImage.Next(6)] + ".png";
            Image2.ImageUrl = "Images/" + imageChoices[getRandomImage.Next(6)] + ".png";
            Image3.ImageUrl = "Images/" + imageChoices[getRandomImage.Next(6)] + ".png";

        }
    }
}