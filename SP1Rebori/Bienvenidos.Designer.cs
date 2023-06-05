namespace SP1Rebori
{
    partial class frmBienvenidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenidos));
            this.lblBienvenvido = new System.Windows.Forms.Label();
            this.lblSintepartSRL = new System.Windows.Forms.Label();
            this.imgImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenvido
            // 
            this.lblBienvenvido.AutoSize = true;
            this.lblBienvenvido.Font = new System.Drawing.Font("Yu Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenvido.Location = new System.Drawing.Point(33, 18);
            this.lblBienvenvido.Name = "lblBienvenvido";
            this.lblBienvenvido.Size = new System.Drawing.Size(417, 82);
            this.lblBienvenvido.TabIndex = 4;
            this.lblBienvenvido.Text = "Bienvenvido";
            // 
            // lblSintepartSRL
            // 
            this.lblSintepartSRL.AutoSize = true;
            this.lblSintepartSRL.Font = new System.Drawing.Font("Yu Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintepartSRL.Location = new System.Drawing.Point(12, 324);
            this.lblSintepartSRL.Name = "lblSintepartSRL";
            this.lblSintepartSRL.Size = new System.Drawing.Size(467, 82);
            this.lblSintepartSRL.TabIndex = 6;
            this.lblSintepartSRL.Text = "Sintepart SRL";
            // 
            // imgImagen
            // 
            this.imgImagen.Image = ((System.Drawing.Image)(resources.GetObject("imgImagen.Image")));
            this.imgImagen.Location = new System.Drawing.Point(105, 113);
            this.imgImagen.Name = "imgImagen";
            this.imgImagen.Size = new System.Drawing.Size(290, 199);
            this.imgImagen.TabIndex = 7;
            this.imgImagen.TabStop = false;
            // 
            // frmBienvenidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 421);
            this.Controls.Add(this.imgImagen);
            this.Controls.Add(this.lblSintepartSRL);
            this.Controls.Add(this.lblBienvenvido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBienvenidos";
            this.Text = "frmBienvenida";
            this.Load += new System.EventHandler(this.frmBienvenidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenvido;
        private System.Windows.Forms.Label lblSintepartSRL;
        private System.Windows.Forms.PictureBox imgImagen;
    }
}

