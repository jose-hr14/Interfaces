namespace Programa01_05
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtbA = new System.Windows.Forms.TextBox();
            this.txtbB = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.grbOperaciones = new System.Windows.Forms.GroupBox();
            this.radSumar = new System.Windows.Forms.RadioButton();
            this.radRestar = new System.Windows.Forms.RadioButton();
            this.radMultiplicar = new System.Windows.Forms.RadioButton();
            this.radDividir = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 41);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(12, 82);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B:";
            // 
            // txtbA
            // 
            this.txtbA.Location = new System.Drawing.Point(57, 38);
            this.txtbA.Name = "txtbA";
            this.txtbA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbA.Size = new System.Drawing.Size(100, 20);
            this.txtbA.TabIndex = 2;
            // 
            // txtbB
            // 
            this.txtbB.Location = new System.Drawing.Point(57, 75);
            this.txtbB.Name = "txtbB";
            this.txtbB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbB.Size = new System.Drawing.Size(100, 20);
            this.txtbB.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(57, 113);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(65, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "lblResultado";
            // 
            // grbOperaciones
            // 
            this.grbOperaciones.Controls.Add(this.radDividir);
            this.grbOperaciones.Controls.Add(this.radMultiplicar);
            this.grbOperaciones.Controls.Add(this.radRestar);
            this.grbOperaciones.Controls.Add(this.radSumar);
            this.grbOperaciones.Location = new System.Drawing.Point(57, 143);
            this.grbOperaciones.Name = "grbOperaciones";
            this.grbOperaciones.Size = new System.Drawing.Size(100, 111);
            this.grbOperaciones.TabIndex = 9;
            this.grbOperaciones.TabStop = false;
            this.grbOperaciones.Text = "Operaciones";
            // 
            // radSumar
            // 
            this.radSumar.AutoSize = true;
            this.radSumar.Checked = true;
            this.radSumar.Location = new System.Drawing.Point(7, 20);
            this.radSumar.Name = "radSumar";
            this.radSumar.Size = new System.Drawing.Size(55, 17);
            this.radSumar.TabIndex = 0;
            this.radSumar.TabStop = true;
            this.radSumar.Text = "Sumar";
            this.radSumar.UseVisualStyleBackColor = true;
            // 
            // radRestar
            // 
            this.radRestar.AutoSize = true;
            this.radRestar.Location = new System.Drawing.Point(7, 43);
            this.radRestar.Name = "radRestar";
            this.radRestar.Size = new System.Drawing.Size(56, 17);
            this.radRestar.TabIndex = 1;
            this.radRestar.Text = "Restar";
            this.radRestar.UseVisualStyleBackColor = true;
            // 
            // radMultiplicar
            // 
            this.radMultiplicar.AutoSize = true;
            this.radMultiplicar.Location = new System.Drawing.Point(7, 65);
            this.radMultiplicar.Name = "radMultiplicar";
            this.radMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.radMultiplicar.TabIndex = 2;
            this.radMultiplicar.Text = "Multiplicar";
            this.radMultiplicar.UseVisualStyleBackColor = true;
            // 
            // radDividir
            // 
            this.radDividir.AutoSize = true;
            this.radDividir.Location = new System.Drawing.Point(7, 88);
            this.radDividir.Name = "radDividir";
            this.radDividir.Size = new System.Drawing.Size(54, 17);
            this.radDividir.TabIndex = 3;
            this.radDividir.Text = "Dividir";
            this.radDividir.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(245, 53);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 278);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbOperaciones);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtbB);
            this.Controls.Add(this.txtbA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbOperaciones.ResumeLayout(false);
            this.grbOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtbA;
        private System.Windows.Forms.TextBox txtbB;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox grbOperaciones;
        private System.Windows.Forms.RadioButton radDividir;
        private System.Windows.Forms.RadioButton radMultiplicar;
        private System.Windows.Forms.RadioButton radRestar;
        private System.Windows.Forms.RadioButton radSumar;
        private System.Windows.Forms.Button btnCalcular;
    }
}

