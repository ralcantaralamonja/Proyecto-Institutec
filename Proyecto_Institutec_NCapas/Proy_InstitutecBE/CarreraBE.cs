using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_InstitutecBE
{
    public class CarreraBE
    {
        public String CodCar  { get; set; }
        public String IdFacu  { get; set; }

        public String DesFac { get; set; }
        public String DesCar { get; set; }
        public DateTime Fec_Registro   { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public String Usu_Ult_Mod { get; set; }

        public Int16 Est_carr { get; set; }

        public String Est_carr_String { get; set; }
    }
}
