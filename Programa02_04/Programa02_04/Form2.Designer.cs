namespace Programa02_04
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
            this.lblParametro = new System.Windows.Forms.Label();
            this.lblParametros2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(95, 53);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(35, 13);
            this.lblParametro.TabIndex = 0;
            this.lblParametro.Text = "label1";
            // 
            // lblParametros2
            // 
            this.lblParametros2.AutoSize = true;
            this.lblParametros2.Location = new System.Drawing.Point(95, 98);
            this.lblParametros2.Name = "lblParametros2";
            this.lblParametros2.Size = new System.Drawing.Size(35, 13);
            this.lblParametros2.TabIndex = 1;
            this.lblParametros2.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 192);
            this.Controls.Add(this.lblParametros2);
            this.Controls.Add(this.lblParametro);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.Label lblParametros2;
    }
}