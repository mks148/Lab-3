using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2
{
    public partial class tip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            /* get the amount from the textbox
             * save in a variable of double (which holds decimals)
             * first we have to convert the value from a string to a doubleS
             */
            Double amount = Convert.ToDouble(txtamount.Text);

            //get tip percent

            Double tippercent = Convert.ToDouble(ddlpercent.SelectedValue); 4

                //calculate the tip and total

            Double tipamount = amount * tippercent;
            Double total = amount + tipamount;

            //display the results

            lblTip.Text = tipamount.ToString();
            lbltotal.Text = total.ToString();
        }
    }
}