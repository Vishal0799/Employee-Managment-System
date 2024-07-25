using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TextBox1.Text = "";
            //TextBox2.Text = "";
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(TextBox1.Text);
            Response.Write(TextBox2.Text);
            if (TextBox1.Text == "admin" && TextBox2.Text == "admin")
                Response.Redirect("NewEmployee.aspx");
            else
                Response.Write("<Script>alert('Invalid User Name And Password')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();
        }
    }
}