using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Ejemplo_1
{
    public partial class Alumno1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonId_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;

            try
            {
                //Creamos la conexion a la base datos
                con = new SqlConnection("data source=.;database=Colegio;integrated security = SSPI");

                //Crear la query para ingresar datos
                string query = "INSERT INTO Alumno(Id, Carnet, Nombre, Carrera) VALUES" +
                                "(" + Convert.ToInt32( txtId.Text )+ ",'" + txtCarnet.Text + "','" + txtNombre.Text + "','" + txtCarrera.Text + "')";
                //Mandamos la query a la cola
                SqlCommand sc = new SqlCommand(query, con);
                //Abrimos la conexion a la base de datos
                con.Open();

                //Ejecutamos la Query
                int status = sc.ExecuteNonQuery();

                SqlCommand read = new SqlCommand("SELECT TOP 1 * FROM Alumno", con);

                //Ejecutamos la query para la lectura
                SqlDataReader ds = read.ExecuteReader();
                ds.Read();

                //Leyendo el dataset que nos vino de la consulta
                lblIdHead.Text = "Id";
                lblId.Text = ds["Id"].ToString();

                lblCarnetHead.Text = "Carnet";
                lblCarnet.Text = ds["Carnet"].ToString();

                lblNombreHead.Text = "Nombre";
                lblNombre.Text = ds["Nombre"].ToString();

                lblCarreraHead.Text = "Carrera";
                lblCarrera.Text = ds["Carrera"].ToString();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Ha habido un error." + ex);
            }
            finally
            {
                con.Close();
            }

        }
    }
}