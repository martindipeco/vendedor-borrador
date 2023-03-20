using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View_Vendedor
{
    public class View : IView
    {
        private readonly Presenter _Presenter;
        //private Dictionary<string, int> _weaponMenuItems;


        public View()
        {
            _Presenter = new Presenter(this);
            Show_main_menu();
        }

    #region "Métodos que contienen lógica de vista"
        private void Show_main_menu()
        {
            String optionString;
            bool exit = false;
            do
            {
                Console.Clear();
                Show_text("-== Bienvenido al menu de Cotizaciones ==-");
                Show_text("¿Qué desea hacer?");
                Show_text("(presione el caracter correspondiente a la opción del menú y luego presione Enter)");
                Show_text("");
                Show_text("1- Hacer una cotizacion");
                Show_text("2- Desestimar / Cancelar");
                Show_text("3- Confirmar Venta");
                Show_text("4- Ver Historial de cotizaciones");
                Show_text("X- Salir");
                optionString = Console.ReadLine();
                Run_a_main_menu_option(optionString, ref exit);
            } while (exit == false);
        }
        /*
        private void Run_a_main_menu_option(string optionString, ref bool exit)
        {
            switch (optionString)
            {
                case "1":
                    Show_menu_to_take_a_weapon();
                    exit = false;
                    break;
                case "2":
                    _Presenter.DejarArma();
                    Console.ReadKey();
                    exit = false;
                    break;
                case "3":
                    _Presenter.Disparar();
                    Console.ReadKey();
                    exit = false;
                    break;
                case "4":
                    _Presenter.VerArma();
                    Console.ReadKey();
                    exit = false;
                    break;
                case "x":
                case "X":
                    Environment.Exit(2);
                    break;
                default:
                    Show_text("La opción ingresada es inválida, por favor reintente.");
                    Console.ReadKey();
                    exit = false;
                    break;
            }
        }
        private void Show_menu_to_take_a_weapon()
        {
            string optionString;
            bool isValidOption = true;
            do
            {
                Console.Clear();
                Show_text("Por favor, escoja el arma que desea utilizar:");
                Show_text("");

                // mostramos las opciones del menú que permiten seleccionar un arma para el soldado
                // para ello le pedimos al presenter que nos traiga las opciones del menú ya armadas.
                _Presenter.GetListOfWaponMenuItems();
                foreach (var key in _weaponMenuItems.Keys)
                {
                    string weaponName = key; // obtenemos el numero del menú para seleccionar el arma (por ejemplo: 2)
                    int numberOfItem = _weaponMenuItems[weaponName]; // obtenemos el nombre del arma (por ejemplo: "Rifle")
                    string menuItem = numberOfItem + "- " + weaponName; // construímos el ítem/opción de menú (por ejemplo: "2- Rifle")
                    Show_text(menuItem);
                }

                Show_text("X- Volver atrás...");
                optionString = Console.ReadLine();

                Select_a_weapon(optionString, ref isValidOption);

            } while (isValidOption == false);
            Show_main_menu();
        }
        private void Select_a_weapon(string optionString, ref bool isValidOption)
        {
            try
            {
                int _optionInt = Convert.ToInt32(optionString);
                foreach (string weaponName in _weaponMenuItems.Keys)
                {
                    if (_optionInt == _weaponMenuItems[weaponName])
                    {
                        _Presenter.RecogerArma(_optionInt);
                        isValidOption = true;
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        isValidOption = false;
                    }
                }
                if (isValidOption == false)
                {
                    Show_text("La opción ingresada es inválida, por favor reintente.");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                if (optionString == "x" || optionString == "X")
                {
                    isValidOption = true;
                    Show_text("Okay, el soldado no recogió ningún arma... Volveremos al menú principal.");
                    Console.ReadKey();
                }
                else
                {
                    Show_text("La opción ingresada es inválida, por favor reintente.");
                    Console.ReadKey();
                    isValidOption = false;
                }
            }
        }*/
        #endregion
        /*
        #region "Métodos implementados de la interfaz IView"
            public void Show_text(string texto)
            {
                Console.WriteLine(texto);
            }
            public void Set_weapon_menu_items(Dictionary<string, int> menuItems)
            {
                if (menuItems.Count == 0)
                {
                    Show_text("Ups!... parece que no hay armas disponibles por aquí...");
                }
                else
                {
                    _weaponMenuItems = menuItems;
                }
            }
        #endregion */
    }
}
