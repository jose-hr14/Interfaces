
namespace Programa07_04
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblFechaComienzo = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.btnSeleccionarFecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 13);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(13, 348);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(49, 13);
            this.lblRange.TabIndex = 1;
            this.lblRange.Text = "lblRange";
            // 
            // lblFechaComienzo
            // 
            this.lblFechaComienzo.AutoSize = true;
            this.lblFechaComienzo.Location = new System.Drawing.Point(522, 9);
            this.lblFechaComienzo.Name = "lblFechaComienzo";
            this.lblFechaComienzo.Size = new System.Drawing.Size(93, 13);
            this.lblFechaComienzo.TabIndex = 2;
            this.lblFechaComienzo.Text = "lblFechaComienzo";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(522, 82);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(61, 13);
            this.lblFechaFin.TabIndex = 3;
            this.lblFechaFin.Text = "lblFechaFin";
            // 
            // btnSeleccionarFecha
            // 
            this.btnSeleccionarFecha.Location = new System.Drawing.Point(525, 152);
            this.btnSeleccionarFecha.Name = "btnSeleccionarFecha";
            this.btnSeleccionarFecha.Size = new System.Drawing.Size(120, 23);
            this.btnSeleccionarFecha.TabIndex = 4;
            this.btnSeleccionarFecha.Text = "Seleccionar fecha";
            this.btnSeleccionarFecha.UseVisualStyleBackColor = true;
            this.btnSeleccionarFecha.Click += new System.EventHandler(this.btnSeleccionarFecha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 373);
            this.Controls.Add(this.btnSeleccionarFecha);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaComienzo);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblFechaComienzo;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Button btnSeleccionarFecha;
    }
}

