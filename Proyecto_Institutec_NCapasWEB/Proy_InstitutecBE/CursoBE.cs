using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_InstitutecBE
{
    public class CursoBE
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
        public string DesCar { get; set; }
        public string nrc { get; set; }
        public string nomprof { get; set; }
        public string apepatprof { get; set; }
        public string apematprof { get; set; }
        public string estadoCurso { get; set; }
        public string Dia { get; set; }
        public string profesor { get; set; }
        public TimeSpan HoraIni { get; set; }

        public TimeSpan HoraFin { get; set; }
        public int vacante { get; set; }
        public string centro { get; set; }

        public string aula { get; set; }
    }
}

