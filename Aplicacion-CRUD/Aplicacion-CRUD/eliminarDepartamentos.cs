using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Agregar el namespace para conectar a la base de datos
using System.Data.SqlClient;

namespace Aplicacion_CRUD
{
    

    public partial class frmEliminarDepartamentos : Form
    {

        // Crear la conexion a la base de datos
        SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress; integrated security = true; database = AdventureWorks2014");

        public frmEliminarDepartamentos()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Crear el comando del StoreProcedure
            SqlCommand cmd = new SqlCommand("sp_DeleteDepartmets", conn);

            // Establecer el comando como Store Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                // Paramtros del Store Procedure
                cmd.Parameters.Add(new SqlParameter("name", SqlDbType.NVarChar, 3));
               

                // Abrir la conexion
                conn.Open();


                // Ejecutar el query
                cmd.ExecuteNonQuery();
             
          
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "¡Detalles de la excepción!");
            }
            finally
            {
                // Cerrar la conexion
                conn.Close();
            }

            

        }

        private void frmEliminarDepartamentos_Load(object sender, EventArgs e)
        {
            // Crear el query DLM seleccionar
            string sql = @"SELECT * FROM HumanResources.Department";

            // Crear el comando 
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                // Abrir la conxion
                conn.Open();

                // Crear el comando
                txtCRUD.AppendText("Comando creado.\n\n");

                // Ejecutar el query de via ExcuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

                // Listar todos los registros de departamentos
                while (rdr.Read())
                {
                    txtCRUD.AppendText(rdr.GetValue(0) + "\t" + rdr.GetValue(1) + "\t" + rdr.GetValue(2) + "\t" + rdr.GetValue(3));
                    txtCRUD.AppendText("\n");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "¡Detalles de la excepción!");
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
                txtCRUD.AppendText("Conexión finalizada.");
            }
        }
    }
}
