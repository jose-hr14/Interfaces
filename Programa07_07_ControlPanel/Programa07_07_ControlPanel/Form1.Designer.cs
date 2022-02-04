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
            this.btnIrSegundoPanel = new System.Windows.Forms.Button();
            this.btnFormularioPrincipal1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIrFormularioPrincipal2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIrPrimerPanel2 = new System.Windows.Forms.Button();
            this.lblFormularioPrincipal = new System.Windows.Forms.Label();
            this.btnIrPrimerPanel = new System.Windows.Forms.Button();
            this.btnIrSegundoPanel1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIrSegundoPanel);
            this.panel1.Controls.Add(this.btnFormularioPrincipal1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
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
            // btnFormularioPrincipal1
            // 
            this.btnFormularioPrincipal1.Location = new System.Drawing.Point(42, 366);
            this.btnFormularioPrincipal1.Name = "btnFormularioPrincipal1";
            this.btnFormularioPrincipal1.Size = new System.Drawing.Size(208, 23);
            this.btnFormularioPrincipal1.TabIndex = 1;
            this.btnFormularioPrincipal1.Text = "Ir al formulario principal";
            this.btnFormularioPrincipal1.UseVisualStyleBackColor = true;
            this.btnFormularioPrincipal1.Click += new System.EventHandler(this.btnFormularioPrincipal1_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIrPrimerPanel2);
            this.panel2.Controls.Add(this.btnIrFormularioPrincipal2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 1;
            // 
            // btnIrFormularioPrincipal2
            // 
            this.btnIrFormularioPrincipal2.Location = new System.Drawing.Point(61, 374);
            this.btnIrFormularioPrincipal2.Name = "btnIrFormularioPrincipal2";
            this.btnIrFormularioPrincipal2.Size = new System.Drawing.Size(162, 23);
            this.btnIrFormularioPrincipal2.TabIndex = 1;
            this.btnIrFormularioPrincipal2.Text = "Ir al formulario principal";
            this.btnIrFormularioPrincipal2.UseVisualStyleBackColor = true;
            this.btnIrFormularioPrincipal2.Click += new System.EventHandler(this.btnFormularioPrincipal1_Click);
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
            // btnIrPrimerPanel2
            // 
            this.btnIrPrimerPanel2.Location = new System.Drawing.Point(633, 374);
            this.btnIrPrimerPanel2.Name = "btnIrPrimerPanel2";
            this.btnIrPrimerPanel2.Size = new System.Drawing.Size(137, 23);
            this.btnIrPrimerPanel2.TabIndex = 2;
            this.btnIrPrimerPanel2.Text = "Ir al primer panel";
            this.btnIrPrimerPanel2.UseVisualStyleBackColor = true;
            this.btnIrPrimerPanel2.Click += new System.EventHandler(this.btnIrPrimerPanel2_Click);
            // 
            // lblFormularioPrincipal
            // 
            this.lblFormularioPrincipal.AutoSize = true;
            this.lblFormularioPrincipal.Location = new System.Drawing.Point(319, 45);
            this.lblFormularioPrincipal.Name = "lblFormularioPrincipal";
            this.lblFormularioPrincipal.Size = new System.Drawing.Size(125, 16);
            this.lblFormularioPrincipal.TabIndex = 2;
            this.lblFormularioPrincipal.Text = "Formulario principal";
            // 
            // btnIrPrimerPanel
            // 
            this.btnIrPrimerPanel.Location = new System.Drawing.Point(72, 385);
            this.btnIrPrimerPanel.Name = "btnIrPrimerPanel";
            this.btnIrPrimerPanel.Size = new System.Drawing.Size(179, 23);
            this.btnIrPrimerPanel.TabIndex = 3;
            this.btnIrPrimerPanel.Text = "Ir al primer panel";
            this.btnIrPrimerPanel.UseVisualStyleBackColor = true;
            this.btnIrPrimerPanel.Click += new System.EventHandler(this.btnIrPrimerPanel2_Click);
            // 
            // btnIrSegundoPanel1
            // 
            this.btnIrSegundoPanel1.Location = new System.Drawing.Point(621, 385);
            this.btnIrSegundoPanel1.Name = "btnIrSegundoPanel1";
            this.btnIrSegundoPanel1.Size = new System.Drawing.Size(145, 23);
            this.btnIrSegundoPanel1.TabIndex = 4;
            this.btnIrSegundoPanel1.Text = "Ir al segundo panel";
            this.btnIrSegundoPanel1.UseVisualStyleBackColor = true;
            this.btnIrSegundoPanel1.Click += new System.EventHandler(this.btnIrSegundoPanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIrSegundoPanel1);
            this.Controls.Add(this.btnIrPrimerPanel);
            this.Controls.Add(this.lblFormularioPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIrSegundoPanel;
        private System.Windows.Forms.Button btnFormularioPrincipal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIrFormularioPrincipal2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIrPrimerPanel2;
        private System.Windows.Forms.Label lblFormularioPrincipal;
        private System.Windows.Forms.Button btnIrPrimerPanel;
        private System.Windows.Forms.Button btnIrSegundoPanel1;
    }
}

