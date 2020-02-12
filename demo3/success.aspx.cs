using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;



public partial class success : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGridviewData();

        }
    }
    public void BindGridviewData()
    {
        using (MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=db;user=root;password=njsinfotech"))
        {
            using (MySqlCommand cmd = new MySqlCommand("select*from emplloyees", con))
            {
                con.Open();
                DataSet ds = new DataSet();
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                    first.DataSource = ds;
                    first.DataBind();
                }

            }
        }
    }
}

    
    
