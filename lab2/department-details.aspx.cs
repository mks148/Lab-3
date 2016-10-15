using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2
{
    public partial class department_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
           
            var connection = new ContosoEntities1();

            
            Department d = new Department();

       
            d.Name = txtName.Text;
            d.Budget = Convert.ToDecimal(txtBudget.Text);

            connection.Departments.Add(d);
            connection.SaveChanges();

         
            Response.Redirect("departments.aspx");
        }
    }
}