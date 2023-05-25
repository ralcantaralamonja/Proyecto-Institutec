using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//AGREGAR
using Proy_InstitutecBL;

namespace ProyInstitutec_GUI
{
    public partial class FrmCursoMan01 : Form
    {
        //Instancias
        CursoBL objCursoBL = new CursoBL();
        DataView dtv;


        public FrmCursoMan01()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCursoMan02 objFrmCursoMan02 = new FrmCursoMan02();
                objFrmCursoMan02.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCursoMan03 objFrmCursoMan03 = new FrmCursoMan03();
                objFrmCursoMan03.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
            }

        }

        private void FrmCursoMan01_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objCursoBL.ListarCurso());
            dtv.RowFilter = "Curso like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }
        }
    }

}
