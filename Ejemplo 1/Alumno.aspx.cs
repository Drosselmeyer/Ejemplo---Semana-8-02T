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
        SqlConnection con = null;
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonId_Click(object sender, EventArgs e)
        {           

            try
            {   //Creamos la conexion a la base datos
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Colegio;Integrated Security=True");

                //Crear la query para ingresar datos
                string query = "INSERT INTO Alumno(Carnet, Nombre, Carrera) VALUES" +
                                "('" + txtCarnet.Text + "','" + txtNombre.Text + "','" + txtCarrera.Text + "')";
                //Mandamos la query a la cola
                SqlCommand sc = new SqlCommand(query, con);
                //Abrimos la conexion a la base de datos
                con.Open();

                //Ejecutamos la Query
                int status = sc.ExecuteNonQuery();

                

            }
            catch(Exception ex)
            {
                Console.WriteLine("Ha habido un error." + ex);
            }
            finally
            {
                con.Close();
                con = null;
            }

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Creamos la conexion a la base datos
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Colegio;Integrated Security=True");
                
                //Declaramos nuestra query
                SqlCommand read = new SqlCommand("SELECT * FROM Alumno", con);

                //Abrimos la conexion a la base de datos
                con.Open();

                lblIdHead.Text = "Id";
                lblCarnetHead.Text = "Carnet";
                lblNombreHead.Text = "Nombre";
                lblCarreraHead.Text = "Carrera";

                //Ejecutamos la query para la lectura
                SqlDataReader ds = read.ExecuteReader();
                while (ds.Read())
                {
                    //Creando un newTableRow
                    TableRow tr = new TableRow(); //Esto es igual a document.createElement('tr')
                    TableCell[] td = new TableCell[4]; //document.createElement('td')

                    for (int i = 0; i < 4; i++)
                    {
                        td[i] = new TableCell();
                    }

                    //Leyendo el dataset que nos vino de la consulta
                    Label lblId = new Label(); //document.createElement('label').Id(lblId)
                    Label lblCarnet = new Label();
                    Label lblNombre = new Label();
                    Label lblCarrera = new Label();

                    lblId.Text = ds["Id"].ToString(); //Le estoy colocando lo que viene en el dataset en la columna Id
                    td[0].Controls.Add(lblId); //td[0].appendChild(lblId)
                    tr.Controls.Add(td[0]); //tr.appendChild(td[0]);

                    lblCarnet.Text = ds["Carnet"].ToString();
                    td[1].Controls.Add(lblCarnet);
                    tr.Controls.Add(td[1]);

                    lblNombre.Text = ds["Nombre"].ToString();
                    td[2].Controls.Add(lblNombre);
                    tr.Controls.Add(td[2]);

                    lblCarrera.Text = ds["Carrera"].ToString();
                    td[3].Controls.Add(lblCarrera);
                    tr.Controls.Add(td[3]);

                    tbConsulta.Controls.Add(tr); //tbConsulta.appendChild(tr);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha habido un error." + ex);
            }
            finally
            {
                con.Close();
                con = null;
            }
        }
    }
}