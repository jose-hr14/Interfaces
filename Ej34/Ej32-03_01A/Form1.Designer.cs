namespace Ej32_03_01A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dividirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.habilitarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtbA = new System.Windows.Forms.TextBox();
            this.txtbB = new System.Windows.Forms.TextBox();
            this.txtbAcontextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vaciarLaCajaDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escribirUnNúmeroAleatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.txtbAcontextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(345, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programaToolStripMenuItem
            // 
            this.programaToolStripMenuItem.AutoToolTip = true;
            this.programaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            this.programaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.programaToolStripMenuItem.Text = "Programa";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.ToolTipText = "Cierra el programa";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumarToolStripMenuItem,
            this.restarToolStripMenuItem,
            this.multiplicarToolStripMenuItem,
            this.dividirToolStripMenuItem,
            this.toolStripSeparator1,
            this.habilitarToolStripMenuItem1});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // sumarToolStripMenuItem
            // 
            this.sumarToolStripMenuItem.Name = "sumarToolStripMenuItem";
            this.sumarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.sumarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sumarToolStripMenuItem.Text = "Sumar";
            this.sumarToolStripMenuItem.Click += new System.EventHandler(this.sumarToolStripMenuItem_Click);
            // 
            // restarToolStripMenuItem
            // 
            this.restarToolStripMenuItem.Name = "restarToolStripMenuItem";
            this.restarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.restarToolStripMenuItem.Text = "Restar";
            this.restarToolStripMenuItem.Click += new System.EventHandler(this.restarToolStripMenuItem_Click);
            // 
            // multiplicarToolStripMenuItem
            // 
            this.multiplicarToolStripMenuItem.Name = "multiplicarToolStripMenuItem";
            this.multiplicarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.multiplicarToolStripMenuItem.Text = "Multiplicar";
            this.multiplicarToolStripMenuItem.Click += new System.EventHandler(this.multiplicarToolStripMenuItem_Click);
            // 
            // dividirToolStripMenuItem
            // 
            this.dividirToolStripMenuItem.Name = "dividirToolStripMenuItem";
            this.dividirToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.dividirToolStripMenuItem.Text = "Dividir";
            this.dividirToolStripMenuItem.Click += new System.EventHandler(this.dividirToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // habilitarToolStripMenuItem1
            // 
            this.habilitarToolStripMenuItem1.Checked = true;
            this.habilitarToolStripMenuItem1.CheckOnClick = true;
            this.habilitarToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.habilitarToolStripMenuItem1.Name = "habilitarToolStripMenuItem1";
            this.habilitarToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.habilitarToolStripMenuItem1.Text = "Habilitar";
            this.habilitarToolStripMenuItem1.CheckStateChanged += new System.EventHandler(this.toolStripMenuItem1_CheckStateChanged);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(50, 48);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "label1";
            // 
            // txtbA
            // 
            this.txtbA.ContextMenuStrip = this.txtbAcontextMenuStrip1;
            this.txtbA.Location = new System.Drawing.Point(27, 84);
            this.txtbA.Name = "txtbA";
            this.txtbA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbA.Size = new System.Drawing.Size(100, 20);
            this.txtbA.TabIndex = 2;
            // 
            // txtbB
            // 
            this.txtbB.Location = new System.Drawing.Point(27, 129);
            this.txtbB.Name = "txtbB";
            this.txtbB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbB.Size = new System.Drawing.Size(100, 20);
            this.txtbB.TabIndex = 3;
            // 
            // txtbAcontextMenuStrip1
            // 
            this.txtbAcontextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vaciarLaCajaDeTextoToolStripMenuItem,
            this.escribirUnNúmeroAleatorioToolStripMenuItem});
            this.txtbAcontextMenuStrip1.Name = "txtbAcontextMenuStrip1";
            this.txtbAcontextMenuStrip1.Size = new System.Drawing.Size(224, 48);
            // 
            // vaciarLaCajaDeTextoToolStripMenuItem
            // 
            this.vaciarLaCajaDeTextoToolStripMenuItem.Name = "vaciarLaCajaDeTextoToolStripMenuItem";
            this.vaciarLaCajaDeTextoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.vaciarLaCajaDeTextoToolStripMenuItem.Text = "Vaciar la caja de texto";
            this.vaciarLaCajaDeTextoToolStripMenuItem.Click += new System.EventHandler(this.vaciarLaCajaDeTextoToolStripMenuItem_Click);
            // 
            // escribirUnNúmeroAleatorioToolStripMenuItem
            // 
            this.escribirUnNúmeroAleatorioToolStripMenuItem.Name = "escribirUnNúmeroAleatorioToolStripMenuItem";
            this.escribirUnNúmeroAleatorioToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.escribirUnNúmeroAleatorioToolStripMenuItem.Text = "Escribir un número aleatorio";
            this.escribirUnNúmeroAleatorioToolStripMenuItem.Click += new System.EventHandler(this.escribirUnNúmeroAleatorioToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 304);
            this.Controls.Add(this.txtbB);
            this.Controls.Add(this.txtbA);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ej34";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.txtbAcontextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dividirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtbA;
        private System.Windows.Forms.TextBox txtbB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip txtbAcontextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vaciarLaCajaDeTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escribirUnNúmeroAleatorioToolStripMenuItem;
    }
}

