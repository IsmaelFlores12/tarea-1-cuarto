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
            Acciones acciones = new Acciones();
            while (true)
            {
                switch (menu())
                {
                    case Menu.consultar:
                        var lista = acciones.consultar();
                        foreach(var l in lista)
                        {
                            Console.WriteLine($"nombre: {l.Nombre}");
                            Console.WriteLine($"edad: {l.Edad}");
                            Console.WriteLine($"matricula: {l.Matricula}");

                        }
                        
                        break;
                    case Menu.agregar:
                        Console.WriteLine("nombre:");
                        string nombre=Console.ReadLine();
                        Console.WriteLine("Edad");
                        int edad=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Matricula");
                        int matricula=Convert.ToInt32(Console.ReadLine());
                        acciones.agregar(nombre, edad, matricula);
                        
                        break;
                    case Menu.actualizar:
                        Console.WriteLine("Dame matricula");
                        int m =Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dame nuevo nombre");
                        string n = Console.ReadLine();
                        Console.WriteLine("Dame nueva edad");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dame nueva matricula");
                        int ma = Convert.ToInt32(Console.ReadLine());
                        acciones.Actualizar(m,n,e,ma);
                        break;
                    case Menu.eliminar:
                        Console.WriteLine("ingresa matricula");
                        int mat =Convert.ToInt32(Console.ReadLine());
                        acciones.Elimminar(mat);

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
