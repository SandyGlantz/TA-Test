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

            // ========= My original version (works!)  ========= 
            /*


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

        
            */




            // ========= Instructor solution notes  ========= 
            /*
            1. Added image with ID resultImage

            2. Used:
            if (pencilRadioButton.Checked)
            {  resultImage.ImageUrl = "pencil.png";  }

            3. Combined Below:
            */

            
            resultLabel.Text = "";
            resultImage.Visible = false;
            pencilImageButton.Visible = false;
            penImageButton.Visible = false;
            iphoneImageButton.Visible = false;
            ipadImageButton.Visible = false;



            if (pencilRadioButton.Checked)
            {  resultLabel.Text = "You picked Pencil and paper.  ";
                resultImage.Visible = true;
                resultImage.ImageUrl = "pencil.png";  }

            else if (penRadioButton.Checked)
            {  resultLabel.Text = "You picked Pen and paper.  ";
                resultImage.Visible = true;
                resultImage.ImageUrl = "pen.png";  }

            else if (iphoneRadioButton.Checked)
            {  resultLabel.Text = "You picked the iPhone :-)  ";
                resultImage.Visible = true;
                resultImage.ImageUrl = "phone.png";  }

            else if (ipadRadioButton.Checked)
            {  resultLabel.Text = "You picked the iPad :-)  ";
                resultImage.Visible = true;
                resultImage.ImageUrl = "tablet.png";  }

            else 
            {  resultLabel.Text = 
              "Please choose one - even if you take notes in your head.  ";
            }



            // ========= Final Notes ==========

        /* 
 
         *  My original code had fewer lines.
         *  imageButton: when placed side by side defaults to 
              a single position on the output screen (a good thing).
         *  I could control the iage sizing using the imageButton version - 
              without editing the source file. (also a good thing)

        */







}
}
}
 