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
            dtv.RowFilter = "DesCar like '% " + strFiltro + "%";
            dgtCarrera.DataSource = dtv;
            lblRegistros.Text = dgtCarrera.Rows.Count.ToString();
        }
    }
}
