using Proy_InstitutecBE;
using Proy_InstitutecBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyInstitutec_GUI
{
    public partial class frmLogin : Form
    {
        Int16 intentos = 0;
        Int16 tiempo = 30;

        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBl objUsuarioBL = new UsuarioBl();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        bool autentic = false;

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtLogin.Text.Trim() != "" & txtPassword.Text.Trim() != "")
            {
                // Codifique...
                //obtenemos las credenciales del usuario logueado
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtLogin.Text.Trim());

                if (objUsuarioBE.Login_Usuario == null) // si el usuario no existe
                {
                    MessageBox.Show("Usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos();
                }
                else if (objUsuarioBE.Login_Usuario == txtLogin.Text.Trim() && objUsuarioBE.Pass_Usuario == txtPassword.Text.Trim()) //si existe usuario
                {
                    //si las credenciales son correctas...
                    this.Hide();
                    timer1.Enabled = false;
                    clsCredenciales.Login_Usuario = objUsuarioBE.Login_Usuario;
                    clsCredenciales.Pass_Usuario = objUsuarioBE.Pass_Usuario;
                    clsCredenciales.Niv_Usuario = objUsuarioBE.Niv_Usuario;
                    MDIPrincipal mdi = new MDIPrincipal();
                    mdi.ShowDialog();

                }



                else
                {
                    MessageBox.Show("Usuario o Password incorrectos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos();

                }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidaAccesos();
            }

        }
        private void ValidaAccesos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan ...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();

            }
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
