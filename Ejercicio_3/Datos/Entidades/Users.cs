using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Users
    {
        public string Iduser { get; set; }
        public string Nombre { get; set; }
        public string TipoUsuario { get; set; }
        public string Pasword { get; set; }
        public bool Enlinea { get; set; }


        public Users()
        {
        }

        public Users(string iduser, string nombre, string tipoUsuario, string pasword, bool enlinea)
        {
            Iduser = iduser;
            Nombre = nombre;
            TipoUsuario = tipoUsuario;
            Pasword = pasword;
            Enlinea = enlinea;
        }

        


    }
}
