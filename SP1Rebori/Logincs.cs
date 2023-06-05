using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1Rebori
{
    public partial class frmLogin : Form
    {
        int errores = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Logincs_Load(object sender, EventArgs e)
        {

        }

        private void cmbAceptar_Click(object sender, EventArgs e, frmBienvenidos frmBienvenidos)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string Modulo = ltsModulo.Text;
            frmBienvenidos fmrBienvenida = new frmBienvenidos();
            switch (usuario)
            {
                case "Adm":
                    if (contraseña == "@1a" & (Modulo == "ADM" || Modulo == "COM" || Modulo == "VTA"))
                    {
                        errores = 0;
                        this.Hide();
                        frmBienvenidos.Show();
                    }
                    else
                    {
                        MessageBox.Show("contraseña y modulo incorrecto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errores++;
                    }
                    break;
                case "Ceci":
                    if (contraseña == "*@3c" & (Modulo == "ADM" || Modulo == "VTA"))
                    {
                        errores = 0;
                        this.Hide();
                        fmrBienvenida.Show();
                    }
                    else
                    {
                        MessageBox.Show("contraseña y modulo incorrecto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errores++;

                    }
                    break;
                case "John":
                    if (contraseña == "*2b" & (Modulo == "SIST"))
                    {
                        errores = 0;
                        this.Hide();
                        fmrBienvenida.Show();
                    }
                    else
                    {
                        MessageBox.Show("contraseña y modulo incorrecto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errores++;

                    }
                    break;
                case "God":
                    if (contraseña == "*@#4d" & (Modulo == "SIST" || Modulo == "ADM" || Modulo == "COM" || Modulo == "VIA"))
                    {
                        errores = 0;
                        this.Hide();
                        fmrBienvenida.Show();
                    }
                    else
                    {
                        MessageBox.Show("contraseña y modulo incorrecto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errores++;

                    }
                    break;









            }
            if (errores == 2)
            {
                MessageBox.Show("Demasiados intentos fallidos,el formulario se cerrara");
                this.Close();

            }
        }
    }
}
