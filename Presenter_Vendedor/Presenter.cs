using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Domain_Vendedor;

namespace Presenter_Vendedor
{
    public class Presenter
    {
        private readonly Vendedor _vendedor; // es necesario acceder a la clase vendedor que forma parte del Dominio
        private readonly IView _view;

        public Presenter(IView view)
        {
            _soldado = new Soldado();
            _view = view;
        }

    }
}