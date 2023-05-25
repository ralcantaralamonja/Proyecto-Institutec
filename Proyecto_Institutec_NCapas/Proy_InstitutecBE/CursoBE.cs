using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_InstitutecBE
{
    public  class CursoBE
    {
        //entidad de negocio Curso
        public string IdCurs { get; set; }
        public string NomCur { get; set; }
        public bool Activo { get; set; }
        public string CodCar { get; set; }
        public DateTime Fec_Registro { get; set; }
        public string Usu_Registro { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
    }
}

