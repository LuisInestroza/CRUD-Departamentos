namespace Aplicacion_CRUD
{
    partial class frmAplicacionCRUD
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnEliminarDepartamento = new System.Windows.Forms.Button();
            this.btnListarDepartamentos = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCrearDepartamento = new System.Windows.Forms.Button();
            this.gbOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOperaciones
            // 
            this.gbOperaciones.Controls.Add(this.btnEliminarDepartamento);
            this.gbOperaciones.Controls.Add(this.btnListarDepartamentos);
            this.gbOperaciones.Controls.Add(this.btnActualizar);
            this.gbOperaciones.Controls.Add(this.btnCrearDepartamento);
            this.gbOperaciones.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperaciones.Location = new System.Drawing.Point(12, 12);
            this.gbOperaciones.Name = "gbOperaciones";
            this.gbOperaciones.Size = new System.Drawing.Size(402, 206);
            this.gbOperaciones.TabIndex = 1;
            this.gbOperaciones.TabStop = false;
            this.gbOperaciones.Text = "Operaciones disponibles para departamentos";
            // 
            // btnEliminarDepartamento
            // 
            this.btnEliminarDepartamento.Location = new System.Drawing.Point(208, 148);
            this.btnEliminarDepartamento.Name = "btnEliminarDepartamento";
            this.btnEliminarDepartamento.Size = new System.Drawing.Size(176, 34);
            this.btnEliminarDepartamento.TabIndex = 4;
            this.btnEliminarDepartamento.Text = "Eliminar Departamento";
            this.btnEliminarDepartamento.UseVisualStyleBackColor = true;
            this.btnEliminarDepartamento.Click += new System.EventHandler(this.btnEliminarDepartamento_Click);
            // 
            // btnListarDepartamentos
            // 
            this.btnListarDepartamentos.Location = new System.Drawing.Point(17, 62);
            this.btnListarDepartamentos.Name = "btnListarDepartamentos";
            this.btnListarDepartamentos.Size = new System.Drawing.Size(160, 34);
            this.btnListarDepartamentos.TabIndex = 1;
            this.btnListarDepartamentos.Text = "Listar Departamentos";
            this.btnListarDepartamentos.UseVisualStyleBackColor = true;
            this.btnListarDepartamentos.Click += new System.EventHandler(this.btnListarDepartamentos_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(17, 148);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(160, 34);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCrearDepartamento
            // 
            this.btnCrearDepartamento.Location = new System.Drawing.Point(208, 62);
            this.btnCrearDepartamento.Name = "btnCrearDepartamento";
            this.btnCrearDepartamento.Size = new System.Drawing.Size(176, 34);
            this.btnCrearDepartamento.TabIndex = 2;
            this.btnCrearDepartamento.Text = "Crear Departamento";
            this.btnCrearDepartamento.UseVisualStyleBackColor = true;
            this.btnCrearDepartamento.Click += new System.EventHandler(this.btnCrearDepartamento_Click);
            // 
            // frmAplicacionCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 225);
            this.Controls.Add(this.gbOperaciones);
            this.Name = "frmAplicacionCRUD";
            this.Text = "Operaciones CRUD con departamentos Adventure Works";
            this.gbOperaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOperaciones;
        private System.Windows.Forms.Button btnEliminarDepartamento;
        private System.Windows.Forms.Button btnListarDepartamentos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCrearDepartamento;
    }
}

