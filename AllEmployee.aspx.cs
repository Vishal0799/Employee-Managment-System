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
    public partial class AllEmployee : System.Web.UI.Page
    {
        new SqlConnection con = new SqlConnection("Data Source=VISHAL\\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True;");
        new SqlCommand cmd;
        new SqlDataAdapter da;
        string s;
           protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            s = "select * from emp";
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}