using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace project1
{
    public partial class NewEmployee : System.Web.UI.Page
    {
        SqlConnection con =  new SqlConnection("Data Source=VISHAL\\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True;");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string a;
            if(RadioButton1.Checked)
            {
                a = "male";
            }
            else
            {
                a = "female";
            }
            string s="insert into emp values(" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + a+  "'," + TextBox4.Text+ ",'" + TextBox5.Text+"','" + DropDownList1.Text + "')";
                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Employee Registered Successfully')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            RadioButton1.Text = "";
            RadioButton2.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            DropDownList1.Text = "";
            
        }
    }
}