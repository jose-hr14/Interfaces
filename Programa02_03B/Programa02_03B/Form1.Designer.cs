namespace Programa02_03B
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
            this.txbPropiedades = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbParametros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbPropiedades
            // 
            this.txbPropiedades.Location = new System.Drawing.Point(32, 43);
            this.txbPropiedades.Name = "txbPropiedades";
            this.txbPropiedades.Size = new System.Drawing.Size(100, 20);
            this.txbPropiedades.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txbParametros
            // 
            this.txbParametros.Location = new System.Drawing.Point(32, 70);
            this.txbParametros.Name = "txbParametros";
            this.txbParametros.Size = new System.Drawing.Size(100, 20);
            this.txbParametros.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 266);
            this.Controls.Add(this.txbParametros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbPropiedades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPropiedades;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbParametros;
    }
}

