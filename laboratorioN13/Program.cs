using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio_N13.Lab13;

namespace Laboratorio_N13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = InterfazConsola.PantallaPrimordial();

            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = InterfazConsola.RealizarEncuesta();
                        break;
                    case 2:
                        opcion = InterfazConsola.InformacionAnotada();
                        break;
                    case 3:
                        opcion = InterfazConsola.BorrarDato();
                        break;
                    case 4:
                        opcion = InterfazConsola.ArreglarInformacion();
                        break;
                    case 0:
                    default:
                        opcion = InterfazConsola.PantallaPrimordial();
                        break;
                }
            } while (opcion != 5);
        }
    }
}