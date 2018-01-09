using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FortuneTeller
{
    public partial class FortuneTeller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void clickMe_Click(object sender, EventArgs e)
        {
            string ageValue = ageTextBox.Text;
            string moneyValue = moneyTextBox.Text;

            string result = "At " + ageValue + " years old, I would have expected you to have more than " + moneyValue + " in your pocket.";

            resultLabel.Text = result;
        }
    }
}