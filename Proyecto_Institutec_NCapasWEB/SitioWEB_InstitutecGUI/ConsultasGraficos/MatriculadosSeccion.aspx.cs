﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proy_InstitutecBL;
namespace SitioWEB_InstitutecGUI.ConsultasGraficos
{
    public partial class MatriculadosSeccion : System.Web.UI.Page
    {
        CarreraBL objCarreras = new CarreraBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            grvQuery2.DataSource = objCarreras.MatriculadosSeccion();
            grvQuery2.DataBind();


            DataTableReader dtrNrc= objCarreras.MatriculadosSeccion().CreateDataReader();
            CantidadMatriculados.Series.Add("Matriculados");
            CantidadMatriculados.Series["Matriculados"].Points.DataBindXY(dtrNrc, "NRC", dtrNrc, "Alumnos");
            CantidadMatriculados.Series["Matriculados"].IsValueShownAsLabel = true;
            CantidadMatriculados.Series["Matriculados"].LabelFormat = "n";
        }
    }
}