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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminarDepartamento = new System.Windows.Forms.TextBox();
            this.lbNombreDepartamento = new System.Windows.Forms.Label();
            this.lbEliminarDepartamento = new System.Windows.Forms.ListBox();
            this.gbListaDepartamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaDepartamentos
            // 
            this.gbListaDepartamentos.Controls.Add(this.lbEliminarDepartamento);
            this.gbListaDepartamentos.Controls.Add(this.btnEliminar);
            this.gbListaDepartamentos.Controls.Add(this.txtEliminarDepartamento);
            this.gbListaDepartamentos.Controls.Add(this.lbNombreDepartamento);
            this.gbListaDepartamentos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListaDepartamentos.Location = new System.Drawing.Point(12, 12);
            this.gbListaDepartamentos.Name = "gbListaDepartamentos";
            this.gbListaDepartamentos.Size = new System.Drawing.Size(523, 241);
            this.gbListaDepartamentos.TabIndex = 2;
            this.gbListaDepartamentos.TabStop = false;
            this.gbListaDepartamentos.Text = "Lista de departamentos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(386, 172);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 34);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEliminarDepartamento
            // 
            this.txtEliminarDepartamento.Location = new System.Drawing.Point(97, 172);
            this.txtEliminarDepartamento.Name = "txtEliminarDepartamento";
            this.txtEliminarDepartamento.Size = new System.Drawing.Size(268, 25);
            this.txtEliminarDepartamento.TabIndex = 5;
            // 
            // lbNombreDepartamento
            // 
            this.lbNombreDepartamento.AutoSize = true;
            this.lbNombreDepartamento.Location = new System.Drawing.Point(27, 175);
            this.lbNombreDepartamento.Name = "lbNombreDepartamento";
            this.lbNombreDepartamento.Size = new System.Drawing.Size(64, 17);
            this.lbNombreDepartamento.TabIndex = 2;
            this.lbNombreDepartamento.Text = "Nombre:";
            // 
            // lbEliminarDepartamento
            // 
            this.lbEliminarDepartamento.FormattingEnabled = true;
            this.lbEliminarDepartamento.ItemHeight = 17;
            this.lbEliminarDepartamento.Location = new System.Drawing.Point(30, 52);
            this.lbEliminarDepartamento.Name = "lbEliminarDepartamento";
            this.lbEliminarDepartamento.Size = new System.Drawing.Size(381, 89);
            this.lbEliminarDepartamento.TabIndex = 8;
            // 
            // frmEliminarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 272);
            this.Controls.Add(this.gbListaDepartamentos);
            this.Name = "frmEliminarDepartamentos";
            this.Text = "Eliminar Departamentos";
            this.gbListaDepartamentos.ResumeLayout(false);
            this.gbListaDepartamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListaDepartamentos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEliminarDepartamento;
        private System.Windows.Forms.Label lbNombreDepartamento;
        private System.Windows.Forms.ListBox lbEliminarDepartamento;
    }
}