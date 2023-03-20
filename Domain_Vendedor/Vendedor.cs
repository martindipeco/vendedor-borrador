namespace Domain_Vendedor
{
    public class Vendedor
    {
        private Cotizacion _cotizacion;
        
        private List<Cotizacion> cotizaciones;

        private Tienda tienda = new Tienda();

        protected String nombre = "";
        protected String apellido = "";
        protected int codigoVendedor;


        public Cotizacion Presupuestar()
        {
            _cotizacion = new Cotizacion();
            cotizaciones.Add(_cotizacion);
            return _cotizacion;
        }
    }
}