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


            if (IsPostBack == false)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["StudentID"]))
                {


                    Int32 StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);


                    var conn = new ContosoEntities1();



                    var objStu = (from s in conn.Students where s.StudentID == StudentID select s).First();


                    txtLast.Text = objStu.LastName;
                    txtFirst.Text = objStu.FirstMidName;
                    txtEnrollment.Text = objStu.EnrollmentDate.ToString("yyyy-MM-dd");
                    
                }

            }





            }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            Int32 StudentID = 0;

            if (!String.IsNullOrEmpty(Request.QueryString["StudentID"]))
            {
                StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            }



            var connect = new ContosoEntities1();
            Student stu = new Student();

            stu.LastName = txtLast.Text;
            stu.FirstMidName= txtFirst.Text;
            stu.EnrollmentDate= Convert.ToDateTime(txtEnrollment.Text);
           

            if (StudentID == 0)
            {
                connect.Students.Add(stu);
            }
            else
            {
                stu.StudentID = StudentID;
                connect.Students.Attach(stu);
                connect.Entry(stu).State = System.Data.Entity.EntityState.Modified;
            }



            connect.SaveChanges();

            Response.Redirect("students.aspx");
        }
    }
}