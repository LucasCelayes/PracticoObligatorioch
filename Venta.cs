using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Venta
    {
        private int _id;
        private string _comentarios;
        public int _idUsuario;
        

        public Venta()
        {
            {
                this._id = 0;
                this._comentarios = String.Empty;
                this._idUsuario = 0;
            }
        }
        // constructor con parametros
        public Venta(int id, string comentarios, int idUsuario)
        {
            this._id = id;
            this._comentarios = comentarios;
            this._idUsuario = idUsuario;
        } // metodos
        public int Id { get { return _id; } set { this._id = value; } }
        public string Comentarios { get { return _comentarios; } set { this._comentarios = value; } }

        public int IdUsuario { get { return _idUsuario; } set { _idUsuario = value; } }

        

    }
}