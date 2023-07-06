using System;
using System.Collections.Generic;
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
            gridQuery1.DataSource = objcarrerabl.CarreraGenero();
            gridQuery1.DataBind();
        }
    }
}