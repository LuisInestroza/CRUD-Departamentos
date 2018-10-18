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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNombreDepartamento = new System.Windows.Forms.Label();
            this.gbListaDepartamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaDepartamentos
            // 
            this.gbListaDepartamentos.Controls.Add(this.txtCRUD);
            this.gbListaDepartamentos.Controls.Add(this.btnEliminar);
            this.gbListaDepartamentos.Controls.Add(this.textBox1);
            this.gbListaDepartamentos.Controls.Add(this.lbNombreDepartamento);
            this.gbListaDepartamentos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListaDepartamentos.Location = new System.Drawing.Point(21, 24);
            this.gbListaDepartamentos.Name = "gbListaDepartamentos";
            this.gbListaDepartamentos.Size = new System.Drawing.Size(583, 274);
            this.gbListaDepartamentos.TabIndex = 2;
            this.gbListaDepartamentos.TabStop = false;
            this.gbListaDepartamentos.Text = "Lista de departamentos";
            // 
            // txtCRUD
            // 
            this.txtCRUD.Location = new System.Drawing.Point(9, 24);
            this.txtCRUD.Multiline = true;
            this.txtCRUD.Name = "txtCRUD";
            this.txtCRUD.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCRUD.Size = new System.Drawing.Size(522, 151);
            this.txtCRUD.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(436, 209);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 34);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 25);
            this.textBox1.TabIndex = 5;
            // 
            // lbNombreDepartamento
            // 
            this.lbNombreDepartamento.AutoSize = true;
            this.lbNombreDepartamento.Location = new System.Drawing.Point(38, 221);
            this.lbNombreDepartamento.Name = "lbNombreDepartamento";
            this.lbNombreDepartamento.Size = new System.Drawing.Size(64, 17);
            this.lbNombreDepartamento.TabIndex = 2;
            this.lbNombreDepartamento.Text = "Nombre:";
            // 
            // frmEliminarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 317);
            this.Controls.Add(this.gbListaDepartamentos);
            this.Name = "frmEliminarDepartamentos";
            this.Text = "Eliminar Departamentos";
            this.gbListaDepartamentos.ResumeLayout(false);
            this.gbListaDepartamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListaDepartamentos;
        private System.Windows.Forms.TextBox txtCRUD;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNombreDepartamento;
    }
}