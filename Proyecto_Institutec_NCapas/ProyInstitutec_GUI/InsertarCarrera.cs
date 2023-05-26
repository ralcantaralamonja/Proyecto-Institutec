using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
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
    public partial class InsertarCarrera : Form
    {

        // Instancias...
        CarreraBL objCarreraBL = new CarreraBL();
        CarreraBE objCarreraBE = new CarreraBE();
        FacultadBL objFacultadBL = new FacultadBL();



        public InsertarCarrera()
        {
            InitializeComponent();
        }

        private void InsertarCarrera_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                //cargamos los combos
                DataTable dt = objFacultadBL.ListarFacultad();


                //instancia de datarow , instancia de fila
                DataRow dr;
                dr = dt.NewRow(); // fila vacia
                dr["IdFacu"] = 0;
                dr["DesFac"] = "--Seleccione--";
                //primera fila que se visualice:
                dt.Rows.InsertAt(dr, 0);
                cboFacultad.DataSource = dt;
                cboFacultad.DisplayMember = "DesFac";
                cboFacultad.ValueMember = "IdFacu";


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

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                //validamos
                if (txtDescripcion.Text.Trim() == String.Empty)
                {
                    throw new Exception("La descripcion es obligatoria.");
                }
                if (cboFacultad.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar una Facultad");
                }

                //cargamos la entidad de negocio
                objCarreraBE.DesCar = txtDescripcion.Text;
                objCarreraBE.IdFacu = cboFacultad.SelectedValue.ToString();

                //estado de carrera
                if (chkActivo.Checked == true)
                {
                    objCarreraBE.Est_carr = 1;
                }
                else
                {
                    objCarreraBE.Est_carr = 0;
                }



                //formulario de logeo 
                objCarreraBE.Usu_Registro = clsCredenciales.Login_Usuario;

                //insertamos el registro
                if (objCarreraBL.InsertarCarrera(objCarreraBE) == true)
                {
                    //si se inserto el registro, cerramos formulario
                    this.Close();

                }
                else
                {
                    //no se registra
                    throw new Exception("Registro no se inserto, contactar con mesa de ayuda");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
