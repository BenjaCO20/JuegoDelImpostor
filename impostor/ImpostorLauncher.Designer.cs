namespace impostor
{
    partial class ImpostorLauncher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPalabras = new System.Windows.Forms.TextBox();
            this.btnAgregarPalabra = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.cantImpostor = new System.Windows.Forms.NumericUpDown();
            this.lblCantImp = new System.Windows.Forms.Label();
            this.lblCantJug = new System.Windows.Forms.Label();
            this.cantJug = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cantImpostor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantJug)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPalabras
            // 
            this.txtPalabras.Location = new System.Drawing.Point(17, 148);
            this.txtPalabras.Multiline = true;
            this.txtPalabras.Name = "txtPalabras";
            this.txtPalabras.Size = new System.Drawing.Size(310, 200);
            this.txtPalabras.TabIndex = 0;
            this.txtPalabras.TextChanged += new System.EventHandler(this.txtPalabras_TextChanged);
            // 
            // btnAgregarPalabra
            // 
            this.btnAgregarPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPalabra.Location = new System.Drawing.Point(104, 370);
            this.btnAgregarPalabra.Name = "btnAgregarPalabra";
            this.btnAgregarPalabra.Size = new System.Drawing.Size(131, 54);
            this.btnAgregarPalabra.TabIndex = 1;
            this.btnAgregarPalabra.Text = "Agregar palabra";
            this.btnAgregarPalabra.UseVisualStyleBackColor = true;
            this.btnAgregarPalabra.Click += new System.EventHandler(this.btnAgregarPalabra_Click);
            this.btnAgregarPalabra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAgregarPalabra_KeyPress);
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(501, 182);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(157, 82);
            this.btnJugar.TabIndex = 2;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // cantImpostor
            // 
            this.cantImpostor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantImpostor.Location = new System.Drawing.Point(17, 73);
            this.cantImpostor.Name = "cantImpostor";
            this.cantImpostor.Size = new System.Drawing.Size(120, 36);
            this.cantImpostor.TabIndex = 3;
            this.cantImpostor.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblCantImp
            // 
            this.lblCantImp.AutoSize = true;
            this.lblCantImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantImp.Location = new System.Drawing.Point(12, 12);
            this.lblCantImp.Name = "lblCantImp";
            this.lblCantImp.Size = new System.Drawing.Size(156, 58);
            this.lblCantImp.TabIndex = 4;
            this.lblCantImp.Text = "Cantidad de \r\nImpostores";
            this.lblCantImp.Click += new System.EventHandler(this.lblCantJug_Click);
            // 
            // lblCantJug
            // 
            this.lblCantJug.AutoSize = true;
            this.lblCantJug.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantJug.Location = new System.Drawing.Point(202, 12);
            this.lblCantJug.Name = "lblCantJug";
            this.lblCantJug.Size = new System.Drawing.Size(156, 58);
            this.lblCantJug.TabIndex = 5;
            this.lblCantJug.Text = "Cantidad de \r\nJugadores";
            // 
            // cantJug
            // 
            this.cantJug.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantJug.Location = new System.Drawing.Point(207, 73);
            this.cantJug.Name = "cantJug";
            this.cantJug.Size = new System.Drawing.Size(120, 36);
            this.cantJug.TabIndex = 6;
            // 
            // ImpostorLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cantJug);
            this.Controls.Add(this.lblCantJug);
            this.Controls.Add(this.lblCantImp);
            this.Controls.Add(this.cantImpostor);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnAgregarPalabra);
            this.Controls.Add(this.txtPalabras);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ImpostorLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImpostorLauncher";
            this.Load += new System.EventHandler(this.ImpostorPrincpal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantImpostor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantJug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalabras;
        private System.Windows.Forms.Button btnAgregarPalabra;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.NumericUpDown cantImpostor;
        private System.Windows.Forms.Label lblCantImp;
        private System.Windows.Forms.Label lblCantJug;
        private System.Windows.Forms.NumericUpDown cantJug;
    }
}