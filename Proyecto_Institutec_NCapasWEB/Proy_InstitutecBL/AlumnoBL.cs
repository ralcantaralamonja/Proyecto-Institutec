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
        public AlumnoBE PreMatricula(String dni) { 
            return objAlumnoADO.PreMatricula(dni);
            }

        public DataTable ListarAlumno()
        {
            return objAlumnoADO.ListarAlumno();
        }
        public Boolean InsertarAlumno(AlumnoBE objAlumnoBE) 
        {
            return objAlumnoADO.InsertarAlumno(objAlumnoBE);
        }

        public AlumnoBE ConsultarAlumno(String strId)
        {
            return objAlumnoADO.ConsultarAlumno(strId);
        }
        public Boolean ActualizarAlumno(AlumnoBE objAlumnoBE) 
        {
            return objAlumnoADO.ActualizarAlumno(objAlumnoBE);
        }

        public Boolean EliminarAlumno(String strCodigo)
        {
            return objAlumnoADO.EliminarAlumno(strCodigo);
        }
        public String ObtenerCarreraAlumno(String idAlumno)
        {
            return objAlumnoADO.ObtenerCarreraAlumno(idAlumno);
        }

        public String ObtenerFacultadAlumno(String idAlumno)
        {
            return objAlumnoADO.ObtenerFacultadAlumno(idAlumno);
        }

        public AlumnoBE ConsultarWebAlumno(String strid)
        {
            return objAlumnoADO.ConsultarWebAlumno(strid);
        }
    }
}
