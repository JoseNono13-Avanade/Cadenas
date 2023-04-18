using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    class Program
    {
        public static string PedirCadena()
        {
            Console.WriteLine("Introduzca una cadena de al menos 40 caracteres:");
            string s = Console.ReadLine();

            if (s.Length < 40)
            {
                Console.WriteLine();
                Console.WriteLine("La cadena introducida posee únicamente " + s.Length + " caracteres. Por favor, introduzca una nueva cadena con más de 40 caracteres: ");
                s = Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Cadena: " + s);
            }

            return s;
        }

        public static string SustituirPalabras(string s)
        {
            Console.Clear();

            string sNew = "";

            Console.WriteLine("Introduce la palabra que quieres reemplazar, seguida de un espacio");
            Console.Write("y la palabra por la que la quieres reemplazar: ");
            string palabras = Console.ReadLine();

            string[] words = palabras.Split(' ');
            string palabraAntigua = words[0];
            string palabraNueva = words[1];

            sNew = s.Replace(palabraAntigua, palabraNueva);
            string final = "Cadena: " + sNew;

            return final;
        }

        public static bool BuscarTexto(string s)
        {
            Console.Clear();
            bool contiene = false;
            Console.Write("Introduce la palabra que quieres buscar: ");
            string palabra = Console.ReadLine();

            if (s.Contains(palabra))
            {
                contiene = true;
            }

            return contiene;
        }

        public static bool BuscarTextoInicio(string s)
        {
            Console.Clear();
            bool contiene = false;
            Console.Write("Introduce la palabra que quieres buscar: ");
            string palabra = Console.ReadLine();

            if (s.StartsWith(palabra))
            {
                contiene = true;
            }

            return contiene;
        }

        public static void Menu(string s)
        {
            string option;

            Console.WriteLine("\n┌────────────────────────────────────────┐");
            Console.WriteLine("│               CADENAS                  │");
            Console.WriteLine("├────────────────────────────────────────┤");
            Console.WriteLine("│ 1. Sustitución de pablabras            │");
            Console.WriteLine("│ 2. Buscar texto en la cadena           │");
            Console.WriteLine("│ 3. Buscar texto al inicio de la cadena │");
            Console.WriteLine("│ 0. Salir                               │");
            Console.WriteLine("└────────────────────────────────────────┘");
            Console.Write("Elige una opción: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine(SustituirPalabras(s));
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine(BuscarTexto(s));
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine(BuscarTextoInicio(s));
                    Console.ReadKey();
                    break;
            }
        }

        static void Main(string[] args)
        {
            string s;

            s = PedirCadena();
            Console.Clear();
            Console.WriteLine("Cadena: " + s);
            Menu(s);
        }
    }
}
