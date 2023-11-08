using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class UsuariosDTO
    {
        private long _idUsuario;
        private string _nombre; 
        private string _usuario;
        private string _password;
        private int _estatus;

        public long IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string Password
        {
            get { return _password; }
            set
            { _password = value; }   
        }

        public int Estatus
        {
            get { return _estatus; } 
            set { _estatus = value; }
        }

    }
}
