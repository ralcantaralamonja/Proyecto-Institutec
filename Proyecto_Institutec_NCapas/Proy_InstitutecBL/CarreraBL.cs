using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proy_Institutec_ADO;
using Proy_InstitutecBE;

namespace Proy_InstitutecBL
{
    public class CarreraBL
    {
        CarreraADO objCarreraADO = new CarreraADO();
        FacultadADO objFacultadADO = new FacultadADO();

        public DataTable ListarCarrera()
        {
            return objCarreraADO.ListarCarrera();
        }

        public CarreraBE ConsultarCarrera(string strCodigo)
        {
            return objCarreraADO.ConsultarCarrera(strCodigo);
        }

        public bool InsertarCarrera(CarreraBE objCarreraBE)
        {
            return objCarreraADO.InsertarCarrera(objCarreraBE);
        }

        public bool ActualizarCarrera(CarreraBE objCarreraBE)
        {
            return objCarreraADO.ActualizarCarrera(objCarreraBE);
        }

        public bool EliminarCarrera(string strCodigo)
        {
            return objCarreraADO.EliminarCarrera(strCodigo);
        }

    }
}