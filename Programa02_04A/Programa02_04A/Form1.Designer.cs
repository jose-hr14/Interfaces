namespace Programa02_04A
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
            this.lblMensaje01 = new System.Windows.Forms.Label();
            this.lblMensaje02 = new System.Windows.Forms.Label();
            this.btnAbrirSegundoFormulario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensaje01
            // 
            this.lblMensaje01.AutoSize = true;
            this.lblMensaje01.Location = new System.Drawing.Point(40, 46);
            this.lblMensaje01.Name = "lblMensaje01";
            this.lblMensaje01.Size = new System.Drawing.Size(69, 13);
            this.lblMensaje01.TabIndex = 0;
            this.lblMensaje01.Text = "lblMensaje01";
            // 
            // lblMensaje02
            // 
            this.lblMensaje02.AutoSize = true;
            this.lblMensaje02.Location = new System.Drawing.Point(40, 82);
            this.lblMensaje02.Name = "lblMensaje02";
            this.lblMensaje02.Size = new System.Drawing.Size(69, 13);
            this.lblMensaje02.TabIndex = 1;
            this.lblMensaje02.Text = "lblMensaje02";
            // 
            // btnAbrirSegundoFormulario
            // 
            this.btnAbrirSegundoFormulario.Location = new System.Drawing.Point(144, 59);
            this.btnAbrirSegundoFormulario.Name = "btnAbrirSegundoFormulario";
            this.btnAbrirSegundoFormulario.Size = new System.Drawing.Size(162, 23);
            this.btnAbrirSegundoFormulario.TabIndex = 2;
            this.btnAbrirSegundoFormulario.Text = "Abrir segundo formulario";
            this.btnAbrirSegundoFormulario.UseVisualStyleBackColor = true;
            this.btnAbrirSegundoFormulario.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 220);
            this.Controls.Add(this.btnAbrirSegundoFormulario);
            this.Controls.Add(this.lblMensaje02);
            this.Controls.Add(this.lblMensaje01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje01;
        private System.Windows.Forms.Label lblMensaje02;
        private System.Windows.Forms.Button btnAbrirSegundoFormulario;
    }
}

