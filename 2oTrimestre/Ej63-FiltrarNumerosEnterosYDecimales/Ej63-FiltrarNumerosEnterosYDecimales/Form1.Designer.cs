
namespace Ej63_FiltrarNumerosEnterosYDecimales
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
            this.components = new System.ComponentModel.Container();
            this.lblEscribaNumero = new System.Windows.Forms.Label();
            this.txbNumeroProcesar = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNumeroProcesado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEscribaNumero
            // 
            this.lblEscribaNumero.AutoSize = true;
            this.lblEscribaNumero.Location = new System.Drawing.Point(25, 66);
            this.lblEscribaNumero.Name = "lblEscribaNumero";
            this.lblEscribaNumero.Size = new System.Drawing.Size(179, 13);
            this.lblEscribaNumero.TabIndex = 0;
            this.lblEscribaNumero.Text = "Escribe un número entero o decimal:";
            // 
            // txbNumeroProcesar
            // 
            this.txbNumeroProcesar.Location = new System.Drawing.Point(211, 66);
            this.txbNumeroProcesar.Name = "txbNumeroProcesar";
            this.txbNumeroProcesar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbNumeroProcesar.Size = new System.Drawing.Size(100, 20);
            this.txbNumeroProcesar.TabIndex = 1;
            this.txbNumeroProcesar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(211, 107);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(99, 23);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblNumeroProcesado
            // 
            this.lblNumeroProcesado.AutoSize = true;
            this.lblNumeroProcesado.Location = new System.Drawing.Point(211, 31);
            this.lblNumeroProcesado.Name = "lblNumeroProcesado";
            this.lblNumeroProcesado.Size = new System.Drawing.Size(97, 13);
            this.lblNumeroProcesado.TabIndex = 3;
            this.lblNumeroProcesado.Text = "Número procesado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumeroProcesado);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txbNumeroProcesar);
            this.Controls.Add(this.lblEscribaNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscribaNumero;
        private System.Windows.Forms.TextBox txbNumeroProcesar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblNumeroProcesado;
    }
}

