using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_CRUD
{
    public partial class frmAplicacionCRUD : Form
    {
        public frmAplicacionCRUD()
        {
            InitializeComponent();
        }

        private void btnListarDepartamentos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de para listar todos los departamentos 
            // en la base de datos

            frmListarDepartamentos abrirFormulario = new frmListarDepartamentos();
            abrirFormulario.Show();
        }

        private void btnCrearDepartamento_Click(object sender, EventArgs e)
        {
            // Abrir formulario para crear un nuevo departamento

            frmCrearDepartamentos abrirFormulario = new frmCrearDepartamentos();
            abrirFormulario.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Abrir formulario para actualizar un departamento 
            // en la base de datos

            frmActualizarDepartamentos abrirFormulario = new frmActualizarDepartamentos();
            abrirFormulario.Show();
        }

        private void btnEliminarDepartamento_Click(object sender, EventArgs e)
        {
            // Abrir formulario para eliminar un departamento
            // en la base de datos

            frmEliminarDepartamentos abrirFormulario = new frmEliminarDepartamentos();
            abrirFormulario.Show();
        }
    }
}
