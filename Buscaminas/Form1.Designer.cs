namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAlto = new System.Windows.Forms.Label();
            this.Cb1 = new System.Windows.Forms.ComboBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.Cb2 = new System.Windows.Forms.ComboBox();
            this.lblMinas = new System.Windows.Forms.Label();
            this.cbMinas = new System.Windows.Forms.ComboBox();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Location = new System.Drawing.Point(15, 32);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(25, 13);
            this.lblAlto.TabIndex = 0;
            this.lblAlto.Text = "Alto";
            this.lblAlto.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cb1
            // 
            this.Cb1.FormattingEnabled = true;
            this.Cb1.Location = new System.Drawing.Point(55, 32);
            this.Cb1.Name = "Cb1";
            this.Cb1.Size = new System.Drawing.Size(53, 21);
            this.Cb1.TabIndex = 1;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(156, 37);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(38, 13);
            this.lblAncho.TabIndex = 2;
            this.lblAncho.Text = "Ancho";
            // 
            // Cb2
            // 
            this.Cb2.FormattingEnabled = true;
            this.Cb2.Location = new System.Drawing.Point(202, 37);
            this.Cb2.Name = "Cb2";
            this.Cb2.Size = new System.Drawing.Size(54, 21);
            this.Cb2.TabIndex = 3;
            // 
            // lblMinas
            // 
            this.lblMinas.AutoSize = true;
            this.lblMinas.Location = new System.Drawing.Point(298, 42);
            this.lblMinas.Name = "lblMinas";
            this.lblMinas.Size = new System.Drawing.Size(35, 13);
            this.lblMinas.TabIndex = 4;
            this.lblMinas.Text = "Minas";
            // 
            // cbMinas
            // 
            this.cbMinas.FormattingEnabled = true;
            this.cbMinas.Location = new System.Drawing.Point(359, 42);
            this.cbMinas.Name = "cbMinas";
            this.cbMinas.Size = new System.Drawing.Size(65, 21);
            this.cbMinas.TabIndex = 5;
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(505, 36);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(88, 31);
            this.bCerrar.TabIndex = 6;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 417);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.cbMinas);
            this.Controls.Add(this.lblMinas);
            this.Controls.Add(this.Cb2);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.Cb1);
            this.Controls.Add(this.lblAlto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.ComboBox Cb1;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.ComboBox Cb2;
        private System.Windows.Forms.Label lblMinas;
        private System.Windows.Forms.ComboBox cbMinas;
        private System.Windows.Forms.Button bCerrar;
    }
}

