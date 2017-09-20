using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            if(!TextBoxDataIsValid())
            {
                return;
            }
            var orderDTO = BuildOrder();

            Domain.OrderManager.CreateOrder(orderDTO);
            Response.Redirect("Success.aspx");
        }

        private bool TextBoxDataIsValid()
        {
            if (nameTextBox.Text.Trim().Length == 0)
            {
                TextBoxValidationError("name"); return false;
            }
            else if (zipCodeTextBox.Text.Trim().Length == 0)
            {
                TextBoxValidationError("address"); return false;
            }
            else if (phoneTextBox.Text.Trim().Length == 0)
            {
                TextBoxValidationError("phone number"); return false;
            }
            else if (zipCodeTextBox.Text.Trim().Length == 0)
            {
                TextBoxValidationError("zip code"); return false;
            }
            else
                return true;

        }

        private DTO.Enums.SizeType DetermineSize()
        {
            DTO.Enums.SizeType size;
            if (!Enum.TryParse(sizeDropDown.SelectedValue, out size))
            {
                throw new Exception("Could not determine pizza size.");
            }
            return size;
        }
        private DTO.Enums.CrustType DetermineCrust()
        {
            DTO.Enums.CrustType crust;
            if(!Enum.TryParse(crustDropDown.SelectedValue, out crust))
            {
                throw new Exception("Could not determina pizza crust.");
            }
            return crust;
        }
        private void TextBoxValidationError(string errorType)
        {
            string errorMessage = "";
            errorMessage += String.Format("<strong>Please enter a {0}.</strong>", errorType);
            validationLabel.Text = errorMessage;
            validationLabel.Visible = true;
        }
        private DTO.Enums.PaymentType DeterminePayment()
        {
            DTO.Enums.PaymentType _paymentType;

            if (cashRadio.Checked)
                _paymentType = DTO.Enums.PaymentType.Cash;
            else
                _paymentType = DTO.Enums.PaymentType.Credit;
            return _paymentType;
        }
        protected void RecalculateTotalCost(object sender, EventArgs e)
        {
            if (sizeDropDown.SelectedValue == "")
                return;
            if (crustDropDown.SelectedValue == "")
                return;

            var order = BuildOrder();
            decimal cost = Domain.PizzaPriceManager.CalculateCost(order);
            resultLabel.Text = string.Format("<h3>{0:C}</h3>", cost);

        }
        private DTO.OrderDTO BuildOrder()
        {
            PapaBobs.DTO.OrderDTO orderDTO = new DTO.OrderDTO();

            orderDTO.OrderId = Guid.NewGuid();
            orderDTO.Size = DetermineSize();
            orderDTO.Crust = DetermineCrust();
            orderDTO.Sausage = sausageCheckBox.Checked;
            orderDTO.Pepperoni = pepperoniCheckBox.Checked;
            orderDTO.Onions = onionCheckBox.Checked;
            orderDTO.GreenPeppers = greenPepperCheckBox.Checked;
            orderDTO.Name = nameTextBox.Text;
            orderDTO.Address = addressTextBox.Text;
            orderDTO.ZipCode = zipCodeTextBox.Text;
            orderDTO.Phone = phoneTextBox.Text;
            orderDTO.PaymentType = DeterminePayment();
            orderDTO.TotalCost = 16.50M;

            return orderDTO;
        }
    }
}