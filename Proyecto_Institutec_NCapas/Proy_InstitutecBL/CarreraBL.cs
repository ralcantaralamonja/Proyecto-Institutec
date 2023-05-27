using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar...
using System.Data;
using Proy_Institutec_ADO;
using Proy_InstitutecBE;

namespace Proy_InstitutecBL
{
    public  class CarreraBL
    {
        CarreraADO objCarreraADO = new CarreraADO();

        public DataTable ListarCarrera()
        { 
           return objCarreraADO .ListarCarrera();
        }
        public CarreraBE ConsultarCarrera(String strCodigo)
        {
            return objCarreraADO.ConsultarCarrera(strCodigo );
        }

        public Boolean InsertarCarrera(CarreraBE objCarreraBE)
        {
            return objCarreraADO.InsertarCarrera(objCarreraBE);
        }
        public Boolean ActualizarCarrera(CarreraBE objCarreraBE)
        {
            return objCarreraADO.ActualizarCarrera(objCarreraBE);
        }
        public Boolean EliminarCarrera(String strCodigo)
        {
            return objCarreraADO.EliminarCarrera(strCodigo);
        }
    }
}
