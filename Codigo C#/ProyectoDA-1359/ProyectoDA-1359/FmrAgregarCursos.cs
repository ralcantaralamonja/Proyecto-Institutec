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
    public partial class FmrAgregarCursos : Form
    {


        public FmrAgregarCursos()
        {
            InitializeComponent();
        }

        private void FmrAgregarCursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;

        }
    }
}
