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
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = clsCredenciales.Login_Usuario;

            //para niveles de acceso: roles y opciones a ver ... parcial solo Mantenimiento
            if (clsCredenciales.Niv_Usuario == 1)
            {
                consultasToolStripMenuItem.Visible = true;
                mantenimientoToolStripMenuItem.Visible = false; //EJEMPLO ANTES DEL PARCIAL CON USUARIO JLEON
                
            }
            else if (clsCredenciales.Niv_Usuario == 2) {
                mantenimientoToolStripMenuItem.Visible = true;
                consultasToolStripMenuItem.Visible = true;
            }
        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carrera objFormCarrera = new Carrera();
            objFormCarrera.MdiParent = this;
            objFormCarrera.Show();
        }
    }
}
