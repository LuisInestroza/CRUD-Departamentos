namespace Aplicacion_CRUD
{
    partial class frmCrearDepartamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbListaDepartamentos = new System.Windows.Forms.GroupBox();
            this.txtCRUD = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dtpFechaModificacion = new System.Windows.Forms.DateTimePicker();
            this.txtGrupoDepartamento = new System.Windows.Forms.TextBox();
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.lbFechaModificacion = new System.Windows.Forms.Label();
            this.lbGrupoDepartamento = new System.Windows.Forms.Label();
            this.lbNombreDepartamento = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.gbListaDepartamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaDepartamentos
            // 
            this.gbListaDepartamentos.Controls.Add(this.lbEstado);
            this.gbListaDepartamentos.Controls.Add(this.txtCRUD);
            this.gbListaDepartamentos.Controls.Add(this.btnCrear);
            this.gbListaDepartamentos.Controls.Add(this.dtpFechaModificacion);
            this.gbListaDepartamentos.Controls.Add(this.txtGrupoDepartamento);
            this.gbListaDepartamentos.Controls.Add(this.txtNombreDepartamento);
            this.gbListaDepartamentos.Controls.Add(this.lbFechaModificacion);
            this.gbListaDepartamentos.Controls.Add(this.lbGrupoDepartamento);
            this.gbListaDepartamentos.Controls.Add(this.lbNombreDepartamento);
            this.gbListaDepartamentos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListaDepartamentos.Location = new System.Drawing.Point(12, 12);
            this.gbListaDepartamentos.Name = "gbListaDepartamentos";
            this.gbListaDepartamentos.Size = new System.Drawing.Size(802, 325);
            this.gbListaDepartamentos.TabIndex = 1;
            this.gbListaDepartamentos.TabStop = false;
            this.gbListaDepartamentos.Text = "Lista de departamentos";
            // 
            // txtCRUD
            // 
            this.txtCRUD.Location = new System.Drawing.Point(16, 38);
            this.txtCRUD.Multiline = true;
            this.txtCRUD.Name = "txtCRUD";
            this.txtCRUD.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCRUD.Size = new System.Drawing.Size(767, 162);
            this.txtCRUD.TabIndex = 8;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(469, 218);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(95, 34);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dtpFechaModificacion
            // 
            this.dtpFechaModificacion.Location = new System.Drawing.Point(158, 280);
            this.dtpFechaModificacion.Name = "dtpFechaModificacion";
            this.dtpFechaModificacion.Size = new System.Drawing.Size(268, 25);
            this.dtpFechaModificacion.TabIndex = 1;
            // 
            // txtGrupoDepartamento
            // 
            this.txtGrupoDepartamento.Location = new System.Drawing.Point(158, 249);
            this.txtGrupoDepartamento.Name = "txtGrupoDepartamento";
            this.txtGrupoDepartamento.Size = new System.Drawing.Size(268, 25);
            this.txtGrupoDepartamento.TabIndex = 6;
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.Location = new System.Drawing.Point(158, 218);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(268, 25);
            this.txtNombreDepartamento.TabIndex = 5;
            // 
            // lbFechaModificacion
            // 
            this.lbFechaModificacion.AutoSize = true;
            this.lbFechaModificacion.Location = new System.Drawing.Point(13, 285);
            this.lbFechaModificacion.Name = "lbFechaModificacion";
            this.lbFechaModificacion.Size = new System.Drawing.Size(137, 17);
            this.lbFechaModificacion.TabIndex = 4;
            this.lbFechaModificacion.Text = "Fecha Modificación:";
            // 
            // lbGrupoDepartamento
            // 
            this.lbGrupoDepartamento.AutoSize = true;
            this.lbGrupoDepartamento.Location = new System.Drawing.Point(13, 252);
            this.lbGrupoDepartamento.Name = "lbGrupoDepartamento";
            this.lbGrupoDepartamento.Size = new System.Drawing.Size(56, 17);
            this.lbGrupoDepartamento.TabIndex = 3;
            this.lbGrupoDepartamento.Text = "Grupo: ";
            // 
            // lbNombreDepartamento
            // 
            this.lbNombreDepartamento.AutoSize = true;
            this.lbNombreDepartamento.Location = new System.Drawing.Point(13, 221);
            this.lbNombreDepartamento.Name = "lbNombreDepartamento";
            this.lbNombreDepartamento.Size = new System.Drawing.Size(64, 17);
            this.lbNombreDepartamento.TabIndex = 2;
            this.lbNombreDepartamento.Text = "Nombre:";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(444, 285);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(0, 17);
            this.lbEstado.TabIndex = 9;
            // 
            // frmCrearDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 353);
            this.Controls.Add(this.gbListaDepartamentos);
            this.Name = "frmCrearDepartamentos";
            this.Text = "Crear Departamentos";
            this.Load += new System.EventHandler(this.frmCrearDepartamentos_Load);
            this.gbListaDepartamentos.ResumeLayout(false);
            this.gbListaDepartamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListaDepartamentos;
        private System.Windows.Forms.TextBox txtCRUD;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DateTimePicker dtpFechaModificacion;
        private System.Windows.Forms.TextBox txtGrupoDepartamento;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.Label lbFechaModificacion;
        private System.Windows.Forms.Label lbGrupoDepartamento;
        private System.Windows.Forms.Label lbNombreDepartamento;
        private System.Windows.Forms.Label lbEstado;
    }
}