namespace Programa02_04A
{
    partial class Form2
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
            this.txbMensaje01 = new System.Windows.Forms.TextBox();
            this.txbMensaje02 = new System.Windows.Forms.TextBox();
            this.btnEnviarPrimerFormulario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbMensaje01
            // 
            this.txbMensaje01.Location = new System.Drawing.Point(49, 51);
            this.txbMensaje01.Name = "txbMensaje01";
            this.txbMensaje01.Size = new System.Drawing.Size(100, 20);
            this.txbMensaje01.TabIndex = 0;
            // 
            // txbMensaje02
            // 
            this.txbMensaje02.Location = new System.Drawing.Point(49, 77);
            this.txbMensaje02.Name = "txbMensaje02";
            this.txbMensaje02.Size = new System.Drawing.Size(100, 20);
            this.txbMensaje02.TabIndex = 1;
            // 
            // btnEnviarPrimerFormulario
            // 
            this.btnEnviarPrimerFormulario.Location = new System.Drawing.Point(172, 60);
            this.btnEnviarPrimerFormulario.Name = "btnEnviarPrimerFormulario";
            this.btnEnviarPrimerFormulario.Size = new System.Drawing.Size(139, 23);
            this.btnEnviarPrimerFormulario.TabIndex = 2;
            this.btnEnviarPrimerFormulario.Text = "Enviar al primer formulario";
            this.btnEnviarPrimerFormulario.UseVisualStyleBackColor = true;
            this.btnEnviarPrimerFormulario.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 262);
            this.Controls.Add(this.btnEnviarPrimerFormulario);
            this.Controls.Add(this.txbMensaje02);
            this.Controls.Add(this.txbMensaje01);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMensaje01;
        private System.Windows.Forms.TextBox txbMensaje02;
        private System.Windows.Forms.Button btnEnviarPrimerFormulario;
    }
}