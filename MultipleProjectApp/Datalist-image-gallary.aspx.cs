using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MultipleProjectApp
{
    public partial class Datalist_image_gallary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(con);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from ProductCategory", sqlConnection);
            
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            
            DataList1.DataSource = sqlDataReader;
            DataList1.DataBind();
            sqlConnection.Close();
        }
    }
}