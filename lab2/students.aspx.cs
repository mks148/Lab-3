﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2
{
    public partial class students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getStudents();
        }

        protected void getStudents()
        {
           
            var connection = new ContosoEntities1();

            var Students = from s in connection.Students  select s;

            grdStudents.DataSource = Students.ToList();
            grdStudents.DataBind();

        }
    }
}