﻿using System;
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

                    // Mensaje
                    lbEstado.Text = "Departamento Creado Correctamente";
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

        private void frmCrearDepartamentos_Load(object sender, EventArgs e)
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
