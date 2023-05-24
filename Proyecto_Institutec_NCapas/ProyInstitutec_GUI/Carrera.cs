using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregar
using Proy_InstitutecBL;

namespace ProyInstitutec_GUI
{
    public partial class Carrera : Form
    {

        CarreraBL objCarreraBL = new CarreraBL();
        DataView dtv;


        public Carrera()
        {
            InitializeComponent();
        }

        private void Carrera_Load(object sender, EventArgs e)
        {
            dgtCarrera.AutoGenerateColumns = false;
            CargarDatos("");
        }

        public void CargarDatos(String strFiltro)
        {
            // Codifique
            //Construimos el dtv
            dtv = new DataView(objCarreraBL.ListarCarrera());
            dtv.RowFilter = "DesCar like '%" + strFiltro + "%'";

            dgtCarrera.DataSource = dtv;
            lblRegistros.Text = dgtCarrera.Rows.Count.ToString();
        }

        private void txtNomCarrera_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                CargarDatos(txtNomCarrera.Text.Trim());
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
                InsertarCarrera objMan02 = new InsertarCarrera(); 
                objMan02.ShowDialog();

                //refrescamos el datagrid - para que se vea apenas se haga el cambio
                CargarDatos(txtNomCarrera.Text.Trim());


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                //MAN03  
                ActualizarCarrera objMan03 = new ActualizarCarrera();
                objMan03.Codigo = dgtCarrera.CurrentRow.Cells[0].Value.ToString();
                objMan03.ShowDialog();

                //refrescamos del datagrid
                CargarDatos(txtNomCarrera.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
