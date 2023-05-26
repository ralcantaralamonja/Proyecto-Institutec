using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//AGREGAMOS
using Proy_InstitutecBE;
using Proy_Institutec_ADO;
using System.Data;

namespace Proy_InstitutecBL
{
    public class ProfesoreBL
    {
        ProfesorADO objProfesorADO = new ProfesorADO();
        
        public DataTable ListarProfesor() { 
        return objProfesorADO.ListarProfesor();
       
        }
        public Boolean InsertarProfesor(ProfesorBE objProfesorBE) {
            return objProfesorADO.InsertarProfesor(objProfesorBE);


        }
        public ProfesorBE ConsultarProfesor(String strId)
        {
            return objProfesorADO.ConsultarProfesor(strId);
        }
        public Boolean ActualizarProfesor(ProfesorBE objProfesorBE)
        {
            return objProfesorADO.ActualizarProfesor(objProfesorBE);
        }

    }
}
