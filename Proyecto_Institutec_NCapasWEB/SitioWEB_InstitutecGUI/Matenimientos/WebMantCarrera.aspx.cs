using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proy_InstitutecBL;
using Proy_InstitutecBE;

namespace SitioWEB_InstitutecGUI.Matenimientos
{
    public partial class WebMantCarrera : System.Web.UI.Page
    {
        CarreraBL objCarreraBL = new CarreraBL();
        FacultadBL objFacultadBL = new FacultadBL();
        CarreraBE objCarreraBE = new CarreraBE();
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
            dtv = new DataView(objCarreraBL.ListarCarrera());
            dtv.RowFilter = "DesCar like '%" + strFiltro + "%'";
            grvCarrera.DataSource = dtv;
            grvCarrera.DataBind();

            if (grvCarrera.Rows.Count == 0)
            {
                lblMensajePopup.Text = "No hay registros con el criterio ingresado";
                PopMensaje.Show();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro.Text);
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            //Limpiamos cajas de texto
            lblMensaje1.Text = String.Empty;

            //el chkActivo lo encendemos por defecto...
            chkEstado1.Checked = true;

            //cargamos carrera
            CargarFacultad(1);

            //Mostamos el Popup de inserccion...
            txtRS1.Focus();
            PopMan01.Show();
        }

        private void CargarFacultad(Int16 intAccion)
        {
            DataTable dtFacultad = objFacultadBL.ListarFacultad();
            //COMBOS DE UBIGEO PARA EL CRUD CURSO
            if (intAccion == 1) //COMBOS DE INSERCCION
            {
                cboFacultad1.DataSource = dtFacultad;
                cboFacultad1.DataValueField = "IdFacu";
                cboFacultad1.DataTextField = "DesFac";
                cboFacultad1.DataBind();
            }
            else if (intAccion == 2)//combos de actualizacion
            {
                cboFacultad2.DataSource = dtFacultad;
                cboFacultad2.DataValueField = "IdFacu";
                cboFacultad2.DataTextField = "DesFac";
                cboFacultad2.DataBind();
            }

        }

        protected void btnGrabar1_Click(object sender, EventArgs e)
        {
            try
            {
                //REGISTRAMOS LOS DATOS DE LA NUEVA CARRERA EN LA ENTIDAD DE NEGOCIOS...
                if (txtRS1.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre de la nueva carrera es obligatorio");
                }

                objCarreraBE.DesCar = txtRS1.Text.Trim();
                objCarreraBE.Est_carr = Convert.ToInt16(chkEstado1.Checked);
                objCarreraBE.IdFacu = cboFacultad1.SelectedValue.ToString();
                objCarreraBE.Usu_Registro = "jleon";


                //Insertar Registro
                if (objCarreraBL.InsertarCarrera(objCarreraBE) == true)
                {
                    //Refresca el gridView
                    CargarDatos(txtFiltro.Text);
                }
                else
                {
                    throw new Exception("No se inserto el registro, llamar a TI");
                }
            }
            catch (Exception ex)
            {

                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }

        protected void cboFacultad1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopMan01.Show();
        }

        protected void grvCarrera_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvCarrera.PageIndex = e.NewPageIndex;
            CargarDatos(txtFiltro.Text);
        }

        protected void grvCarrera_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Editar")
                {
                    int fila = Convert.ToInt32(e.CommandArgument);
                    string strCod = grvCarrera.Rows[fila].Cells[1].Text;

                    objCarreraBE = objCarreraBL.ConsultarCarrera(strCod);

                    lblCod.Text = objCarreraBE.CodCar;
                    txtRS2.Text = objCarreraBE.DesCar;
                    chkEstado2.Checked = Convert.ToBoolean(objCarreraBE.Est_carr);

                    string IdFacu = objCarreraBE.IdFacu;
                    CargarFacultad(2);

                    cboFacultad2.SelectedValue = IdFacu;

                    PopMan02.Show();
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }

        protected void grvCarrera_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                //El evento recorre cada fila del grip cada vez que este se enlaza a su origen de datos
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    //Obtenemos el valor del campo Estado de cada fila
                    String estado = e.Row.Cells[4].Text;
                    //Si esta inactivo el color sera rojo
                    if (estado == "Inactivo")
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

        protected void btnGrabar2_Click(object sender, EventArgs e)
        {
            try
            {
                //REGISTRAMOS LOS DATOS DEL NUEVO PROVEEDOR EN LA ENTIDAD DE NEGOCIOS...
                if (txtRS2.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre de la nueva carrera es obligatorio");
                }
                objCarreraBE.CodCar = lblCod.Text;
                objCarreraBE.DesCar = txtRS2.Text.Trim();
                objCarreraBE.Est_carr = Convert.ToInt16(chkEstado2.Checked);
                objCarreraBE.IdFacu = cboFacultad2.SelectedValue.ToString();
                objCarreraBE.DesFac = cboFacultad2.SelectedValue.ToString();

                objCarreraBE.Usu_Ult_Mod = "jleon";

                //Insertar Registro
                if (objCarreraBL.ActualizarCarrera(objCarreraBE) == true)
                {
                    //Refresca el gridView
                    CargarDatos(txtFiltro.Text);
                }
                else
                {
                    throw new Exception("No se actualizo el registro, llamar a TI");
                }
            }
            catch (Exception ex)
            {

                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }

        protected void txtRS2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}