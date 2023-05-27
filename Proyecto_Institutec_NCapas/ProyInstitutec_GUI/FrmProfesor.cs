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
    public partial class FrmProfesor : Form
    {
        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmInsertarProfesor objInsertarProfesor = new FrmInsertarProfesor();
            objInsertarProfesor.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
