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
    }
}
