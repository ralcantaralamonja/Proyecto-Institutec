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
                //validarmos
                if (txtIngresarCurso.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre del curso es obligatorio.");
                }

                if (cboCarrera.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar una carrera para el curso");
                }

                //Cargamos la entidad de negocio
                objCursoBE.NomCur = txtIngresarCurso.Text;
                if (chkActivo.Checked == true)
                {
                    objCursoBE.Activo = true;
                }
                else
                {
                    objCursoBE.Activo = false;
                }
                objCursoBE.CodCar = cboCarrera.SelectedValue.ToString();
                objCursoBE.Usu_Registro = "ogonzales";

                //Insertamos el registro
                if (objCursoBL.InsertarCurso(objCursoBE) == true)
                {
                    //si se inerto el registro, cerramos el formulario...
                    this.Close();
                }
                else
                {
                    throw new Exception("Registro no insertado, contacte con el area de TI");
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
    }
}
