using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar namespace para la conexion a la base de datos
using System.Data.SqlClient;

namespace Aplicacion_CRUD
{
    public partial class frmCrearDepartamentos : Form
    {
        // Crear la conexion a la base de datos
        SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress; integrated security = true; database = AdventureWorks2014");

        public frmCrearDepartamentos()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            // Crear query DML Insert
            string sqlIns = @"INSERT INTO HumanResources.Department(Name, GroupName, ModifiedDate) VALUES (@name, @groupName, @date)";

            // Crear el comando
            SqlCommand cmd = new SqlCommand(sqlIns, conn);

            try
            {
                // Abrir la conexion
                conn.Open();

                using (cmd)
                {
                    // Remplazar los parametros
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtNombreDepartamento.Text;
                    cmd.Parameters.Add("@groupName", SqlDbType.NVarChar).Value = txtGrupoDepartamento.Text;
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dtpFechaModificacion.Value;

                    // Ejecuatar el comando
                    cmd.ExecuteNonQuery();


                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "¡Detalles de la excepción!");
            }
            finally
            {
                // Cerrar conexion
                conn.Close();

            }
        }
    }
}
