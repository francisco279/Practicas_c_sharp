namespace POO1.Forms
{
    partial class ALtaChofer
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
            this.cbLicencia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarChofer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // cbLicencia
            // 
            this.cbLicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicencia.FormattingEnabled = true;
            this.cbLicencia.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbLicencia.Location = new System.Drawing.Point(200, 213);
            this.cbLicencia.Name = "cbLicencia";
            this.cbLicencia.Size = new System.Drawing.Size(121, 21);
            this.cbLicencia.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de licencia";
            // 
            // btnAgregarChofer
            // 
            this.btnAgregarChofer.Location = new System.Drawing.Point(92, 260);
            this.btnAgregarChofer.Name = "btnAgregarChofer";
            this.btnAgregarChofer.Size = new System.Drawing.Size(229, 23);
            this.btnAgregarChofer.TabIndex = 9;
            this.btnAgregarChofer.Text = "Agregar Chofer";
            this.btnAgregarChofer.UseVisualStyleBackColor = true;
            this.btnAgregarChofer.Click += new System.EventHandler(this.button1_Click);
            // 
            // ALtaChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(469, 309);
            this.Controls.Add(this.btnAgregarChofer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbLicencia);
            this.Controls.Add(this.label4);
            this.Name = "ALtaChofer";
            this.Text = "Alta Choferes";
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbLicencia, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnAgregarChofer, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLicencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarChofer;
    }
}
