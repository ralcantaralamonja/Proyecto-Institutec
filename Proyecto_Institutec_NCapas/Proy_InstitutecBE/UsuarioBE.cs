using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_InstitutecBE
{
    public class UsuarioBE
    {
        private String mvarlogin_usuario;
        private String mvarpass_usuario;
        private Int16 mvarniv_usuario;
        private Int16 mvarest_usuario;
        private DateTime mvarfec_registro;
        private String mvarusu_registro;

        //PROPIEDADES
        public String Login_Usuario
        {
            get { return mvarlogin_usuario; }
            set { mvarlogin_usuario = value; }

        }
        public String Pass_Usuario
        {
            get { return mvarpass_usuario; }
            set { mvarpass_usuario = value; }

        }
        public Int16 Niv_Usuario
        {
            get { return mvarniv_usuario; }
            set { mvarniv_usuario = value; }

        }
        public Int16 Est_Usuario
        {
            get { return mvarest_usuario; }
            set { mvarest_usuario = value; }

        }
        public DateTime Fec_Registro
        {
            get { return mvarfec_registro; }
            set { mvarfec_registro = value; }

        }
        public String Usu_Registro
        {
            get { return mvarusu_registro; }
            set { mvarusu_registro = value; }

        }
    }
}
