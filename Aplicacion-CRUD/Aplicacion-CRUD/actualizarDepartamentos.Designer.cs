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
            this.txtCRUD = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbFechaModificacion = new System.Windows.Forms.Label();
            this.lbGrupoDepartamento = new System.Windows.Forms.Label();
            this.lbNombreDepartamento = new System.Windows.Forms.Label();
            this.gbListaDepartamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaDepartamentos
            // 
            this.gbListaDepartamentos.Controls.Add(this.txtCRUD);
            this.gbListaDepartamentos.Controls.Add(this.btnActualizar);
            this.gbListaDepartamentos.Controls.Add(this.dateTimePicker1);
            this.gbListaDepartamentos.Controls.Add(this.textBox2);
            this.gbListaDepartamentos.Controls.Add(this.textBox1);
            this.gbListaDepartamentos.Controls.Add(this.lbFechaModificacion);
            this.gbListaDepartamentos.Controls.Add(this.lbGrupoDepartamento);
            this.gbListaDepartamentos.Controls.Add(this.lbNombreDepartamento);
            this.gbListaDepartamentos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListaDepartamentos.Location = new System.Drawing.Point(12, 12);
            this.gbListaDepartamentos.Name = "gbListaDepartamentos";
            this.gbListaDepartamentos.Size = new System.Drawing.Size(583, 325);
            this.gbListaDepartamentos.TabIndex = 2;
            this.gbListaDepartamentos.TabStop = false;
            this.gbListaDepartamentos.Text = "Lista de departamentos";
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
            this.btnActualizar.Location = new System.Drawing.Point(458, 240);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(95, 34);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 280);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 25);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 249);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 25);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 25);
            this.textBox1.TabIndex = 5;
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
            // frmActualizarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 350);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbFechaModificacion;
        private System.Windows.Forms.Label lbGrupoDepartamento;
        private System.Windows.Forms.Label lbNombreDepartamento;
    }
}