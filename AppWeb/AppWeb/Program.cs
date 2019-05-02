using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int edad;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bienvenido al sistema¨{nombre} {apellido} tu edad es {edad}");
            Console.ReadLine();    
            
        }
    }
}

