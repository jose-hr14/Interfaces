namespace Febrero04_Access
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
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnLibreria = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLibros
            // 
            this.btnLibros.Location = new System.Drawing.Point(489, 132);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(75, 23);
            this.btnLibros.TabIndex = 0;
            this.btnLibros.Text = "Libros";
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnLibreria
            // 
            this.btnLibreria.Location = new System.Drawing.Point(489, 181);
            this.btnLibreria.Name = "btnLibreria";
            this.btnLibreria.Size = new System.Drawing.Size(75, 23);
            this.btnLibreria.TabIndex = 1;
            this.btnLibreria.Text = "Librería";
            this.btnLibreria.UseVisualStyleBackColor = true;
            this.btnLibreria.Click += new System.EventHandler(this.btnLibreria_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.Location = new System.Drawing.Point(489, 231);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(75, 23);
            this.btnAutores.TabIndex = 2;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 473);
            this.Controls.Add(this.btnAutores);
            this.Controls.Add(this.btnLibreria);
            this.Controls.Add(this.btnLibros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnLibreria;
        private System.Windows.Forms.Button btnAutores;
    }
}

