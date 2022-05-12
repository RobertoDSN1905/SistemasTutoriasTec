using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace AsesoriasTEC2019
{
    public partial class Materias : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string param1 = Request.QueryString["tipo"];
            if (param1.Equals("1"))
            {
                menu1.Visible = true;
            }

            DataSet ds = GetData();
            repeater1.DataSource = ds;
            repeater1.DataBind();
        }

        protected void repeater1_ItemCreated(object sender, RepeaterItemEventArgs e)
        {

        }

        private DataSet GetData()
        {
            string constr = "Server=localhost;Database=AsesoriasDB;Uid=root;Pwd=;";
            DataSet ds = new DataSet();

            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                //card card-dark mb-4            card card-danger mb-4
                MySqlDataAdapter da = new MySqlDataAdapter("Select descripcion from materiastutor ;", conn);
                da.Fill(ds);

            }

            return ds;
        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            ocultarLabel.Visible = true;
        }
    }
}