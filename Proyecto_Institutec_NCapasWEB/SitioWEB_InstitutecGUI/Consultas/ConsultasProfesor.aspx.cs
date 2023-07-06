using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Agregamos
using Proy_InstitutecBL;
using Proy_InstitutecBE;

namespace SitioWEB_InstitutecGUI.Consultas
{
    public partial class ConsultasProfesor : System.Web.UI.Page
    {
        //Instancias
        ProfesoreBL objProfesorBL = new ProfesoreBL();
        ProfesorBE objProfesorBE = new ProfesorBE();
        CursoBL objcursoBL = new CursoBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                // El boton btnConsultar se inicia desactivado....hasta ingresar la info necesaria para efectuar la consulta

                btnConsultar.Enabled = false;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // llamar a la consulta
                grvConsuProfe.DataSource = objcursoBL.ConsultaProfesorCurso(txtCodi.Text.Trim());


                grvConsuProfe.DataBind();
                lblRegistros.Text = "Cantidad de Cursos: " + grvConsuProfe.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            try
            {


                //primero obtenemos los datos del profesor x medio de su codigo
                objProfesorBE = objProfesorBL.ConsultarProfesorCurso(txtCodi.Text.Trim());


                //evaluamos la existencia del codigo de profesor ingresado
                if (objProfesorBE.IdProf == null)
                {
                    //primero se limpai todas las cajas de texto
                    txtDni.Text = String.Empty;
                    txtnombreApell.Text = String.Empty;
                    txtEstado.Text = String.Empty;
                    txtDirec.Text = String.Empty;
                    txtFechIngr.Text = String.Empty;
                    txtCorreo.Text = String.Empty;
                    txtUbigeo.Text = String.Empty;

                    lblRegistros.Text = String.Empty;
                    grvConsuProfe.DataSource = null;
                    grvConsuProfe.DataBind();

                    btnConsultar.Enabled = false;
                    throw new Exception("Codigo del Profesor no existe");
                }
                else
                {
                    txtDni.Text = objProfesorBE.Ndocum;
                    txtnombreApell.Text = objProfesorBE.NomPro + " " + objProfesorBE.ApePat + " " + objProfesorBE.ApeMat;
                    txtDirec.Text = objProfesorBE.Direccion;
                    txtFechIngr.Text = objProfesorBE.FecIng.ToString("dd/MM/yyyy");
                    txtCorreo.Text = objProfesorBE.CorIns;
                    txtUbigeo.Text = objProfesorBE.Departamento + " - " + objProfesorBE.Provincia + " - " + objProfesorBE.Distrito;


                    //estado
                    if (objProfesorBE.Estado == true)
                    {
                        txtEstado.Text = "Activo";
                    }
                    else
                    {
                        txtEstado.Text = "Inactivo";
                    }


                    //registro
                    lblRegistros.Text = String.Empty;

                    btnConsultar.Enabled = true;
                }


            }
            catch (Exception ex)
            {

                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();

            }
        }
    }
}