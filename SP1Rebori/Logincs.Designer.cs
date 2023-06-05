namespace SP1Rebori
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.ltsModulo = new System.Windows.Forms.ComboBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmbAceptar = new System.Windows.Forms.Button();
            this.IblModulo = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.IblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.IblUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltsModulo
            // 
            this.ltsModulo.ForeColor = System.Drawing.Color.Black;
            this.ltsModulo.FormattingEnabled = true;
            this.ltsModulo.Items.AddRange(new object[] {
            "ADM",
            "SIST",
            "COM",
            "VTA"});
            this.ltsModulo.Location = new System.Drawing.Point(93, 109);
            this.ltsModulo.Margin = new System.Windows.Forms.Padding(4);
            this.ltsModulo.Name = "ltsModulo";
            this.ltsModulo.Size = new System.Drawing.Size(116, 21);
            this.ltsModulo.TabIndex = 15;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.Black;
            this.cmdCancelar.Location = new System.Drawing.Point(232, 60);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(88, 28);
            this.cmdCancelar.TabIndex = 14;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbAceptar
            // 
            this.cmbAceptar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAceptar.ForeColor = System.Drawing.Color.Black;
            this.cmbAceptar.Location = new System.Drawing.Point(232, 10);
            this.cmbAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAceptar.Name = "cmbAceptar";
            this.cmbAceptar.Size = new System.Drawing.Size(88, 28);
            this.cmbAceptar.TabIndex = 13;
            this.cmbAceptar.Text = "Aceptar";
            this.cmbAceptar.UseVisualStyleBackColor = true;
            // 
            // IblModulo
            // 
            this.IblModulo.AutoSize = true;
            this.IblModulo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblModulo.ForeColor = System.Drawing.Color.Black;
            this.IblModulo.Location = new System.Drawing.Point(17, 111);
            this.IblModulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IblModulo.Name = "IblModulo";
            this.IblModulo.Size = new System.Drawing.Size(53, 17);
            this.IblModulo.TabIndex = 12;
            this.IblModulo.Text = "Modulo";
            // 
            // txtContraseña
            // 
            this.txtContraseña.ForeColor = System.Drawing.Color.Black;
            this.txtContraseña.Location = new System.Drawing.Point(95, 63);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '#';
            this.txtContraseña.Size = new System.Drawing.Size(116, 20);
            this.txtContraseña.TabIndex = 11;
            // 
            // IblContraseña
            // 
            this.IblContraseña.AutoSize = true;
            this.IblContraseña.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblContraseña.ForeColor = System.Drawing.Color.Black;
            this.IblContraseña.Location = new System.Drawing.Point(14, 65);
            this.IblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IblContraseña.Name = "IblContraseña";
            this.IblContraseña.Size = new System.Drawing.Size(78, 17);
            this.IblContraseña.TabIndex = 10;
            this.IblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(95, 13);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(116, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // IblUsuario
            // 
            this.IblUsuario.AutoSize = true;
            this.IblUsuario.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblUsuario.ForeColor = System.Drawing.Color.Black;
            this.IblUsuario.Location = new System.Drawing.Point(17, 15);
            this.IblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IblUsuario.Name = "IblUsuario";
            this.IblUsuario.Size = new System.Drawing.Size(55, 17);
            this.IblUsuario.TabIndex = 8;
            this.IblUsuario.Text = "Usuario";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 171);
            this.Controls.Add(this.ltsModulo);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmbAceptar);
            this.Controls.Add(this.IblModulo);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.IblContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.IblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "Logincs";
            this.Load += new System.EventHandler(this.Logincs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ltsModulo;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmbAceptar;
        private System.Windows.Forms.Label IblModulo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label IblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label IblUsuario;
    }
}