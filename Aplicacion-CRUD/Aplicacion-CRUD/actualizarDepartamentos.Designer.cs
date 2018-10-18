namespace Aplicacion_CRUD
{
    partial class frmActualizarDepartamentos
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txtCRUD = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dtpFechaModifiacion = new System.Windows.Forms.DateTimePicker();
            this.txtGrupoDepartamento = new System.Windows.Forms.TextBox();
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.lbFechaModificacion = new System.Windows.Forms.Label();
            this.lbGrupoDepartamento = new System.Windows.Forms.Label();
            this.lbNombreDepartamento = new System.Windows.Forms.Label();
            this.gbListaDepartamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaDepartamentos
            // 
            this.gbListaDepartamentos.Controls.Add(this.txtCodigo);
            this.gbListaDepartamentos.Controls.Add(this.lbCodigo);
            this.gbListaDepartamentos.Controls.Add(this.txtCRUD);
            this.gbListaDepartamentos.Controls.Add(this.btnActualizar);
            this.gbListaDepartamentos.Controls.Add(this.dtpFechaModifiacion);
            this.gbListaDepartamentos.Controls.Add(this.txtGrupoDepartamento);
            this.gbListaDepartamentos.Controls.Add(this.txtNombreDepartamento);
            this.gbListaDepartamentos.Controls.Add(this.lbFechaModificacion);
            this.gbListaDepartamentos.Controls.Add(this.lbGrupoDepartamento);
            this.gbListaDepartamentos.Controls.Add(this.lbNombreDepartamento);
            this.gbListaDepartamentos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListaDepartamentos.Location = new System.Drawing.Point(12, 12);
            this.gbListaDepartamentos.Name = "gbListaDepartamentos";
            this.gbListaDepartamentos.Size = new System.Drawing.Size(583, 363);
            this.gbListaDepartamentos.TabIndex = 2;
            this.gbListaDepartamentos.TabStop = false;
            this.gbListaDepartamentos.Text = "Lista de departamentos";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(170, 219);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(268, 25);
            this.txtCodigo.TabIndex = 10;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(25, 222);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(58, 17);
            this.lbCodigo.TabIndex = 9;
            this.lbCodigo.Text = "Codigo:";
            // 
            // txtCRUD
            // 
            this.txtCRUD.Location = new System.Drawing.Point(16, 41);
            this.txtCRUD.Multiline = true;
            this.txtCRUD.Name = "txtCRUD";
            this.txtCRUD.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCRUD.Size = new System.Drawing.Size(522, 143);
            this.txtCRUD.TabIndex = 8;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(470, 274);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(95, 34);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dtpFechaModifiacion
            // 
            this.dtpFechaModifiacion.Location = new System.Drawing.Point(170, 314);
            this.dtpFechaModifiacion.Name = "dtpFechaModifiacion";
            this.dtpFechaModifiacion.Size = new System.Drawing.Size(268, 25);
            this.dtpFechaModifiacion.TabIndex = 1;
            // 
            // txtGrupoDepartamento
            // 
            this.txtGrupoDepartamento.Location = new System.Drawing.Point(170, 283);
            this.txtGrupoDepartamento.Name = "txtGrupoDepartamento";
            this.txtGrupoDepartamento.Size = new System.Drawing.Size(268, 25);
            this.txtGrupoDepartamento.TabIndex = 6;
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.Location = new System.Drawing.Point(170, 252);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(268, 25);
            this.txtNombreDepartamento.TabIndex = 5;
            // 
            // lbFechaModificacion
            // 
            this.lbFechaModificacion.AutoSize = true;
            this.lbFechaModificacion.Location = new System.Drawing.Point(25, 319);
            this.lbFechaModificacion.Name = "lbFechaModificacion";
            this.lbFechaModificacion.Size = new System.Drawing.Size(137, 17);
            this.lbFechaModificacion.TabIndex = 4;
            this.lbFechaModificacion.Text = "Fecha Modificación:";
            // 
            // lbGrupoDepartamento
            // 
            this.lbGrupoDepartamento.AutoSize = true;
            this.lbGrupoDepartamento.Location = new System.Drawing.Point(25, 286);
            this.lbGrupoDepartamento.Name = "lbGrupoDepartamento";
            this.lbGrupoDepartamento.Size = new System.Drawing.Size(56, 17);
            this.lbGrupoDepartamento.TabIndex = 3;
            this.lbGrupoDepartamento.Text = "Grupo: ";
            // 
            // lbNombreDepartamento
            // 
            this.lbNombreDepartamento.AutoSize = true;
            this.lbNombreDepartamento.Location = new System.Drawing.Point(25, 255);
            this.lbNombreDepartamento.Name = "lbNombreDepartamento";
            this.lbNombreDepartamento.Size = new System.Drawing.Size(64, 17);
            this.lbNombreDepartamento.TabIndex = 2;
            this.lbNombreDepartamento.Text = "Nombre:";
            // 
            // frmActualizarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 387);
            this.Controls.Add(this.gbListaDepartamentos);
            this.Name = "frmActualizarDepartamentos";
            this.Text = "Actualizar Departamentos";
            this.gbListaDepartamentos.ResumeLayout(false);
            this.gbListaDepartamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListaDepartamentos;
        private System.Windows.Forms.TextBox txtCRUD;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DateTimePicker dtpFechaModifiacion;
        private System.Windows.Forms.TextBox txtGrupoDepartamento;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.Label lbFechaModificacion;
        private System.Windows.Forms.Label lbGrupoDepartamento;
        private System.Windows.Forms.Label lbNombreDepartamento;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbCodigo;
    }
}