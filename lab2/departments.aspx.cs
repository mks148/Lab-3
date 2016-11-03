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

        protected void grdDepartments_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // function to delete department from the gridview
            //. determine which row in the grid the user clicked

            Int32 gridIndex = e.RowIndex;

            //2. find the departmentsID value on the selected row
            Int32 DepartmentID = Convert.ToInt32(grdDepartments.DataKeys[gridIndex].Value);

            //3. connect to database
            var conn = new ContosoEntities1();

            //4. delete the department
            /*var objDep = (from d in conn.Departments where d.DepartmentID == DepartmentID select d).First();*/

            Department d = new Department();
            d.DepartmentID = DepartmentID;
            conn.Departments.Attach(d);
            conn.Departments.Remove(d);
            conn.SaveChanges();

            
            
            //5.refresh the gridview

            getDepartments();

        }
    }
}