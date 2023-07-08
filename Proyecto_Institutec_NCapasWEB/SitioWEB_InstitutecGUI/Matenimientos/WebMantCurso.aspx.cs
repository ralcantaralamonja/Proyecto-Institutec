using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proy_InstitutecBL;
using Proy_InstitutecBE;
using System.Data;

namespace SitioWEB_InstitutecGUI.Mantenimientos
{
    public partial class WebMantCurso : System.Web.UI.Page
    {
        CursoBL objCursoBl = new CursoBL();
        CursoBE objCursoBe = new CursoBE();
        CarreraBL objCarreraBl = new CarreraBL();
        DataView dtv;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    CargarDatos("");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void CargarDatos(String strFiltro)
        {
            // Codifique
            dtv = new DataView(objCursoBl.ListarCurso());
            dtv.RowFilter = "Curso LIKE '%" + strFiltro + "%'";
            grvCurso.DataSource = dtv;
            grvCurso.DataBind();

            if (grvCurso.Rows.Count == 0)
            {
                lblMensajePopup.Text = "No hay registros con el criterio ingresado";
                PopMensaje.Show();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro.Text);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void grvCurso_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                //El evento recorre cada fila del grip cada vez que este se enlaza a su origen de datos
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    //Obtenemos el calor del campo Estado de cada fila
                    String estado = e.Row.Cells[4].Text;
                    //Si esta inactivo el color sera rojo
                    if (estado == "1")
                    {
                        e.Row.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception)
            {

                lblMensajePopup.Text = "No hay registros con el criterio ingresado";
                PopMensaje.Show();
            }
        }

        protected void grvCurso_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvCurso.PageIndex = e.NewPageIndex;
            CargarDatos(txtFiltro.Text);
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            //Limpiamos cajas de texto
            lblMensaje1.Text = String.Empty;

            //el chkActivo lo encendemos por defecto...
            chkEstado1.Checked = true;

            //cargamos carrera
            CargarCarrera(1);

            //Mostamos el Popup de inserccion...
            txtRS1.Focus();
            PopMan01.Show();
        }

        private void CargarCarrera(Int16 intAccion)
        {
            DataTable dtCarrera = objCarreraBl.ListarCarrera();
            //COMBOS DE UBIGEO PARA EL CRUD CURSO
            if (intAccion == 1) //COMBOS DE INSERCCION
            {
                cboCarrera1.DataSource = dtCarrera;
                cboCarrera1.DataValueField = "CodCar";
                cboCarrera1.DataTextField = "DesCar";
                cboCarrera1.DataBind();
            }
            else if (intAccion == 2)//combos de actualizacion
            {
                cboCarrera2.DataSource = dtCarrera;
                cboCarrera2.DataValueField = "CodCar";
                cboCarrera2.DataTextField = "DesCar";
                cboCarrera2.DataBind();
            }

        }

        protected void cboCarrera1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCarrera(1);
            PopMan01.Show();
        }

        protected void btnGrabar1_Click(object sender, EventArgs e)
        {
            try
            {
                //REGISTRAMOS LOS DATOS DEL NUEVO CURSO EN LA ENTIDAD DE NEGOCIOS...
                if (txtRS1.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre del nuevo curso es obligatorio");
                }

                objCursoBe.NomCur = txtRS1.Text.Trim();
                objCursoBe.Activo = chkEstado1.Checked;
                objCursoBe.CodCar = cboCarrera1.SelectedValue.ToString();


                //Insertar Registro
                if (objCursoBl.InsertarCurso(objCursoBe) == true)
                {
                    //Refresca el gridView
                    CargarDatos(txtFiltro.Text);
                }
                else
                {
                    throw new Exception("No se inserto el registro, llamar a ti");
                }
            }
            catch (Exception ex)
            {

                lblMensaje1.Text = ex.Message;
                PopMan01.Show();
            }
        }

        protected void grvCurso_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                //ibtenemos el id del proveedor a actualizar
                Int16 fila = Convert.ToInt16(e.CommandArgument);

                //Evaluamos si se selecciono el commandName Editas...
                if (e.CommandName == "Editar")
                {
                    lblMensaje2.Text = String.Empty;
                    String strCod = grvCurso.Rows[fila].Cells[1].Text;

                    //obtenemos los datos del curso para mostralos...
                    objCursoBe = objCursoBl.ConsultarCurso(strCod);

                    //Mostamos los datos en el panel de actaulziacion...
                    lblCod.Text = objCursoBe.IdCurs;
                    txtRS2.Text = objCursoBe.NomCur;
                    chkEstado2.Checked = Convert.ToBoolean(objCursoBe.Activo);

                    String CodCar = objCursoBe.CodCar;
                    CargarCarrera(2);

                    // Asignar el valor al DropDownList
                    cboCarrera2.SelectedValue = CodCar;

                    //Mostramos el panel de actualizacion
                    PopMan02.Show();
                }
            }
            catch (Exception ex)
            {

                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }

        protected void btnGrabar2_Click(object sender, EventArgs e)
        {
            try
            {
                //REGISTRAMOS LOS DATOS DEL NUEVO PROVEEDOR EN LA ENTIDAD DE NEGOCIOS...
                if (txtRS2.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre del nuevo curso es obligatorio");
                }
                objCursoBe.IdCurs = lblCod.Text;
                objCursoBe.NomCur = txtRS2.Text.Trim();
                objCursoBe.Activo = chkEstado2.Checked;
                objCursoBe.CodCar = cboCarrera2.SelectedValue.ToString();

                objCursoBe.Usu_Ult_Mod = "jleon";

                //Insertar Registro
                if (objCursoBl.ActualizarCurso(objCursoBe) == true)
                {
                    //Refresca el gridView
                    CargarDatos(txtFiltro.Text);
                }
                else
                {
                    throw new Exception("No se actualizo el registro, llamar a ti");
                }
            }
            catch (Exception ex)
            {

                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }
    }
}