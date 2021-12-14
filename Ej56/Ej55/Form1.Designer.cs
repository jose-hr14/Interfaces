
namespace Ej55
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
            this.dgvNumeros = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblNombreProcesar = new System.Windows.Forms.Label();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txbNombreProcesar = new System.Windows.Forms.TextBox();
            this.txbNuevoNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNumeros
            // 
            this.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumeros.Location = new System.Drawing.Point(13, 13);
            this.dgvNumeros.Name = "dgvNumeros";
            this.dgvNumeros.Size = new System.Drawing.Size(319, 279);
            this.dgvNumeros.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(471, 57);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(471, 104);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(471, 155);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblNombreProcesar
            // 
            this.lblNombreProcesar.AutoSize = true;
            this.lblNombreProcesar.Location = new System.Drawing.Point(338, 129);
            this.lblNombreProcesar.Name = "lblNombreProcesar";
            this.lblNombreProcesar.Size = new System.Drawing.Size(100, 13);
            this.lblNombreProcesar.TabIndex = 13;
            this.lblNombreProcesar.Text = "Nombre a procesar:";
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(338, 67);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(80, 13);
            this.lblNuevoNombre.TabIndex = 12;
            this.lblNuevoNombre.Text = "Nuevo nombre:";
            // 
            // txbNombreProcesar
            // 
            this.txbNombreProcesar.Location = new System.Drawing.Point(338, 145);
            this.txbNombreProcesar.Name = "txbNombreProcesar";
            this.txbNombreProcesar.Size = new System.Drawing.Size(100, 20);
            this.txbNombreProcesar.TabIndex = 11;
            // 
            // txbNuevoNombre
            // 
            this.txbNuevoNombre.Location = new System.Drawing.Point(338, 86);
            this.txbNuevoNombre.Name = "txbNuevoNombre";
            this.txbNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNuevoNombre.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 304);
            this.Controls.Add(this.lblNombreProcesar);
            this.Controls.Add(this.lblNuevoNombre);
            this.Controls.Add(this.txbNombreProcesar);
            this.Controls.Add(this.txbNuevoNombre);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNumeros;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblNombreProcesar;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.TextBox txbNombreProcesar;
        private System.Windows.Forms.TextBox txbNuevoNombre;
    }
}

