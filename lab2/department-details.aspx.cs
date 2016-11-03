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
            //check the url for ID so we know we are adding or editing data

            if (IsPostBack==false) {
                if (!String.IsNullOrEmpty(Request.QueryString["DepartmentID"]))
                {
                    //get id from the url

                    Int32 DepartmentID = Convert.ToInt32(Request.QueryString["DepartmentID"]);

                    //connect
                    var conn = new ContosoEntities1();

                    //lookup the delected department

                    var objDep = (from d in conn.Departments where d.DepartmentID == DepartmentID select d).First();

                    //populate the form

                    txtName.Text = objDep.Name;
                    txtBudget.Text = objDep.Budget.ToString();
                }
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            //check if we have an id to decide if we are adding or editing
            Int32 DepartmentID = 0;

            if(!String.IsNullOrEmpty(Request.QueryString["DepartmentID"]))
            {
                DepartmentID=Convert.ToInt32(Request.QueryString["DepartmentID"]);
            }

            var connection = new ContosoEntities1();

            
            Department d = new Department();

       
            d.Name = txtName.Text;
            d.Budget = Convert.ToDecimal(txtBudget.Text);

            //save the data

            if(DepartmentID==0)
            {
                connection.Departments.Add(d);
            }
            else
            {
                d.DepartmentID = DepartmentID;
                connection.Departments.Attach(d);
                connection.Entry(d).State = System.Data.Entity.EntityState.Modified;
            }

      
            connection.SaveChanges();

         
            Response.Redirect("departments.aspx");

        }
    }
}