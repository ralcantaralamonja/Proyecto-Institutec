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
using Proy_InstitutecBE;
using Proy_InstitutecBL;

namespace ProyInstitutec_GUI
{
    public partial class FrmCursoMan02 : Form
    {
        //instancias
        CursoBL objCursoBL = new CursoBL();
        CursoBE objCursoBE = new CursoBE();
        CarreraBL objCarreraBL = new CarreraBL();
        FacultadBL objFacultadBl = new FacultadBL();

        public FrmCursoMan02()
        {
            InitializeComponent();
        }

        private void FrmCursoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                //Cargamos los combos
                DataTable dt = objCarreraBL.ListarCarrera();
                DataRow dr;
                dr = dt.NewRow();
                dr["CodCar"] = 0;
                dr["DesCar"] = "-Seleccione-";
                dt.Rows.InsertAt(dr, 0);

                cboCarrera.DataSource = dt;
                cboCarrera.ValueMember = "CodCar";
                cboCarrera.DisplayMember = "DesCar";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }





        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si se ha seleccionado una carrera
                if (cboCarrera.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una carrera para el curso");
                    return;
                }

                // Obtener el ID de la carrera seleccionada
                string codCar = cboCarrera.SelectedValue.ToString();

                // Resto del código para insertar el curso...

                // Cargamos la entidad de negocio
                objCursoBE.NomCur = txtIngresarCurso.Text;
                if (chkActivo.Checked)
                {
                    objCursoBE.Activo = true;
                }
                else
                {
                    objCursoBE.Activo = false;
                }
                objCursoBE.CodCar = codCar; // Asignar el CodCar de carrera seleccionado
                objCursoBE.Usu_Registro = clsCredenciales.Login_Usuario;
                // Insertamos el registro
                if (objCursoBL.InsertarCurso(objCursoBE))
                {
                    // Si se insertó el registro, cerramos el formulario...
                    this.Close();
                }
                else
                {
                    throw new Exception("Registro no insertado, contacte con el área de TI");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtener el código de la carrera seleccionada
                string codCarrera = cboCarrera.SelectedValue.ToString();

                // Asignar el código de la carrera al objeto objCursoBE
                objCursoBE.CodCar = codCarrera;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtIngresarCurso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
