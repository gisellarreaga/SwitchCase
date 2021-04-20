using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opciones
            Console.WriteLine("Elige una opción\n" +
                "\n1.- Suma" +
                "\n2.- Resta" +
                "\n3.- Multiplicación" +
                "\n4.- División" +
                "\n5.- Salir"
                );

            String s1 = null;
            s1 = Console.ReadLine();
            

            switch (s1)
            {
                case 1:
                    Console.WriteLine("Seleccionaste la Suma");
                    break;
                case 2:
                    Console.WriteLine("Seleccionaste la Resta");
                    break;
                case 3:
                    Console.WriteLine("Seleccionaste la Multiplicación");
                    break;
                case 4:
                    Console.WriteLine("Seleccionaste la División");
                    break;
                case 5:
                    Console.WriteLine("Seleccionaste Salir");
                    break;
                default:
                    Console.WriteLine("La opción es incorrecta, try again :´(");
                    break;

            }

            Console.ReadKey();

        }
    }
}