using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2
{
    public partial class departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getDepartments();
        }
        protected void getDepartments()
        {
          
            var connection = new ContosoEntities1();

            var Departments = from d in connection.Departments   select d;

            
            grdDepartments.DataSource = Departments.ToList();
            grdDepartments.DataBind();

        }
    }
}