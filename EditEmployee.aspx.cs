using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace project1
{
    public partial class EditEmployee : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=VISHAL\\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter da;
        string s;

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string a;
            s = "select * from emp where eid=" + TextBox1.Text;
            DataSet ds=new DataSet();
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0) 
            {
                Response.Write("<script>alert('Record Not Exist'</Script>");
            }
            else
            {
                TextBox2.Text = ds.Tables[0].Rows[0][0].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0][1].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0][2].ToString();
                a = ds.Tables[0].Rows[0][3].ToString();
                if (a == "male")
                {
                    RadioButton1.Checked = true;
                    Label1.Text = "male";
                }
                else
                {
                    RadioButton2.Checked = true;
                    Label1.Text = "female";
                }
            }
            TextBox5.Text = ds.Tables[0].Rows[0][4].ToString();
            TextBox6.Text = ds.Tables[0].Rows[0][5].ToString();
            DropDownList1.Text = ds.Tables[0].Rows[0][6].ToString();
        }
        protected void Button2_Click1(object sender, EventArgs e)
        {
            s = "delete from emp where eid=" + TextBox1.Text;
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            DropDownList1.Text = "";
            TextBox1.Focus();
            Response.Write("<script>alert('Employee Deleted Successfully')</script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            s= "update emp set ename='"+TextBox3.Text+"',efather='"+TextBox4.Text+"',econtact="+TextBox5.Text+",eadress='"+TextBox6.Text+"'";
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";

        }
    }
}