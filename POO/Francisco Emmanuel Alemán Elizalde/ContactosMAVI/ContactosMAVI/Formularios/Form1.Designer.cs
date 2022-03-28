namespace ContactosMAVI
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMostrarTodos = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnAñadirContacto = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(695, 35);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Eliminar Contacto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMostrarTodos
            // 
            this.txtMostrarTodos.Location = new System.Drawing.Point(695, 116);
            this.txtMostrarTodos.Name = "txtMostrarTodos";
            this.txtMostrarTodos.Size = new System.Drawing.Size(195, 23);
            this.txtMostrarTodos.TabIndex = 4;
            this.txtMostrarTodos.Text = "Actualizar Tabla";
            this.txtMostrarTodos.UseVisualStyleBackColor = true;
            this.txtMostrarTodos.Click += new System.EventHandler(this.txtMostrarTodos_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(12, 309);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(195, 23);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "Ver Contacto";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAñadirContacto
            // 
            this.btnAñadirContacto.Location = new System.Drawing.Point(213, 309);
            this.btnAñadirContacto.Name = "btnAñadirContacto";
            this.btnAñadirContacto.Size = new System.Drawing.Size(195, 23);
            this.btnAñadirContacto.TabIndex = 6;
            this.btnAñadirContacto.Text = "Añadir Contacto";
            this.btnAñadirContacto.UseVisualStyleBackColor = true;
            this.btnAñadirContacto.Click += new System.EventHandler(this.btnAñadirContacto_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(414, 309);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(195, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar Contacto";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 498);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAñadirContacto);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtMostrarTodos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button txtMostrarTodos;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnAñadirContacto;
        private System.Windows.Forms.Button btnEditar;
    }
}

