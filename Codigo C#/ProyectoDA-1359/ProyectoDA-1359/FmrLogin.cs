using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDA_1359
{
    public partial class FmrLogin : Form
    {
        int intentos = 0;
        int tiempo = 20;

        public FmrLogin()
        {
            InitializeComponent();
        }

        private void FmrLogin_Load(object sender, EventArgs e)
        {

        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
           

            if (txtUsuario.Text.Trim() != "" & txtContraseña.Text.Trim() != "")
            {
                //Validamos Credenciales 
                if (txtUsuario.Text == "admin2" & txtContraseña.Text == "123")
                {
                    this.Hide();
                    timer1.Enabled = false;
                    MDI_Principal mdi = new MDI_Principal();
                    mdi.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Usuario o Password incorrectos",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;

                }

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
            
            }
            if (intentos == 3)
            {

                MessageBox.Show("Lo sentimos, sobrepaso el número de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            
            }

            }
 

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo -= 1;
            this.Text = "Ingrese su Usuario y contraseña.Le quedan..." + tiempo;

            if (tiempo == 0)
            {

                timer1.Enabled = false;
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            
            }



        }
    }
}
