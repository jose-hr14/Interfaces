
namespace Programa06_07
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
            this.btnTipoLetra = new System.Windows.Forms.Button();
            this.lblTextoPrueba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTipoLetra
            // 
            this.btnTipoLetra.Location = new System.Drawing.Point(190, 225);
            this.btnTipoLetra.Name = "btnTipoLetra";
            this.btnTipoLetra.Size = new System.Drawing.Size(75, 23);
            this.btnTipoLetra.TabIndex = 0;
            this.btnTipoLetra.Text = "Tipo de letra";
            this.btnTipoLetra.UseVisualStyleBackColor = true;
            this.btnTipoLetra.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTextoPrueba
            // 
            this.lblTextoPrueba.AutoSize = true;
            this.lblTextoPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoPrueba.Location = new System.Drawing.Point(57, 93);
            this.lblTextoPrueba.Name = "lblTextoPrueba";
            this.lblTextoPrueba.Size = new System.Drawing.Size(210, 31);
            this.lblTextoPrueba.TabIndex = 1;
            this.lblTextoPrueba.Text = "Texto de prueba";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 320);
            this.Controls.Add(this.lblTextoPrueba);
            this.Controls.Add(this.btnTipoLetra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTipoLetra;
        private System.Windows.Forms.Label lblTextoPrueba;
    }
}

