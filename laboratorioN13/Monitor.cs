﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_N13.Lab13
{
    public class InterfazConsola
    {
        public static int[] DatosEncuestados = new int[100];
        public static int contador = 0;
        public static int PantallaPrimordial()
        {
            string txt1 = "================================\n" +
              "Encuestas de Calidad\n" +
              "================================\n" +
              "1: Realizar Encuesta\n" +
              "2: Ver datos registrados\n" +
              "3: Eliminar un dato\n" +
              "4: Ordenar datos de menor a mayor\n" +
              "5: Salir\n" +
              "================================\n";

            Console.Write(txt1);
            return calculos.getEntero("Ingrese una opción: ", txt1);
        }

        public static int RealizarEncuesta()
        {
            string txt = "===================================\n" +
              "Nivel de Satisfacción\n" +
              "===================================\n" +
              "¿Qué tan satisfecho está con la\n" +
              "atención de nuestra tienda?\n" +
              "1: Nada satisfecho\n" +
              "2: No muy satisfecho\n" +
              "3: Tolerable\n" +
              "4: Satisfecho\n" +
              "5: Muy satisfecho\n" +
              "===================================\n";

            Console.Write(txt);
            int satisfaccion = calculos.getEntero("Ingrese una opción: ", txt);
            if (satisfaccion <= 5 && satisfaccion > 0)
            {
                DatosEncuestados[contador] = satisfaccion;
                contador++;
                return NivelSatifaccion();
            }
            else
            {
                Console.Clear();
                return RealizarEncuesta();
            }
        }

        public static int NivelSatifaccion()
        {
            string txt = "===================================\n" +
              "Nivel de Satisfacción\n" +
              "===================================\n" +
              "\n\n" +
              "¡Gracias por participar!\n" +
              "\n\n" +
              "===================================\n" +
              "Presione una tecla para\n" +
              "regresar al menú ...\n";

            Console.Clear();
            Console.Write(txt);

            Console.ReadLine();
            Console.Clear();

            return PantallaPrimordial();
        }

        public static int InformacionAnotada()
        {
            string txt1 = "===================================\n" +
              "Ver datos registrados\n" +
              "===================================\n";
            Console.Write(txt1);

            if (contador == 0)
            {
                Console.WriteLine("No existen datos");
            }

            for (int i = 0; i < contador; i++)
            {
                Console.Write("[" + DatosEncuestados[i] + "] ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            string txt2 = " \n" +
                "================================\n" +
                "(1) = Nada satisfecho\n" +
                "(2) = No muy satisfecho\n" +
                "(3) = Tolerable\n" +
                "(4) = Satisfecho\n" +
                "(5) = Muy satisfecho\n" +
                "================================\n";
            Console.Write(txt2);

            int[] conteoOpciones = new int[6];

            for (int i = 0; i < contador; i++)
            {
                int OPCION = DatosEncuestados[i];
                conteoOpciones[OPCION]++;
            }

            Console.Write("\n\n");
            for (int i = 1; i < conteoOpciones.Length; i++)
            {
                Console.WriteLine("(" + i + "): " + conteoOpciones[i] + " personas\t\t");
            }

            string txt3 = "\n===================================\n" +
              "Presione una tecla para regresar ...\n";
            Console.Write(txt3);

            Console.ReadLine();
            Console.Clear();

            return PantallaPrimordial();
        }

        public static int BorrarDato()
        {
            string txt = "===================================\n" +
              "Eliminar un dato\n" +
              "===================================\n\n";
            Console.Write(txt);

            for (int i = 0; i < contador; i++)
            {
                Console.Write(i + ":[" + DatosEncuestados[i] + "] ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            string txt1 = "\n===================================\n" +
              "Ingrese la posición a eliminar: ";
            Console.Write(txt1);

            int posicion = int.Parse(Console.ReadLine());

            Console.Write("\n===================================\n");

            if (posicion >= 0 && posicion < DatosEncuestados.Length)
            {
                int i;
                for (i = posicion; i < contador - 1; i++)
                {
                    DatosEncuestados[i] = DatosEncuestados[i + 1];
                }
                contador = contador - 1;
            }
            else
            {
                Console.WriteLine("La posición ingresada no es válida.");
            }
            for (int i = 0; i < contador; i++)
            {
                Console.Write(i + ":[" + DatosEncuestados[i] + "] ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            string txt2 = "\n===================================\n" +
              "Presione una tecla para regresar ...\n";
            Console.Write(txt2);

            Console.ReadLine();
            Console.Clear();

            return PantallaPrimordial();
        }

        public static int ArreglarInformacion()
        {
            string txt = "===================================\n" +
              "Ordenar datos\n" +
              "===================================\n\n";
            Console.Write(txt);

            for (int i = 0; i < contador; i++)
            {
                Console.Write(i + ":[" + DatosEncuestados[i] + "] ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            string texto2 = "\n===================================\n";
            Console.Write(texto2);

            int ordenado = 0;
            while (ordenado == 0)
                ordenado = 1;

            for (int i = 0; i < contador; i++)
            {
                for (int j = 0; j < contador - 1; j++)
                {
                    if (DatosEncuestados[j] > DatosEncuestados[j + 1])
                    {
                        int aux = DatosEncuestados[j + 1];
                        DatosEncuestados[j + 1] = DatosEncuestados[j];
                        DatosEncuestados[j] = aux;
                        ordenado = 0;
                    }
                }
            }

            if (contador == 0)
            {
                Console.WriteLine("No existen datos");
            }

            for (int i = 0; i < contador; i++)
            {
                Console.Write(i + ":[" + DatosEncuestados[i] + "]");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            string txt3 = "\n===================================\n" +
              "Presione una tecla para regresar ...\n";

            Console.Write(txt3);

            Console.ReadLine();
            Console.Clear();

            return PantallaPrimordial();
        }
    }
}