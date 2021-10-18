namespace Programa02_03B
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
            this.lblPropiedades = new System.Windows.Forms.Label();
            this.lblParametros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPropiedades
            // 
            this.lblPropiedades.AutoSize = true;
            this.lblPropiedades.Location = new System.Drawing.Point(47, 44);
            this.lblPropiedades.Name = "lblPropiedades";
            this.lblPropiedades.Size = new System.Drawing.Size(35, 13);
            this.lblPropiedades.TabIndex = 0;
            this.lblPropiedades.Text = "label1";
            // 
            // lblParametros
            // 
            this.lblParametros.AutoSize = true;
            this.lblParametros.Location = new System.Drawing.Point(47, 81);
            this.lblParametros.Name = "lblParametros";
            this.lblParametros.Size = new System.Drawing.Size(35, 13);
            this.lblParametros.TabIndex = 1;
            this.lblParametros.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 255);
            this.Controls.Add(this.lblParametros);
            this.Controls.Add(this.lblPropiedades);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPropiedades;
        private System.Windows.Forms.Label lblParametros;
    }
}