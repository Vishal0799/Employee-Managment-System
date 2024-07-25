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
    public partial class SearchEmployee : System.Web.UI.Page
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
            s = "select * from emp where eid=" + TextBox1.Text;
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count==0)
            {
                Response.Write("<script>alert('Record Not Found')</script>");
            }
            else
            {
                Label1.Text = ds.Tables[0].Rows[0][0].ToString();
                Label2.Text = ds.Tables[0].Rows[0][1].ToString();
                Label3.Text = ds.Tables[0].Rows[0][2].ToString();
                Label4.Text = ds.Tables[0].Rows[0][3].ToString();
                Label5.Text = ds.Tables[0].Rows[0][4].ToString();
                Label6.Text = ds.Tables[0].Rows[0][5].ToString();
                Label7.Text = ds.Tables[0].Rows[0][6].ToString();
            }
        }
    }
}