﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//AGREGAMOS
using Proy_InstitutecBE;
using Proy_Institutec_ADO;
using System.Data;

namespace Proy_InstitutecBL
{
    public class ProfesoreBL
    {
        ProfesorADO objProfesorADO = new ProfesorADO();
        
        public DataTable ListarProfesor() { 
        return objProfesorADO.ListarProfesor();
       
        }
    }
}
