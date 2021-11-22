
namespace CalculadoraTiempoLlenado
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
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.cbDeposito = new System.Windows.Forms.ComboBox();
            this.cbCaudal = new System.Windows.Forms.ComboBox();
            this.txbDeposito = new System.Windows.Forms.TextBox();
            this.txbCaudal = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.lblCaudal = new System.Windows.Forms.Label();
            this.grbTarea = new System.Windows.Forms.GroupBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTiempoEstimado = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbDatos.SuspendLayout();
            this.grbTarea.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.cbDeposito);
            this.grbDatos.Controls.Add(this.cbCaudal);
            this.grbDatos.Controls.Add(this.txbDeposito);
            this.grbDatos.Controls.Add(this.txbCaudal);
            this.grbDatos.Controls.Add(this.lblDeposito);
            this.grbDatos.Controls.Add(this.lblCaudal);
            this.grbDatos.Location = new System.Drawing.Point(12, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(776, 193);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos para calcular el tiempo de llenado";
            // 
            // cbDeposito
            // 
            this.cbDeposito.FormattingEnabled = true;
            this.cbDeposito.Items.AddRange(new object[] {
            "cm³",
            "dm³",
            "m³"});
            this.cbDeposito.Location = new System.Drawing.Point(443, 95);
            this.cbDeposito.Name = "cbDeposito";
            this.cbDeposito.Size = new System.Drawing.Size(88, 21);
            this.cbDeposito.TabIndex = 5;
            this.cbDeposito.Text = "Seleccionar";
            // 
            // cbCaudal
            // 
            this.cbCaudal.FormattingEnabled = true;
            this.cbCaudal.Items.AddRange(new object[] {
            "cm³/seg",
            "dm³/seg",
            "m³/seg"});
            this.cbCaudal.Location = new System.Drawing.Point(443, 45);
            this.cbCaudal.Name = "cbCaudal";
            this.cbCaudal.Size = new System.Drawing.Size(88, 21);
            this.cbCaudal.TabIndex = 4;
            this.cbCaudal.Text = "Seleccionar";
            // 
            // txbDeposito
            // 
            this.txbDeposito.Location = new System.Drawing.Point(316, 96);
            this.txbDeposito.Name = "txbDeposito";
            this.txbDeposito.Size = new System.Drawing.Size(100, 20);
            this.txbDeposito.TabIndex = 3;
            this.txbDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbCaudal
            // 
            this.txbCaudal.Location = new System.Drawing.Point(316, 45);
            this.txbCaudal.Name = "txbCaudal";
            this.txbCaudal.Size = new System.Drawing.Size(100, 20);
            this.txbCaudal.TabIndex = 2;
            this.txbCaudal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Location = new System.Drawing.Point(159, 99);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(151, 13);
            this.lblDeposito.TabIndex = 1;
            this.lblDeposito.Text = "Tamaño del depósito de agua:";
            // 
            // lblCaudal
            // 
            this.lblCaudal.AutoSize = true;
            this.lblCaudal.Location = new System.Drawing.Point(180, 48);
            this.lblCaudal.Name = "lblCaudal";
            this.lblCaudal.Size = new System.Drawing.Size(130, 13);
            this.lblCaudal.TabIndex = 0;
            this.lblCaudal.Text = "Caudal de salida de agua:";
            // 
            // grbTarea
            // 
            this.grbTarea.Controls.Add(this.btnTerminar);
            this.grbTarea.Controls.Add(this.btnLimpiar);
            this.grbTarea.Controls.Add(this.btnCalcular);
            this.grbTarea.Controls.Add(this.lblTiempoEstimado);
            this.grbTarea.Location = new System.Drawing.Point(12, 211);
            this.grbTarea.Name = "grbTarea";
            this.grbTarea.Size = new System.Drawing.Size(776, 227);
            this.grbTarea.TabIndex = 1;
            this.grbTarea.TabStop = false;
            this.grbTarea.Text = "Tarea a realizar";
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(469, 153);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(75, 23);
            this.btnTerminar.TabIndex = 3;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(329, 153);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(193, 153);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTiempoEstimado
            // 
            this.lblTiempoEstimado.AutoSize = true;
            this.lblTiempoEstimado.Location = new System.Drawing.Point(118, 91);
            this.lblTiempoEstimado.Name = "lblTiempoEstimado";
            this.lblTiempoEstimado.Size = new System.Drawing.Size(95, 13);
            this.lblTiempoEstimado.TabIndex = 0;
            this.lblTiempoEstimado.Text = "lblTiempoEstimado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbTarea);
            this.Controls.Add(this.grbDatos);
            this.Name = "Form1";
            this.Text = "Calculadora de tiempo de llenado";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbTarea.ResumeLayout(false);
            this.grbTarea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Label lblCaudal;
        private System.Windows.Forms.ComboBox cbDeposito;
        private System.Windows.Forms.ComboBox cbCaudal;
        private System.Windows.Forms.TextBox txbDeposito;
        private System.Windows.Forms.TextBox txbCaudal;
        private System.Windows.Forms.GroupBox grbTarea;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTiempoEstimado;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

