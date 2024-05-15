using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Usuario // clase publica o internal o mas

    { // atributos y son siempre privados
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contrasenia;
        private string _mail;

        // constructor sin parametros
        public Usuario()
        {
            this._id = 0;
            this._nombre = String.Empty;
            this._apellido = String.Empty;
            this._nombreUsuario = String.Empty;
            this._contrasenia = String.Empty;
            this._mail = String.Empty;
        }
    // constructor con parametros
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail )
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario=nombreUsuario;
            this._contrasenia=contrasenia;
            this._mail=mail;
        } // metodos 
        public int Id { get { return _id; } set { this._id = value; } }
        public string Nombre { get { return _nombre; } set { this._nombre = value; } }
        
        public string Apellido { get { return _apellido; } set { _apellido = value; } } 

        public string NombreUsuario { get { return _nombreUsuario; } set { _nombreUsuario = value; } }
        
        public string Contrasenia { get { return _contrasenia; } set { _contrasenia = value; } }

        public string Mail { get { return _mail; } set { _mail = value; } }


    }
}
