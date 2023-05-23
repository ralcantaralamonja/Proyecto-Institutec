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
                //FALTA CORREGIR SEGUN FACULTAD
                DataRow dr;
                dr = dt.NewRow(); // fila vacia
                dr["Id_Cat"] = 0;
                dr["Des_cat"] = "--Seleccione--";
                //primera fila que se visualice:
                dt.Rows.InsertAt(dr, 0);

                cboFacultad.DataSource = dt;
                cboFacultad.ValueMember = "Id_Cat";
                cboFacultad.DisplayMember = "Des_cat";




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
                //Codifique
                //validamos
                if (txtDescripcion.Text.Trim() == String.Empty)
                {
                    throw new Exception("La descripcion es obligatoria.");
                }
                if (cboFacultad.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar una Facultad");
                }


  //-------------objCarreraBE.Id_Cat = Convert.ToInt16(cboFacultad.SelectedValue); //corregir si es el id.cat segun base


                //formulario de logeo - momentaneamente usuario de registro
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
