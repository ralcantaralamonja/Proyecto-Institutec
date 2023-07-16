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
    public class CursoBL
    {
        CursoADO objCursoADO = new CursoADO();

        public DataTable ListarCurso()
        {
            return objCursoADO.ListarCurso();
        }
        public CursoBE ConsultarCurso(String strCodigo)
        {
            return objCursoADO.ConsultarCurso(strCodigo);
        }

        public DataTable ConsultaProfesorCurso(String strCodigo)
        {
            return objCursoADO.ConsultaProfesorCurso(strCodigo);
        }
        public DataTable CursosDispobiblesAlumno(String dni)
        {
            return objCursoADO.CursosDispobiblesAlumno(dni);
        }
        public Boolean InsertarCurso(CursoBE objCursoBE)
        {
            return objCursoADO.InsertarCurso(objCursoBE);
        }
        public Boolean ActualizarCurso(CursoBE objCursoBE)
        {
            return objCursoADO.ActualizarCurso(objCursoBE);
        }
        public Boolean EliminarCurso(String strCodigo)
        {
            return objCursoADO.EliminarCurso(strCodigo);
        }
        public CursoBE PrematriculaCursos(String codcar) {
            return objCursoADO.PrematriculaCursos(codcar);
        }
        public DataTable ConsultaAlumnoCurso(String strCodigo, DateTime FecIni, DateTime FecFin)
        {
            return objCursoADO.ConsultaAlumnoCurso(strCodigo, FecIni, FecFin);
        }

    }
}
