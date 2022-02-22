
namespace Programa07_01A
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
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.btnMostrarNumero = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lblNumeroMostrado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbNumero
            // 
            this.helpProvider1.SetHelpString(this.txbNumero, "Aquí escribimos el número");
            this.txbNumero.Location = new System.Drawing.Point(60, 141);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.helpProvider1.SetShowHelp(this.txbNumero, true);
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 0;
            // 
            // btnMostrarNumero
            // 
            this.helpProvider1.SetHelpString(this.btnMostrarNumero, "Pulsa para mostrar un número");
            this.btnMostrarNumero.Location = new System.Drawing.Point(243, 137);
            this.btnMostrarNumero.Name = "btnMostrarNumero";
            this.helpProvider1.SetShowHelp(this.btnMostrarNumero, true);
            this.btnMostrarNumero.Size = new System.Drawing.Size(93, 23);
            this.btnMostrarNumero.TabIndex = 1;
            this.btnMostrarNumero.Text = "Mostrar número";
            this.btnMostrarNumero.UseVisualStyleBackColor = true;
            this.btnMostrarNumero.Click += new System.EventHandler(this.btnMostrarNumero_Click);
            // 
            // lblNumeroMostrado
            // 
            this.lblNumeroMostrado.AutoSize = true;
            this.lblNumeroMostrado.Location = new System.Drawing.Point(62, 179);
            this.lblNumeroMostrado.Name = "lblNumeroMostrado";
            this.lblNumeroMostrado.Size = new System.Drawing.Size(98, 13);
            this.lblNumeroMostrado.TabIndex = 2;
            this.lblNumeroMostrado.Text = "lblNumeroMostrado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 365);
            this.Controls.Add(this.lblNumeroMostrado);
            this.Controls.Add(this.btnMostrarNumero);
            this.Controls.Add(this.txbNumero);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Button btnMostrarNumero;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lblNumeroMostrado;
    }
}

