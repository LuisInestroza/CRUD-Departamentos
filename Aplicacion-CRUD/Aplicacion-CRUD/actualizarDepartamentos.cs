using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Agregar namecespaces
using System.Data.SqlClient;

namespace Aplicacion_CRUD
{
    public partial class frmActualizarDepartamentos : Form
    {
        // Crear la conexion a la base de datos
        SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress; integrated security = true; database = AdventureWorks2014");

        public frmActualizarDepartamentos()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Crear query DML Update
            string sqlUpd = @"UPDATE HumanResources.Department set Name = @name, GroupName = @groupName, ModifiedDate = @date WHERE  DepartmentID = @ID";

            // Crear el comando
            SqlCommand cmd = new SqlCommand(sqlUpd, conn);

            try
            {
                // Abrir la conexion
                conn.Open();

                using (cmd)
                {
                    // Remplazar los parametros
                    cmd.Parameters.Add("@ID", SqlDbType.SmallInt).Value = Convert.ToInt16(txtCodigo.Text);
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtNombreDepartamento.Text;
                    cmd.Parameters.Add("@groupName", SqlDbType.NVarChar).Value = txtGrupoDepartamento.Text;
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dtpFechaModifiacion.Value;

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
