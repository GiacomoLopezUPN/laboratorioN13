using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_N13.Lab13
{
    internal class calculos
    {
        public static int getEntero(string prefijo, string reemplazo)
        {
            int reparo = 0;
            bool correcto = false;

            do
            {
                string numTex = getTxtMonitor(prefijo);
                correcto = int.TryParse(numTex, out reparo);

                if (!correcto)
                {
                    Console.Clear();
                    Console.WriteLine(reemplazo);
                    Console.WriteLine("Ingresa un número válido");
                }

            } while (!correcto);

            return reparo;
        }

        public static float getDecimal(string prefijo)
        {
            float reparo = 0;
            bool correcto = false;

            do
            {
                string numTex = getTxtMonitor(prefijo);

                correcto = float.TryParse(numTex, out reparo);

                if (!correcto)

                {
                    Console.WriteLine("Ingresa un número válido");
                }

            } while (!correcto);

            return reparo;
        }

        public static string getTxtMonitor(string prefijo)

        {
            Console.Write(prefijo);

            return Console.ReadLine();
        }
    }
}