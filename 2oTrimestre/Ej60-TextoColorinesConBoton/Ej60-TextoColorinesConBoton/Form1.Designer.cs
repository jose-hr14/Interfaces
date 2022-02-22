
namespace Ej60_TextoColorinesConBoton
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
            this.lblTextoPrueba = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextoPrueba
            // 
            this.lblTextoPrueba.AutoSize = true;
            this.lblTextoPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoPrueba.ForeColor = System.Drawing.Color.Chocolate;
            this.lblTextoPrueba.Location = new System.Drawing.Point(165, 78);
            this.lblTextoPrueba.Name = "lblTextoPrueba";
            this.lblTextoPrueba.Size = new System.Drawing.Size(168, 26);
            this.lblTextoPrueba.TabIndex = 0;
            this.lblTextoPrueba.Text = "Texto de prueba";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(217, 181);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 313);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblTextoPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoPrueba;
        private System.Windows.Forms.Button btnColor;
    }
}

