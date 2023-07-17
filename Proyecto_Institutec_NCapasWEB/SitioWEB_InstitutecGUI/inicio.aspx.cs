using SitioWEB_InstitutecGUI.ConsultasGraficos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWEB_InstitutecGUI
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bntConsultaAlumno_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consultas/ConsultaAlumno.aspx");
        }

        protected void btnConsultaProfesor_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consultas/ConsultaProfesor.aspx");
        }

        protected void btnConsultaGrafGeneros_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultasGraficos/GenerosCarrera.aspx"); 
        }

        protected void btnConsultaGrafSeccion_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultasGraficos/MatriculadosSeccion.aspx");
        }

        protected void btnMantCarrera_Click(object sender, EventArgs e)
        {
            Response.Redirect("Matenimientos/WebMantCarrera.aspx");
        }

        protected void btnMantCurso_Click(object sender, EventArgs e)
        {
            Response.Redirect("Matenimientos/WebMantCurso.aspx");
        }

        protected void btnMatricular_Click(object sender, EventArgs e)
        {
            Response.Redirect("transacciones/Matricula1.aspx");
        }
    }
}