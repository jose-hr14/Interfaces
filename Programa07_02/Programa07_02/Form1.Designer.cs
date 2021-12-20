
namespace Programa07_02
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
            this.grbMaskedTextBox = new System.Windows.Forms.GroupBox();
            this.grbTextBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNombre1 = new System.Windows.Forms.TextBox();
            this.txbEdad1 = new System.Windows.Forms.TextBox();
            this.btnProcesar1 = new System.Windows.Forms.Button();
            this.btnProcesar2 = new System.Windows.Forms.Button();
            this.mktxbNombre = new System.Windows.Forms.MaskedTextBox();
            this.mktxbEdad = new System.Windows.Forms.MaskedTextBox();
            this.grbMaskedTextBox.SuspendLayout();
            this.grbTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMaskedTextBox
            // 
            this.grbMaskedTextBox.Controls.Add(this.btnProcesar1);
            this.grbMaskedTextBox.Controls.Add(this.txbEdad1);
            this.grbMaskedTextBox.Controls.Add(this.txbNombre1);
            this.grbMaskedTextBox.Controls.Add(this.label2);
            this.grbMaskedTextBox.Controls.Add(this.label1);
            this.grbMaskedTextBox.Location = new System.Drawing.Point(13, 13);
            this.grbMaskedTextBox.Name = "grbMaskedTextBox";
            this.grbMaskedTextBox.Size = new System.Drawing.Size(700, 172);
            this.grbMaskedTextBox.TabIndex = 0;
            this.grbMaskedTextBox.TabStop = false;
            this.grbMaskedTextBox.Text = "Masked TextBox";
            // 
            // grbTextBox
            // 
            this.grbTextBox.Controls.Add(this.mktxbEdad);
            this.grbTextBox.Controls.Add(this.mktxbNombre);
            this.grbTextBox.Controls.Add(this.btnProcesar2);
            this.grbTextBox.Controls.Add(this.label4);
            this.grbTextBox.Controls.Add(this.label3);
            this.grbTextBox.Location = new System.Drawing.Point(13, 192);
            this.grbTextBox.Name = "grbTextBox";
            this.grbTextBox.Size = new System.Drawing.Size(700, 161);
            this.grbTextBox.TabIndex = 1;
            this.grbTextBox.TabStop = false;
            this.grbTextBox.Text = "TextBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre (máximo cinco carácteres): ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad (máximo dos dígitos): ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad (máximo dos dígitos): ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre (máximo cinco carácteres): ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbNombre1
            // 
            this.txbNombre1.Location = new System.Drawing.Point(298, 47);
            this.txbNombre1.Name = "txbNombre1";
            this.txbNombre1.Size = new System.Drawing.Size(100, 20);
            this.txbNombre1.TabIndex = 2;
            // 
            // txbEdad1
            // 
            this.txbEdad1.Location = new System.Drawing.Point(298, 83);
            this.txbEdad1.Name = "txbEdad1";
            this.txbEdad1.Size = new System.Drawing.Size(100, 20);
            this.txbEdad1.TabIndex = 3;
            // 
            // btnProcesar1
            // 
            this.btnProcesar1.Location = new System.Drawing.Point(455, 67);
            this.btnProcesar1.Name = "btnProcesar1";
            this.btnProcesar1.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar1.TabIndex = 4;
            this.btnProcesar1.Text = "Procesar";
            this.btnProcesar1.UseVisualStyleBackColor = true;
            // 
            // btnProcesar2
            // 
            this.btnProcesar2.Location = new System.Drawing.Point(455, 63);
            this.btnProcesar2.Name = "btnProcesar2";
            this.btnProcesar2.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar2.TabIndex = 6;
            this.btnProcesar2.Text = "Procesar";
            this.btnProcesar2.UseVisualStyleBackColor = true;
            // 
            // mktxbNombre
            // 
            this.mktxbNombre.Location = new System.Drawing.Point(298, 41);
            this.mktxbNombre.Name = "mktxbNombre";
            this.mktxbNombre.Size = new System.Drawing.Size(100, 20);
            this.mktxbNombre.TabIndex = 7;
            // 
            // mktxbEdad
            // 
            this.mktxbEdad.Location = new System.Drawing.Point(298, 86);
            this.mktxbEdad.Name = "mktxbEdad";
            this.mktxbEdad.Size = new System.Drawing.Size(100, 20);
            this.mktxbEdad.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 355);
            this.Controls.Add(this.grbTextBox);
            this.Controls.Add(this.grbMaskedTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbMaskedTextBox.ResumeLayout(false);
            this.grbMaskedTextBox.PerformLayout();
            this.grbTextBox.ResumeLayout(false);
            this.grbTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMaskedTextBox;
        private System.Windows.Forms.Button btnProcesar1;
        private System.Windows.Forms.TextBox txbEdad1;
        private System.Windows.Forms.TextBox txbNombre1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTextBox;
        private System.Windows.Forms.Button btnProcesar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mktxbEdad;
        private System.Windows.Forms.MaskedTextBox mktxbNombre;
    }
}

