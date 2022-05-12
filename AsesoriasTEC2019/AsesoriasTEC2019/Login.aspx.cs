using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace AsesoriasTEC2019
{
    public partial class Login : System.Web.UI.Page
    {
        string strcon = "Server=localhost;Database=AsesoriasDB;Uid=root;Pwd=;";

        string str;

        MySqlCommand com;

        object obj;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(strcon);

            con.Open();

            str = "select count(*) from usuario where Usuario=@Usuario and Pasword =@Pasword";
            com = new MySqlCommand(str, con);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@Usuario", textUser.Value.ToString());
            com.Parameters.AddWithValue("@Pasword", textPass.Value.ToString());
            obj = com.ExecuteScalar();
            if (Convert.ToInt32(obj) != 0)
            {
                string str2 = "select count(*) from usuario where Status = 1 and Usuario=@Usuario";
                MySqlCommand com2 = new MySqlCommand(str2, con);
                com2.CommandType = CommandType.Text;
                com2.Parameters.AddWithValue("@Usuario", textUser.Value.ToString());
                obj = com2.ExecuteScalar();
                if(Convert.ToInt32(obj) != 0)
                {
                    Response.Redirect("Materias.aspx?tipo=1", false);
                }
                else
                {
                    Response.Redirect("Materias.aspx?tipo=0", false);
                }
                
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("error contraseña");
            }
            con.Close();
        }
    }
}