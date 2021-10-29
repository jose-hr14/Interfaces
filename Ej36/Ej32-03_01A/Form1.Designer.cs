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
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtbA = new System.Windows.Forms.TextBox();
            this.txtbAcontextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vaciarLaCajaDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escribirUnNúmeroAleatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbB = new System.Windows.Forms.TextBox();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AtoolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtoolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.OperaciontoolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.RtoolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtbAcontextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(59, 106);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "label1";
            // 
            // txtbA
            // 
            this.txtbA.ContextMenuStrip = this.txtbAcontextMenuStrip1;
            this.txtbA.Location = new System.Drawing.Point(36, 142);
            this.txtbA.Name = "txtbA";
            this.txtbA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbA.Size = new System.Drawing.Size(100, 20);
            this.txtbA.TabIndex = 2;
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
            // txtbB
            // 
            this.txtbB.Location = new System.Drawing.Point(36, 187);
            this.txtbB.Name = "txtbB";
            this.txtbB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbB.Size = new System.Drawing.Size(100, 20);
            this.txtbB.TabIndex = 3;
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
            this.menuStrip1.TabIndex = 5;
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
            // 
            // restarToolStripMenuItem
            // 
            this.restarToolStripMenuItem.Name = "restarToolStripMenuItem";
            this.restarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.restarToolStripMenuItem.Text = "Restar";
            // 
            // multiplicarToolStripMenuItem
            // 
            this.multiplicarToolStripMenuItem.Name = "multiplicarToolStripMenuItem";
            this.multiplicarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.multiplicarToolStripMenuItem.Text = "Multiplicar";
            // 
            // dividirToolStripMenuItem
            // 
            this.dividirToolStripMenuItem.Name = "dividirToolStripMenuItem";
            this.dividirToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.dividirToolStripMenuItem.Text = "Dividir";
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
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(345, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AtoolStripStatusLabel1,
            this.BtoolStripStatusLabel2,
            this.OperaciontoolStripStatusLabel3,
            this.RtoolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 280);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(345, 24);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AtoolStripStatusLabel1
            // 
            this.AtoolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.AtoolStripStatusLabel1.Name = "AtoolStripStatusLabel1";
            this.AtoolStripStatusLabel1.Size = new System.Drawing.Size(33, 19);
            this.AtoolStripStatusLabel1.Text = "A=0";
            // 
            // BtoolStripStatusLabel2
            // 
            this.BtoolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.BtoolStripStatusLabel2.Name = "BtoolStripStatusLabel2";
            this.BtoolStripStatusLabel2.Size = new System.Drawing.Size(32, 19);
            this.BtoolStripStatusLabel2.Text = "B=0";
            // 
            // OperaciontoolStripStatusLabel3
            // 
            this.OperaciontoolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.OperaciontoolStripStatusLabel3.Name = "OperaciontoolStripStatusLabel3";
            this.OperaciontoolStripStatusLabel3.Size = new System.Drawing.Size(154, 19);
            this.OperaciontoolStripStatusLabel3.Text = "Operación no seleccionada";
            // 
            // RtoolStripStatusLabel4
            // 
            this.RtoolStripStatusLabel4.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.RtoolStripStatusLabel4.Name = "RtoolStripStatusLabel4";
            this.RtoolStripStatusLabel4.Size = new System.Drawing.Size(32, 19);
            this.RtoolStripStatusLabel4.Text = "R=0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ej32_03_01A.Properties.Resources.Elon_Musk_empieza_a_trabajar_con_desarrolladores_de_Dogecoin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(345, 304);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtbB);
            this.Controls.Add(this.txtbA);
            this.Controls.Add(this.lblResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ej36";
            this.txtbAcontextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtbA;
        private System.Windows.Forms.TextBox txtbB;
        private System.Windows.Forms.ContextMenuStrip txtbAcontextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vaciarLaCajaDeTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escribirUnNúmeroAleatorioToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dividirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel AtoolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel BtoolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel OperaciontoolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel RtoolStripStatusLabel4;
    }
}

