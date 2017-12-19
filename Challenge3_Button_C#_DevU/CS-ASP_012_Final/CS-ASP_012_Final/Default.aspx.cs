using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_012_Final
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {



            resultLabel.Text = "";
            pencilImageButton.Visible = false;
            penImageButton.Visible = false;
            iphoneImageButton.Visible = false;
            ipadImageButton.Visible = false;


            if (pencilRadioButton.Checked)
            {  resultLabel.Text = "You picked Pencil and paper.  ";
                pencilImageButton.Visible = true;  }

            else if (penRadioButton.Checked)
            {  resultLabel.Text = "You picked Pen and paper.  ";
                penImageButton.Visible = true;  }

            else if (iphoneRadioButton.Checked)
            {  resultLabel.Text = "You picked the iPhone :-)  ";
                iphoneImageButton.Visible = true;  }

            else if (ipadRadioButton.Checked)
            {  resultLabel.Text = "You picked the iPad :-)  ";
                ipadImageButton.Visible = true;  }


            else 
            {  resultLabel.Text = 
              "Please choose one - even if you take notes in your head.  ";
            }

        }
    }
}