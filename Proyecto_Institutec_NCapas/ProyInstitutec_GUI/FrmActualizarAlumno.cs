using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proy_InstitutecBE;
using Proy_InstitutecBL;

namespace ProyInstitutec_GUI
{
    public partial class FrmActualizarAlumno : Form
    {
        AlumnoBE objAlumnoBE = new AlumnoBE();
        AlumnoBL objAlumnoBL = new AlumnoBL();
        FacultadBL objFacultadBL = new FacultadBL();
        CarreraBL objCarreraBL = new CarreraBL();

        public FrmActualizarAlumno()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == String.Empty)
                {

                    throw new Exception("El Nombre del alumno es un campo obligatorio");
                }
                if (txtApePat.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido paterno del alumno es un campo obligatorio");
                }
                if (txtApeMat.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido Marteno del alumno es un campo obligatorio");
                }

                if (mskTelAlu.Text.Trim() == String.Empty)
                {
                    throw new Exception("Numero de telefono debe tener 9 digitos");
                }


                Boolean activo;
                if (chkActivo.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }
                DateTime fechaNac = dtpFecNac.Value;
                //Pasamos valores alas propiedades de la instancia...

                objAlumnoBE.IdAlum = lblCodigo.Text.Trim();
                objAlumnoBE.NomAlu = txtNombre.Text.Trim();
                objAlumnoBE.ApeMat = txtApeMat.Text.Trim();
                objAlumnoBE.ApePat = txtApePat.Text.Trim();
                objAlumnoBE.TelAlu = mskTelAlu.Text.Trim();
                objAlumnoBE.Estado = activo;
                objAlumnoBE.FecNac = fechaNac;

                if (objAlumnoBL.ActualizarAlumno(objAlumnoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto ");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void FrmActualizarAlumno_Load(object sender, EventArgs e)
        {
            try
            {

                objAlumnoBE = objAlumnoBL.ConsultarAlumno(this.Codigo);

                DateTime fechaNac = dtpFecNac.Value;
                lblCodigo.Text = objAlumnoBE.IdAlum;
                txtNombre.Text = objAlumnoBE.NomAlu;
                txtApeMat.Text = objAlumnoBE.ApeMat;
                txtApePat.Text = objAlumnoBE.ApePat;
                mskTelAlu.Text = objAlumnoBE.TelAlu;
                dtpFecNac.Value = fechaNac;
                if (objAlumnoBE.Estado == true)
                {
                    chkActivo.Checked = true;
                }
                else
                {
                    chkActivo.Checked = false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCarrera_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }
    }
}
