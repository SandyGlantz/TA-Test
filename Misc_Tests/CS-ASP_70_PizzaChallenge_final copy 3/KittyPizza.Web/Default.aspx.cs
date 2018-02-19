using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KittyPizza.DTO.Enums;

namespace KittyPizza.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

// would need to reset this to visible=false if the statements are no longer true
        protected void orderButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim().Length ==0)
            {   validationLabel.Text = "Please enter your name.";
                validationLabel.Visible = true;
                return;  }

            if (addressTextBox.Text.Trim().Length == 0)
            {   validationLabel.Text = "Please enter your address :-)";
                validationLabel.Visible = true;
                return;  }

            if (zipTextBox.Text.Trim().Length == 0)
            {   validationLabel.Text = "We know it's a lot to ask for ... but please enter your zip too.";
                validationLabel.Visible = true;
                return;  }

            if (phoneTextBox.Text.Trim().Length == 0)
            {   validationLabel.Text = "We need a phone number too!";
                validationLabel.Visible = true;
                return; }

            try
            {
                var order = buildOrder();
                Domain.OrderManager.CreateOrder(order);
                Response.Redirect("SuccessPage.aspx");
            }
            catch (Exception ex)
            {
                validationLabel.Text = ex.Message;
                validationLabel.Visible = true;
                return;
            }

            
        }


        private PaymentType determinePayment()
        {
            DTO.Enums.PaymentType paymentType;
            if (cashRadioButton.Checked)
            {
                paymentType = DTO.Enums.PaymentType.PurrCash;
            }
            else 
            {  paymentType = DTO.Enums.PaymentType.SnuggleCredit;  }
                       
            return paymentType;
        }


        private CrustType determineCrust()
        {
            DTO.Enums.CrustType crust;
            if (!Enum.TryParse(crustDropDownList.SelectedValue, out crust))
            {
                throw new Exception("Please select a Crust type");
            }
            return crust;
        }


        private DTO.Enums.SizeType determineSize()
        {
            DTO.Enums.SizeType size;
            if (!Enum.TryParse(sizeDropDownList.SelectedValue, out size))

            {
                throw new Exception("Please select a size");
            }
            return size;
        }


        protected void recalculateTotalCost(object sender, EventArgs e)
        {
            if (sizeDropDownList.SelectedValue == String.Empty)  {  return;  }
            if (crustDropDownList.SelectedValue == String.Empty)  {  return;  }
            var order = buildOrder();

            try
            {
                totalLabel.Text = "<br/>" + Domain.PizzaPriceManager.CalculateCost(order).ToString("C");
                // used this to verify there was a value coming through on crust (there is)
                // totalLabel.Text += "<br/>" + crustDropDownList.SelectedValue.ToString();

                // tried this to clear the validation field once the req'd info was in
                // it did NOT work
                validationLabel.Text = "";
            }
            catch (Exception)
            {    //"swallow"  ... ignore the error
            }

        }


        private DTO.OrderDTO buildOrder()
        {
            var order = new DTO.OrderDTO();

            order.Size = determineSize();
            order.Crust = determineCrust();
            order.PaymentType = determinePayment();
            order.Mouse = mouseCheckBox.Checked;
            order.Goldfish = goldfishCheckBox.Checked;
            order.Catnip = catnipCheckBox.Checked;
            order.Grass = grassCheckBox.Checked;
            order.Name = nameTextBox.Text;
            order.Address = addressTextBox.Text;
            order.Zip = zipTextBox.Text;
            order.Phone = phoneTextBox.Text;

            return order;
        }

    }
}