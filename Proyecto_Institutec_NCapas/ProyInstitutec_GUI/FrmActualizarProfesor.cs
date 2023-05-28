using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregamos
using Proy_InstitutecBE;
using Proy_InstitutecBL;
namespace ProyInstitutec_GUI
{
    public partial class FrmActualizarProfesor : Form
    {
        ProfesoreBL objProfesorBL = new ProfesoreBL();
        ProfesorBE objProfesorBE = new ProfesorBE();
        public FrmActualizarProfesor()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }
        private void FrmActualizarProfesor_Load(object sender, EventArgs e)
        {
            try
            {

                objProfesorBE = objProfesorBL.ConsultarProfesor(this.Codigo);
                DateTime ingreso = objProfesorBE.FecIng;
                lblCodigo.Text = objProfesorBE.IdProf;
                txtNompro.Text = objProfesorBE.NomPro;
                txtApeMat.Text = objProfesorBE.ApeMat;
                txtApePat.Text = objProfesorBE.ApePat;
                txtTelf.Text = objProfesorBE.TelPro;
                dtpFecIng.Value = ingreso;
                if (objProfesorBE.Estado == true)
                {
                    optActivo.Checked = true;
                }
                else
                {
                    optInactivo.Checked = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNompro.Text.Trim() == String.Empty)
                {

                    throw new Exception("El Nombre del profesor es un campo obligatorio");
                }
                if (txtApePat.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido paterno del profesor es un campo obligatorio");
                }
                if (txtApeMat.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido Marteno del profesor es un campo obligatorio");
                }

                if (txtTelf.Text.Trim() == String.Empty)
                {
                    throw new Exception("Numero de telefono debe tener 9 digitos");
                }


                Boolean activo;
                if (optActivo.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }
                DateTime fechaIng = dtpFecIng.Value;
                //Pasamos valores alas propiedades de la instancia...

                objProfesorBE.IdProf = lblCodigo.Text.Trim();
                objProfesorBE.NomPro = txtNompro.Text.Trim();
                objProfesorBE.ApeMat = txtApeMat.Text.Trim();
                objProfesorBE.ApePat = txtApePat.Text.Trim();
                objProfesorBE.TelPro = txtTelf.Text.Trim();
                objProfesorBE.Estado = activo;
                objProfesorBE.FecIng = fechaIng;
                //objprofesorBE.FecIng = fechaIng;
                //objprofesorBE.Id_Ubi = cboDep.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                //    cboDistrito.SelectedValue.ToString();
                if (objProfesorBL.ActualizarProfesor(objProfesorBE) == true)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbActulizar_Enter(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD
=======

        private void optActivo_CheckedChanged(object sender, EventArgs e)
        {

        }
>>>>>>> 055d048e3ec7c88184e2d0af79150cae8743b19a
    }
}
