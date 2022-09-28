using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDA_1359
{
    public partial class MDI_Principal : Form
    {
        public MDI_Principal()
        {
            InitializeComponent();
        }

        private void MDI_Principal_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }



        //Alumnos 
        private void registrarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
            FmrRegistroAlumno fmr = new FmrRegistroAlumno();
            fmr.MdiParent = this;
            fmr.Show();

            
        }
        private void buscarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                FmrBuscarAlumno fmr = new FmrBuscarAlumno();
                fmr.MdiParent = this;
                fmr.Show();
            
        }
        //Cursos 
        private void agregarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrAgregarCursos fmr = new FmrAgregarCursos();
            fmr.Show();
            this.Refresh();
        }
        private void BuscarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrBuscarCurso fmr = new FmrBuscarCurso();
            fmr.MdiParent = this;
            fmr.Show();
        }

        private void tarifaDeCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrMostrarTarifaCurso fmr = new FmrMostrarTarifaCurso();
            fmr.MdiParent = this;
            fmr.Show();
        }
        //Docente

        private void registrarDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrRegistrarDocente fmr = new FmrRegistrarDocente();
            fmr.MdiParent = this;
            fmr.Show();
        }
        private void buscarDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrBuscarDocente fmr = new FmrBuscarDocente();
            fmr.MdiParent = this;
            fmr.Show();
        }

        //Matricula
        private void buscarMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrBuscarMatricula fmr= new FmrBuscarMatricula();
            fmr.MdiParent = this;
            fmr.Show();

        }
        //Reporte   
        private void reporteDeMatriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrReporteMatriculas fmr = new FmrReporteMatriculas();
            fmr.MdiParent = this;
            fmr.Show();

        }

        private void reporteDeDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrReporteDocentes fmr =new FmrReporteDocentes();
            fmr.MdiParent = this;
            fmr.Show();

        }

        private void reporteDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrReporteAlumnos fmr =new FmrReporteAlumnos();
            fmr.MdiParent = this;
            fmr.Show();

        }

        private void reporteDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrReporteDeCursos fmr = new FmrReporteDeCursos();
            fmr.MdiParent = this;
            fmr.Show();
        }
    }
}
