
namespace Ej62_SumaDiasALaFechaPresente
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
            this.dptCalendario = new System.Windows.Forms.DateTimePicker();
            this.lblFechaResultado = new System.Windows.Forms.Label();
            this.txbIntroducirFecha = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dptCalendario
            // 
            this.dptCalendario.Location = new System.Drawing.Point(32, 46);
            this.dptCalendario.Name = "dptCalendario";
            this.dptCalendario.Size = new System.Drawing.Size(200, 20);
            this.dptCalendario.TabIndex = 0;
            this.dptCalendario.ValueChanged += new System.EventHandler(this.dptCalendario_ValueChanged);
            // 
            // lblFechaResultado
            // 
            this.lblFechaResultado.AutoSize = true;
            this.lblFechaResultado.Location = new System.Drawing.Point(278, 52);
            this.lblFechaResultado.Name = "lblFechaResultado";
            this.lblFechaResultado.Size = new System.Drawing.Size(95, 13);
            this.lblFechaResultado.TabIndex = 1;
            this.lblFechaResultado.Text = "lblFechaResultado";
            // 
            // txbIntroducirFecha
            // 
            this.txbIntroducirFecha.Location = new System.Drawing.Point(281, 97);
            this.txbIntroducirFecha.Name = "txbIntroducirFecha";
            this.txbIntroducirFecha.Size = new System.Drawing.Size(100, 20);
            this.txbIntroducirFecha.TabIndex = 2;
            this.txbIntroducirFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(398, 97);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 297);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbIntroducirFecha);
            this.Controls.Add(this.lblFechaResultado);
            this.Controls.Add(this.dptCalendario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dptCalendario;
        private System.Windows.Forms.Label lblFechaResultado;
        private System.Windows.Forms.TextBox txbIntroducirFecha;
        private System.Windows.Forms.Button btnCalcular;
    }
}

