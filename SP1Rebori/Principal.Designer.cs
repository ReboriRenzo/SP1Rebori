namespace SP1Rebori
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblSintepartSRL = new System.Windows.Forms.Label();
            this.imgImagen = new System.Windows.Forms.PictureBox();
            this.cmdIniciarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSintepartSRL
            // 
            this.lblSintepartSRL.AutoSize = true;
            this.lblSintepartSRL.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintepartSRL.Location = new System.Drawing.Point(21, 9);
            this.lblSintepartSRL.Name = "lblSintepartSRL";
            this.lblSintepartSRL.Size = new System.Drawing.Size(383, 78);
            this.lblSintepartSRL.TabIndex = 3;
            this.lblSintepartSRL.Text = "Sintepart SRL";
            this.lblSintepartSRL.Click += new System.EventHandler(this.lblSintepartSRL_Click);
            // 
            // imgImagen
            // 
            this.imgImagen.Image = ((System.Drawing.Image)(resources.GetObject("imgImagen.Image")));
            this.imgImagen.Location = new System.Drawing.Point(21, 90);
            this.imgImagen.Name = "imgImagen";
            this.imgImagen.Size = new System.Drawing.Size(383, 200);
            this.imgImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgImagen.TabIndex = 6;
            this.imgImagen.TabStop = false;
            // 
            // cmdIniciarSesion
            // 
            this.cmdIniciarSesion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciarSesion.Location = new System.Drawing.Point(136, 296);
            this.cmdIniciarSesion.Name = "cmdIniciarSesion";
            this.cmdIniciarSesion.Size = new System.Drawing.Size(153, 39);
            this.cmdIniciarSesion.TabIndex = 7;
            this.cmdIniciarSesion.Text = "Iniciar Sesion";
            this.cmdIniciarSesion.UseVisualStyleBackColor = true;
            this.cmdIniciarSesion.Click += new System.EventHandler(this.cmdIniciarSesion_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 361);
            this.Controls.Add(this.cmdIniciarSesion);
            this.Controls.Add(this.imgImagen);
            this.Controls.Add(this.lblSintepartSRL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSintepartSRL;
        private System.Windows.Forms.PictureBox imgImagen;
        private System.Windows.Forms.Button cmdIniciarSesion;
    }
}