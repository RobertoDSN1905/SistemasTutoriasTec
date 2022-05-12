using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AsesoriasTEC2019
{
    public partial class SignUp : System.Web.UI.Page
    {

        string strcon = "Server=localhost;Database=AsesoriasDB;Uid=root;Pwd=;";

        MySqlCommand com;

        object obj;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            string nombre = textName.Value.ToString();
            string apellido = textAp.Value.ToString();
            string email = textEmail.Value.ToString();
            string user = textUser.Value.ToString();
            byte status;
            string pas = textPas.Value.ToString();
            string conpas = textConfirm.Value.ToString();
            if (!pas.Equals(conpas) || pas.Equals(null) || conpas.Equals(null))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "las contrañas no coinciden" + "');", true);
            }

            if(dropUser.SelectedValue.Equals("Tutor"))
            {
                status = 1;
            }
            else
            {
                status = 0;
            }

            try {
                MySqlConnection con = new MySqlConnection(strcon);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("insert into usuario (Usuario,Pasword,Status) values(@Usuario,@Pasword,@Status)",con);
                cmd.Parameters.AddWithValue("@Usuario", user);
                cmd.Parameters.AddWithValue("@Pasword", pas);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.ExecuteNonQuery();
            } catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("------>" + ex);
            }
        }
    }
}