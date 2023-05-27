using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proy_InstitutecBE;
using Proy_Institutec_ADO;

namespace Proy_InstitutecBL
{
    public class AlumnoBL
    {
        AlumnoADO objAlumnoADO = new AlumnoADO();

        public Boolean InsertarAlumno(AlumnoBE objAlumnoBE) 
        {
            return objAlumnoADO.InsertarAlumno(objAlumnoBE);
        }
        public Boolean ActualizarAlumno(AlumnoBE objAlumnoBE) 
        {
            return objAlumnoADO.ActualizarAlumno(objAlumnoBE);
        }
        public Boolean BorrarAlumno(String strcod) 
        {
            return objAlumnoADO.BorrarAlumno(strcod);
        }
        public DataTable ListarAlumno()
        {
            return objAlumnoADO.ListarAlumno();
        }

        public AlumnoBE ConsultarAlumno(String strCod)
        {
            return objAlumnoADO.ConsultarAlumno(strCod);
        }

    }
}
