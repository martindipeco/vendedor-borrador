using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Vendedor
{
    public class Cotizacion
    {

        /*
        protected Vendedor _vendedor;
        
        private int _id;
        private DateTime _fecha;
        private int _codigoVendedor;
        private String _prenda;
        private int _cantidad;
        private float _resultadoCotizacion;

        //valores x defecto
        public Cotizacion()
        {
            _vendedor = new Vendedor();

            _id = 3;
            _fecha = DateTime.Now;
            _codigoVendedor = 1;
            _prenda = "camisa";
            _cantidad = 2;
            _resultadoCotizacion = 100;
        */
        internal string nombre = "";
        internal string Nombre { get => nombre; }

        internal Cotizacion()
        {
            nombre = "probando";
        }

        internal string Cotizar()
        {
            return "Cotizemos "; //acá iría la lógica de negocio
        }
    }

}
