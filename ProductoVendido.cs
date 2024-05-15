using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class ProductoVendido
    {
        private int _id;
        private int _idProducto;
        public double _stock;
        public int _idVenta;
        public ProductoVendido()
        {
            {
                this._id = 0;
                this._idProducto = 0;
                this._stock = 0;
                this._idVenta = 0;
            }
        }
        // constructor con parametros
        public ProductoVendido(int id, int idProducto, double stock, int idVenta)
        {
            this._id = id;
            this._idProducto = idProducto;
            this._stock = stock;
            this._idVenta = idVenta;
        } // metodos
        public int Id { get { return _id; } set { this._id = value; } }
        public int IdProducto { get { return _idProducto; } set { this._idProducto = value; } }

        public double Stock { get { return _stock; } set { _stock= value; } }

        public int IdVenta { get { return _idVenta; } set { _idVenta = value; } }
    }
}