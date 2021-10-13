namespace Programa01_04
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
            this.grbPeriféricos = new System.Windows.Forms.GroupBox();
            this.chkMonitor = new System.Windows.Forms.CheckBox();
            this.chkTeclado = new System.Windows.Forms.CheckBox();
            this.chkRaton = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.lblTeclado = new System.Windows.Forms.Label();
            this.lblRaton = new System.Windows.Forms.Label();
            this.grbPeriféricos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPeriféricos
            // 
            this.grbPeriféricos.Controls.Add(this.chkRaton);
            this.grbPeriféricos.Controls.Add(this.chkTeclado);
            this.grbPeriféricos.Controls.Add(this.chkMonitor);
            this.grbPeriféricos.Location = new System.Drawing.Point(12, 12);
            this.grbPeriféricos.Name = "grbPeriféricos";
            this.grbPeriféricos.Size = new System.Drawing.Size(100, 93);
            this.grbPeriféricos.TabIndex = 0;
            this.grbPeriféricos.TabStop = false;
            this.grbPeriféricos.Text = "Periféricos";
            // 
            // chkMonitor
            // 
            this.chkMonitor.AutoSize = true;
            this.chkMonitor.Location = new System.Drawing.Point(7, 20);
            this.chkMonitor.Name = "chkMonitor";
            this.chkMonitor.Size = new System.Drawing.Size(88, 17);
            this.chkMonitor.TabIndex = 0;
            this.chkMonitor.Text = "Monitor 250€";
            this.chkMonitor.UseVisualStyleBackColor = true;
            this.chkMonitor.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
            // 
            // chkTeclado
            // 
            this.chkTeclado.AutoSize = true;
            this.chkTeclado.Location = new System.Drawing.Point(7, 44);
            this.chkTeclado.Name = "chkTeclado";
            this.chkTeclado.Size = new System.Drawing.Size(86, 17);
            this.chkTeclado.TabIndex = 1;
            this.chkTeclado.Text = "Teclado 15€";
            this.chkTeclado.UseVisualStyleBackColor = true;
            this.chkTeclado.CheckedChanged += new System.EventHandler(this.chkTeclado_CheckedChanged);
            // 
            // chkRaton
            // 
            this.chkRaton.AutoSize = true;
            this.chkRaton.Location = new System.Drawing.Point(7, 68);
            this.chkRaton.Name = "chkRaton";
            this.chkRaton.Size = new System.Drawing.Size(76, 17);
            this.chkRaton.TabIndex = 2;
            this.chkRaton.Text = "Ratón 20€";
            this.chkRaton.UseVisualStyleBackColor = true;
            this.chkRaton.CheckedChanged += new System.EventHandler(this.chkRaton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Location = new System.Drawing.Point(16, 119);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(52, 13);
            this.lblMonitor.TabIndex = 2;
            this.lblMonitor.Text = "lblMonitor";
            // 
            // lblTeclado
            // 
            this.lblTeclado.AutoSize = true;
            this.lblTeclado.Location = new System.Drawing.Point(16, 146);
            this.lblTeclado.Name = "lblTeclado";
            this.lblTeclado.Size = new System.Drawing.Size(56, 13);
            this.lblTeclado.TabIndex = 3;
            this.lblTeclado.Text = "lblTeclado";
            // 
            // lblRaton
            // 
            this.lblRaton.AutoSize = true;
            this.lblRaton.Location = new System.Drawing.Point(16, 174);
            this.lblRaton.Name = "lblRaton";
            this.lblRaton.Size = new System.Drawing.Size(46, 13);
            this.lblRaton.TabIndex = 4;
            this.lblRaton.Text = "lblRaton";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 216);
            this.Controls.Add(this.lblRaton);
            this.Controls.Add(this.lblTeclado);
            this.Controls.Add(this.lblMonitor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbPeriféricos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbPeriféricos.ResumeLayout(false);
            this.grbPeriféricos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPeriféricos;
        private System.Windows.Forms.CheckBox chkRaton;
        private System.Windows.Forms.CheckBox chkTeclado;
        private System.Windows.Forms.CheckBox chkMonitor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.Label lblTeclado;
        private System.Windows.Forms.Label lblRaton;
    }
}

