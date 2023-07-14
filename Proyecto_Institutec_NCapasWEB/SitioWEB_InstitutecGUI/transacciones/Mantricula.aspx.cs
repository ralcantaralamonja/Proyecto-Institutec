using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proy_InstitutecBL;
using Proy_InstitutecBE;

namespace SitioWEB_InstitutecGUI.transacciones
{
  
    public partial class Mantricula : System.Web.UI.Page
    {
        CursoBL objcursoBL = new CursoBL();
        protected void Page_Load(object sender, EventArgs e)
        {

            grvCursosDisponibles = objcursoBL.CursosDispobiblesAlumno();
        }
    }
}