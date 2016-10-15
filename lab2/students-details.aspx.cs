using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2
{
    public partial class students_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            var connect = new ContosoEntities1();
            Student stu = new Student();

            stu.LastName = txtLast.Text;
            stu.FirstMidName= txtFirst.Text;
            stu.EnrollmentDate= Convert.ToDateTime(txtEnrollment.Text);
            connect.Students.Add(stu);
            connect.SaveChanges();

            Response.Redirect("students.aspx");
        }
    }
}