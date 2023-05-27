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
    public partial class MDIPrincipal : Form
    {
        private object objUsuarioBE;

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
            else if (clsCredenciales.Niv_Usuario == 2)
            {
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

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfesor objProfesor = new FrmProfesor();
            objProfesor.MdiParent = this;
            objProfesor.Show();

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCursoMan01 objFrmCursoMan01 = new FrmCursoMan01();
            objFrmCursoMan01.MdiParent = this;
            objFrmCursoMan01.Show();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerAlumno objAlumno = new FrmVerAlumno();
            objAlumno.MdiParent = this;
            objAlumno.Show();
        }
    }
}