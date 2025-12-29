namespace impostor
{
    partial class Impostor
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.txtPalabrasImpostor = new System.Windows.Forms.TextBox();
            this.btnEmpezarRonda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(149, 339);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(145, 66);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar palabra";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(390, 339);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(145, 66);
            this.btnOcultar.TabIndex = 1;
            this.btnOcultar.Text = "Ocultar palabra";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // txtPalabrasImpostor
            // 
            this.txtPalabrasImpostor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPalabrasImpostor.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalabrasImpostor.Location = new System.Drawing.Point(122, 108);
            this.txtPalabrasImpostor.Multiline = true;
            this.txtPalabrasImpostor.Name = "txtPalabrasImpostor";
            this.txtPalabrasImpostor.ReadOnly = true;
            this.txtPalabrasImpostor.Size = new System.Drawing.Size(445, 205);
            this.txtPalabrasImpostor.TabIndex = 2;
            this.txtPalabrasImpostor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPalabrasImpostor.TextChanged += new System.EventHandler(this.txtPalabrasImpostor_TextChanged);
            // 
            // btnEmpezarRonda
            // 
            this.btnEmpezarRonda.Location = new System.Drawing.Point(261, 23);
            this.btnEmpezarRonda.Name = "btnEmpezarRonda";
            this.btnEmpezarRonda.Size = new System.Drawing.Size(158, 69);
            this.btnEmpezarRonda.TabIndex = 3;
            this.btnEmpezarRonda.Text = "Empezar Ronda";
            this.btnEmpezarRonda.UseVisualStyleBackColor = true;
            this.btnEmpezarRonda.Click += new System.EventHandler(this.btnEmpezarRonda_Click);
            // 
            // Impostor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 451);
            this.Controls.Add(this.btnEmpezarRonda);
            this.Controls.Add(this.txtPalabrasImpostor);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.btnMostrar);
            this.MaximumSize = new System.Drawing.Size(746, 498);
            this.MinimumSize = new System.Drawing.Size(746, 498);
            this.Name = "Impostor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impostor";
            this.Load += new System.EventHandler(this.Impostor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.TextBox txtPalabrasImpostor;
        private System.Windows.Forms.Button btnEmpezarRonda;
    }
}

