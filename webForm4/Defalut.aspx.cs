using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace webForm4
{
    public partial class Dafalut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btSearch_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);

            con.Open();
            SqlCommand CMD = new SqlCommand();
            string querry = "SELECT * FROM dbo.SV WHERE [MSSV] + [HOTEN] + [GIOITINH] + [QUEQUAN] like '%'+@MSSV+ '%' ";
            CMD.CommandText = querry;
            CMD.Connection = con;
            CMD.Parameters.AddWithValue("MSSV", txtSearch.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(CMD);
            SDA.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            
        }
    }
}