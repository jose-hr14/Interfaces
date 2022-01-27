namespace Programa07_07_ControlPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFormularioPrincipal1 = new System.Windows.Forms.Button();
            this.btnIrSegundoPanel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIrSegundoPanel);
            this.panel1.Controls.Add(this.btnFormularioPrincipal1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(61, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 108);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(611, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer panel";
            // 
            // btnFormularioPrincipal1
            // 
            this.btnFormularioPrincipal1.Location = new System.Drawing.Point(42, 366);
            this.btnFormularioPrincipal1.Name = "btnFormularioPrincipal1";
            this.btnFormularioPrincipal1.Size = new System.Drawing.Size(158, 23);
            this.btnFormularioPrincipal1.TabIndex = 1;
            this.btnFormularioPrincipal1.Text = "Ir al formulario principal";
            this.btnFormularioPrincipal1.UseVisualStyleBackColor = true;
            this.btnFormularioPrincipal1.Click += new System.EventHandler(this.btnFormularioPrincipal1_Click);
            // 
            // btnIrSegundoPanel
            // 
            this.btnIrSegundoPanel.Location = new System.Drawing.Point(560, 366);
            this.btnIrSegundoPanel.Name = "btnIrSegundoPanel";
            this.btnIrSegundoPanel.Size = new System.Drawing.Size(158, 23);
            this.btnIrSegundoPanel.TabIndex = 2;
            this.btnIrSegundoPanel.Text = "Ir al segundo panel";
            this.btnIrSegundoPanel.UseVisualStyleBackColor = true;
            this.btnIrSegundoPanel.Click += new System.EventHandler(this.btnIrSegundoPanel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Segundo panel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ir al formulario principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnFormularioPrincipal1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIrSegundoPanel;
        private System.Windows.Forms.Button btnFormularioPrincipal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

