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
    public partial class ConsultaAlumno : System.Web.UI.Page
    {
        //Instancias
        AlumnoBL objAlumnoBL = new AlumnoBL();
        AlumnoBE objAlumnoBE = new AlumnoBE();
        CursoBL objcursoBL = new CursoBL();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                // El boton btnConsultar se inicia desactivado....hasta ingresar la info necesaria para efectuar la consulta
                btnConsultar.Enabled = false;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {


                //primero obtenemos los datos del alumno x medio de su codigo
                objAlumnoBE = objAlumnoBL.ConsultarWebAlumno(txtCod.Text.Trim());


                //evaluamos la existencia del codigo de alumno ingresado
                if (objAlumnoBE.IdAlum == null)
                {
                    //primero se limpai todas las cajas de texto
                    txtDni.Text = String.Empty;
                    txtnombreApell.Text = String.Empty;
                    txtTel.Text = String.Empty;
                    txtCorreo.Text = String.Empty;
                    txtEstado.Text = String.Empty;
                    txtUbigeo.Text = String.Empty;
                    txtCarrera.Text = String.Empty;
                    txtFacultad.Text = String.Empty;

                    lblRegistros.Text = String.Empty;
                    grvConsuAlum.DataSource = null;
                    grvConsuAlum.DataBind();

                    txtFecIni.Text = String.Empty;
                    txtFecFin.Text = String.Empty;

                    btnConsultar.Enabled = false;
                    throw new Exception("Codigo del Alumno no existe");
                }
                else
                {
                    txtDni.Text = objAlumnoBE.Ndocum;
                    txtnombreApell.Text = objAlumnoBE.NomAlu + " " + objAlumnoBE.ApePat + " " + objAlumnoBE.ApeMat;
                    txtTel.Text = objAlumnoBE.TelAlu;
                    txtCorreo.Text = objAlumnoBE.CorAlu;
                    txtUbigeo.Text = objAlumnoBE.departamento + " - " + objAlumnoBE.provincia + " - " + objAlumnoBE.distrito;
                    txtCarrera.Text = objAlumnoBE.DescCar;
                    txtFacultad.Text = objAlumnoBE.DescFacu;


                    //estado
                    if (objAlumnoBE.Est == 1)
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

        protected void btnConsultar_Click1(object sender, EventArgs e)
        {
            try
            {
                // llamar a la consulta
                grvConsuAlum.DataSource = objcursoBL.ConsultaAlumnoCurso(txtCod.Text.Trim(),
                    Convert.ToDateTime(txtFecIni.Text), Convert.ToDateTime(txtFecFin.Text));


                grvConsuAlum.DataBind();
                lblRegistros.Text = "En el semestre puede elegir entre " + grvConsuAlum.Rows.Count.ToString() + " cursos: ";
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }
    }
}
    
