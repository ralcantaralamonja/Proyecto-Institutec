using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar
using Proy_Institutec_ADO;


namespace Proy_InstitutecBL
{
    public  class FacultadBL
    {
        FacultadADO objCategoriaADO = new FacultadADO();

        public DataTable ListarFacultad()
        {
            return objCategoriaADO.ListarFacultad();
        }

        public DataTable facultadCarrera(String strIdFacu)
        {
            return objCategoriaADO.facultadCarrera(strIdFacu);
        }

    }
}
