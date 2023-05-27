using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proy_InstitutecBL;

namespace ProyInstitutec_GUI
{
    public partial class FrmVerAlumno : Form
    {
        AlumnoBL objAlumnoBL = new AlumnoBL();
        DataView dtv;
        public FrmVerAlumno()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objAlumnoBL.ListarAlumno());
            dtv.RowFilter = "DNI like '%" + strFiltro + "%'";
            dtgAlumno.DataSource = dtv;

            lblRegistros.Text = dtgAlumno.Rows.Count.ToString();
        }
        private void VerAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(String.Empty);
                dtgAlumno.AutoGenerateColumns = false;
                dtv = objAlumnoBL.ListarAlumno().DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String strCod = dtgAlumno.CurrentRow.Cells[0].Value.ToString();
            FrmActualizarAlumno objActualizarAlumno = new FrmActualizarAlumno();
            objActualizarAlumno.Codigo = strCod;
            objActualizarAlumno.Show();

            dtv = objAlumnoBL.ListarAlumno().DefaultView;
            CargarDatos(mskDNIAlumno.Text.Trim());
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmInsertarAlumno objInsertarAlumno = new FrmInsertarAlumno();
            objInsertarAlumno.Show();

            CargarDatos(mskDNIAlumno.Text.Trim());
        }



        private void dtgAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mskDNIAlumno_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(mskDNIAlumno.Text.Trim());
        }
        private void dtgAlumno_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.PerformClick();
        }
    }
}
