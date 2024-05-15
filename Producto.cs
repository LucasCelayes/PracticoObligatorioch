using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Producto
    {
        private int _id;
        private string _descripcion;
        public int _costo;
        public int _precioVenta;
        public double _stock; // pongo double porque capaz el stock tiene kg por ejemplo
        public int _idUsuario;

        public Producto()
        {
            {
                this._id = 0;
                this._descripcion = String.Empty;
                this._costo = 0;
                this._precioVenta = 0;
                this._stock = 0;
                this._idUsuario = 0;
            }
        }
            // constructor con parametros
            public Producto(int id, string descripcion, int costo, int precioVenta, double stock, int idUsuario)
            {
                this._id = id;
                this._descripcion = descripcion;
                this._costo = costo;
                this._precioVenta = precioVenta;
                this._stock = stock;
                this._idUsuario = idUsuario;
            } // metodos
        public int Id { get { return _id; } set { this._id = value; } }
        public string Descripcion { get { return _descripcion; } set { this._descripcion = value; } }

        public int Costo { get { return _costo; } set { _costo = value; } }

        public double Stock { get { return _stock; } set { _stock = value; } }

        public int IdUsuario { get { return _idUsuario; } set { _idUsuario = value; } }



    }
}