using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AsesoriasTEC2019
{
    public partial class RegistrarMaterias : System.Web.UI.Page
    {

        string strcon = "Server=localhost;Database=AsesoriasDB;Uid=root;Pwd=;";

        MySqlCommand com;

        object obj;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string materia = textMateria.Value.ToString();
            string hora = textHora.Value.ToString();
            string enlace = textEnalce.Value.ToString();
            string codigo = textCode.Value.ToString();
            string completo = materia + " - " + hora;
            try
            {
                MySqlConnection con = new MySqlConnection(strcon);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("insert into materiastutor (Descripcion,Codigo,enlace) values(@Descripcion,@Codigo,@enlace)", con);
                cmd.Parameters.AddWithValue("@Descripcion", completo);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@enlace", enlace);
                cmd.ExecuteNonQuery();
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Materia registrada con exito" + "');", true);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("------>" + ex);
            }
        }
    }
}