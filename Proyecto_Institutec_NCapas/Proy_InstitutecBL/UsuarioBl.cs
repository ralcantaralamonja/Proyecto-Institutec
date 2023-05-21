using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//AGREGAMOS
using Proy_InstitutecBE;
using Proy_Institutec_ADO;
namespace Proy_InstitutecBL
{
    public class UsuarioBl
    {
        UsuarioADO objUsuarioADO = new UsuarioADO();

        public UsuarioBE ConsultarUsuario(string strLogin) 
        {
            return objUsuarioADO.ConsultarUsuario(strLogin);
        }
    }
}
