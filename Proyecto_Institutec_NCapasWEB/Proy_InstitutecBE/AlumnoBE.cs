using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_InstitutecBE
{
    public class AlumnoBE
    {
       
        public String IdAlum { get; set;}

        public String Ndocum { get; set;}
        public String NomAlu { get; set;}

        public String ApePat { get; set;}

        public String ApeMat { get; set;}

        public String TelAlu { get; set;}

        public String CorAlu { get; set;}

        public bool Estado { get; set; }
        
        public String EstadoAl { get; set; }
        public String EstMat { get; set; }

        public Int16 Est { get; set; }

        public String SexoAl { get; set;}

        public DateTime FecNac { get;set;}

        public String CodCar { get;set;}

        public String DescCar { get; set; }

        public DateTime Fec_Registro { get;set;}

        public String Usu_Registro { get;set;}

        public DateTime Fec_Ult_Mod { get;set;}

        public String Usu_Ult_Mod { get;set;}

        public byte[] Foto { get; set; }

        public String direccion { get;set;}

        public String departamento { get; set; }

        public String provincia { get; set; }

        public String distrito { get; set; }

        public String Id_Ubi { get;set;}

        public String IdFacu { get;set;}

        public String DescFacu { get; set; }


    }
}
