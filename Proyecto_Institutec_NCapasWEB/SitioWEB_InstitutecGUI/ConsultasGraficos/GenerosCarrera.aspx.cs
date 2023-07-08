using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proy_InstitutecBL;
 

namespace SitioWEB_InstitutecGUI.ConsultasGraficos
{
    public partial class GenerosCarrera : System.Web.UI.Page
    {
        CarreraBL objcarrerabl = new CarreraBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (Page.IsPostBack == false) { 
                
                gridQuery1.DataSource = objcarrerabl.CarreraGenero();
                gridQuery1.DataBind();

                    DataTableReader dtrHombres = objcarrerabl.CarreraGenero().CreateDataReader();
                    DataTableReader dtrMujeres = objcarrerabl.CarreraGenero().CreateDataReader();
                    CantidadHombres.Series.Add("Hombres");
                    CantidadHombres.Series["Hombres"].Points.DataBindXY(dtrHombres, "Carrera", dtrHombres, "Hombres");
                    CantidadHombres.Series["Hombres"].IsValueShownAsLabel= true;
                    CantidadHombres.Series["Hombres"].LabelFormat = "n";

                    
                    CantidadMujeres.Series.Add("Mujeres");
                    CantidadMujeres.Series["Mujeres"].Points.DataBindXY(dtrMujeres, "Carrera", dtrMujeres, "Mujeres");
                    CantidadMujeres.Series["Mujeres"].IsValueShownAsLabel = true;
                    CantidadMujeres.Series["Mujeres"].LabelFormat = "n";

                }
            }
            catch (Exception ex)
            {
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Text = ex.Message;
                
            }
          
        }
    }
}