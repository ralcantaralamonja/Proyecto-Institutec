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


    public partial class ActualizarCarrera : Form
    {

        // Instancias...
        CarreraBL objCarreraBL = new CarreraBL();
        CarreraBE objCarreraBE = new CarreraBE();
        FacultadBL objFacultadBL = new FacultadBL();



        public ActualizarCarrera()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void ActualizarCarrera_Load(object sender, EventArgs e)
        {

            try
            {
                // Cargamos los combos...
                DataTable dt = objFacultadBL.ListarFacultad();
                DataRow dr;

                //FALTA REVISAR POR EL STORE PROCE DE FACULTAD
                dr = dt.NewRow();
                dr["IdFacu"] = 0;
                dr["DesFac"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboFacultad.DataSource = dt;
                cboFacultad.ValueMember = "IdFacu";
                cboFacultad.DisplayMember = "DesFac";

                // mostrar producto
                objCarreraBE = objCarreraBL.ConsultarCarrera(this.Codigo);

                //mostramos los datos
                lblCodigo.Text = objCarreraBE.CodCard;
                txtDescripcion.Text = objCarreraBE.DesCar;


                //combos Facultad FALTA
//---------------------------------cboFacultad.SelectedValue = objCarreraBE.Id_Cat;



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
                    throw new Exception("La La descripcion es obligatoria.");
                }
                if (cboFacultad.SelectedIndex == 0 )
                {
                    throw new Exception("Debe seleccionar una Facultad");
                }
             


                //cargamos la entidad de negocio
                objCarreraBE.CodCard = lblCodigo.Text;
                objCarreraBE.DesCar = txtDescripcion.Text;


                //FALTA VER EL CODIGO
//--------------------------objCarreraBE.Id_Cat = Convert.ToInt16(cboFacultad.SelectedValue);


                //formulario de logeo 
                objCarreraBE.Usu_Ult_Mod = clsCredenciales.Login_Usuario;

                //actualizamos el registro
                if (objCarreraBL.ActualizarCarrera(objCarreraBE) == true)
                {
                    //si actualizo el registro, cerramos formulario
                    this.Close();

                }
                else
                {
                    //no se registra
                    throw new Exception("Registro no se actualizo, contactar con mesa de ayuda");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
