using Presentador_ElSoldado;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vista_ElSoldado
{
    internal class View : IView
    {
        private readonly Presentador presentador;
        private Dictionary<string, int> weaponMenuItems;

        public View()
        {
            this.presentador = new Presentador(this);

        }
        public void menuPrincipal()
        {
            string option;
            bool exit = false;

            do
            {
                Console.Clear();
                Show_text("-== Bienvenido al campo de entrenamiento, Soldado ==-");
                Show_text("¿Qué desea hacer?");
                Show_text("(presionar la opcion deseada y luego enter");
                Show_text("");
                Show_text("1- Recoger Arma");
                Show_text("2- Dejar Arma");
                Show_text("3- Disparar");
                Show_text("4- Ver arma en uso");
                Show_text("X- Salir");
                option = Console.ReadLine();
                runAMainMenuOption(option, ref exit);
            }
            while (exit == false);
        }  

        public void runAMainMenuOption(string option, ref bool exit)
        {
            Console.Clear();
            switch (option)
            {
                case "1":
                    Set_weapon_menu();
                    exit = false;
                    break;
                case "2":
                    presentador.dejarArma();
                    exit = false;
                    break;
                case "3":
                    presentador.Disparar();
                    exit = false;
                    break;
                case "4":
                    presentador.dejarArma();
                    exit = false;
                    break;
                case "X":
                case "x":
                    Environment.Exit(2);
                    break;
                default:
                    Console.WriteLine("El comando ingresado no es valido");
                    Console.ReadKey();
                    runAMainMenuOption();
                    break;
            }
        }

        public void Set_weapon_menu()
        {

        }

        public void Show_text(string text)
        {
            Console.WriteLine(text);
        }
    }
}
