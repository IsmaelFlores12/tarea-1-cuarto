using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_1_cuarto
{
    internal class Program
    {
        public enum Menu
        {
            consultar = 1, agregar, actualizar, eliminar
        }
        static void Main(string[] args)
        {
            acciones2 acciones = new acciones2();
            while (true)
            {
                switch (menu())
                {
                    case Menu.consultar:
                        
                        break;
                    case Menu.agregar:
                        Console.WriteLine("nombre:");
                        string nombre=Console.ReadLine();
                        Console.WriteLine("Edad");
                        int edad=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Matricula");
                        int matricula=Convert.ToInt32(Console.ReadLine());
                        
                        break;
                    case Menu.actualizar:
                        
                        
                        break;
                    case Menu.eliminar:
                        break;
                    default:
                        break;
                }
            }
        }
        static Menu menu()
        {
            Console.WriteLine("1) Consultar");
            Console.WriteLine("2) Agregar");
            Console.WriteLine("3) Actualizar");
            Console.WriteLine("4) Eliminar");

            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
