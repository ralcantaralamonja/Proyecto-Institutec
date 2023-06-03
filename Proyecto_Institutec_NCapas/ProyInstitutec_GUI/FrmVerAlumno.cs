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

        private void VerAlumno_Load(object sender, EventArgs e)
        {
            dtgAlumno.AutoGenerateColumns = false;
            CargarDatos("");

        }

        public void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objAlumnoBL.ListarAlumno());
            dtv.RowFilter = "DNI like '%" + strFiltro + "%'";
            dtgAlumno.DataSource = dtv;
            lblRegistros.Text = dtgAlumno.Rows.Count.ToString();
            dtgAlumno.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {


            try
            {
                FrmActualizarAlumno objActualizarAlumno = new FrmActualizarAlumno();
                objActualizarAlumno.Codigo = dtgAlumno.CurrentRow.Cells[0].Value.ToString();
                objActualizarAlumno.ShowDialog();

                CargarDatos(mskDNIAlumno.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }


        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                // instancia

                FrmInsertarAlumno objInsertarAlumno = new FrmInsertarAlumno();
                objInsertarAlumno.ShowDialog();


                //refrescamos el datagrid - para que se vea apenas se haga el cambio
                CargarDatos(mskDNIAlumno.Text.Trim());


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }


        }


        private void mskDNIAlumno_TextChanged(object sender, EventArgs e)
        {


            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                CargarDatos(mskDNIAlumno.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }


        }

        private void mskDNIAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false) // Ni tampoco es digito
                {

                    e.Handled = true; //Se atrapa el caracter y no se imprime 
                }
            }
        }

    }
}
