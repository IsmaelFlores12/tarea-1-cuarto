﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_1_cuarto
{
    internal class acciones2:IAcciones
    {
        Alumno AL = new Alumno();
        private List<Alumno> alumnoList = new List<Alumno>()
        {
            new Alumno("Sergio",23,112599),
            new Alumno("Gustavo",22,112545)
        };




        void IAcciones.Actualizar(int matriculaActual, string NombreNuevo, int EdadNueva, int MatriculaNueva)
        {
            var Actualizar = alumnoList.FirstOrDefault(x => x.Matricula == matriculaActual);
            if (Actualizar != null)
            {
                Actualizar.Nombre = NombreNuevo;
                Actualizar.Edad = EdadNueva;
                Actualizar.Matricula = MatriculaNueva;

            }
            else
            {
                Console.WriteLine("No se encontro");
            }
        }

        void IAcciones.agregar(string nombre, int edad, int matricula)
        {
            alumnoList.Add(new Alumno(AL.Nombre = nombre, AL.Edad = edad, AL.Matricula = matricula));
        }

        List<Alumno> IAcciones.consultar()
        {
            return alumnoList;
        }

        void IAcciones.Elimminar(int matricula)
        {
            var Eliminar = alumnoList.FirstOrDefault(x => x.Matricula == matricula);
            if (Eliminar != null)
            {
                alumnoList.Remove(Eliminar);

            }
            else
            {
                Console.WriteLine("No existe");
            }
        }

        void IAcciones.ExportarExcel()
        {
            throw new NotImplementedException();
        }
    }
}

