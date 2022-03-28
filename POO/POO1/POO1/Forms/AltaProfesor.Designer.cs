namespace POO1.Forms
{
    partial class AltaProfesor
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtEscolaridad = new System.Windows.Forms.TextBox();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "escolaridad";
            // 
            // txtEscolaridad
            // 
            this.txtEscolaridad.Location = new System.Drawing.Point(197, 241);
            this.txtEscolaridad.Name = "txtEscolaridad";
            this.txtEscolaridad.Size = new System.Drawing.Size(100, 20);
            this.txtEscolaridad.TabIndex = 7;
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.Location = new System.Drawing.Point(91, 274);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(209, 23);
            this.btnAgregarProfesor.TabIndex = 8;
            this.btnAgregarProfesor.Text = "Agregar Profesor";
            this.btnAgregarProfesor.UseVisualStyleBackColor = true;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.btnAgregarProfesor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CVU";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // AltaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(469, 309);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarProfesor);
            this.Controls.Add(this.txtEscolaridad);
            this.Controls.Add(this.label4);
            this.Name = "AltaProfesor";
            this.Text = "AltaProfesor";
            this.Controls.SetChildIndex(this.txtClave, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtEdad, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtEscolaridad, 0);
            this.Controls.SetChildIndex(this.btnAgregarProfesor, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEscolaridad;
        private System.Windows.Forms.Button btnAgregarProfesor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}
