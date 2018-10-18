namespace Aplicacion_CRUD
{
    partial class frmEliminarDepartamentos
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminarDepartamento = new System.Windows.Forms.TextBox();
            this.lbNombreDepartamento = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.gbListaDepartamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaDepartamentos
            // 
            this.gbListaDepartamentos.Controls.Add(this.lbEstado);
            this.gbListaDepartamentos.Controls.Add(this.txtCRUD);
            this.gbListaDepartamentos.Controls.Add(this.btnEliminar);
            this.gbListaDepartamentos.Controls.Add(this.txtEliminarDepartamento);
            this.gbListaDepartamentos.Controls.Add(this.lbNombreDepartamento);
            this.gbListaDepartamentos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListaDepartamentos.Location = new System.Drawing.Point(12, 12);
            this.gbListaDepartamentos.Name = "gbListaDepartamentos";
            this.gbListaDepartamentos.Size = new System.Drawing.Size(788, 329);
            this.gbListaDepartamentos.TabIndex = 2;
            this.gbListaDepartamentos.TabStop = false;
            this.gbListaDepartamentos.Text = "Lista de departamentos";
            // 
            // txtCRUD
            // 
            this.txtCRUD.Location = new System.Drawing.Point(24, 36);
            this.txtCRUD.Multiline = true;
            this.txtCRUD.Name = "txtCRUD";
            this.txtCRUD.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCRUD.Size = new System.Drawing.Size(733, 162);
            this.txtCRUD.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(473, 211);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 34);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEliminarDepartamento
            // 
            this.txtEliminarDepartamento.Location = new System.Drawing.Point(124, 220);
            this.txtEliminarDepartamento.Name = "txtEliminarDepartamento";
            this.txtEliminarDepartamento.Size = new System.Drawing.Size(268, 25);
            this.txtEliminarDepartamento.TabIndex = 5;
            // 
            // lbNombreDepartamento
            // 
            this.lbNombreDepartamento.AutoSize = true;
            this.lbNombreDepartamento.Location = new System.Drawing.Point(54, 223);
            this.lbNombreDepartamento.Name = "lbNombreDepartamento";
            this.lbNombreDepartamento.Size = new System.Drawing.Size(64, 17);
            this.lbNombreDepartamento.TabIndex = 2;
            this.lbNombreDepartamento.Text = "Nombre:";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(355, 283);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(0, 17);
            this.lbEstado.TabIndex = 10;
            // 
            // frmEliminarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 353);
            this.Controls.Add(this.gbListaDepartamentos);
            this.Name = "frmEliminarDepartamentos";
            this.Text = "Eliminar Departamentos";
            this.Load += new System.EventHandler(this.frmEliminarDepartamentos_Load);
            this.gbListaDepartamentos.ResumeLayout(false);
            this.gbListaDepartamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListaDepartamentos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEliminarDepartamento;
        private System.Windows.Forms.Label lbNombreDepartamento;
        private System.Windows.Forms.TextBox txtCRUD;
        private System.Windows.Forms.Label lbEstado;
    }
}