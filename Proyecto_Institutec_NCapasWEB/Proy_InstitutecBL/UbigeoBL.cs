using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregamos los using...
using Proy_Institutec_ADO;
using Proy_InstitutecBE;
using System.Data;
namespace Proy_InstitutecBl
{
    public class UbigeoBL
    {

        UbigeoADO objUbigeoADO = new UbigeoADO();

        public DataTable Ubigeo_Departamentos()
        {
            return objUbigeoADO.Ubigeo_Departamentos();
        }
        public DataTable Ubigeo_ProvinciasDepartamento(String strIdDepartamento)
        {
            return objUbigeoADO.Ubigeo_ProvinciasDepartamento(strIdDepartamento);
        }
        public DataTable Ubigeo_DistritosProvinciaDepartamento(String strIdDepartamento, String strIdProvincia)
        {
            return objUbigeoADO.Ubigeo_DistritosProvinciaDepartamento(strIdDepartamento, strIdProvincia);
        }
    }
}
