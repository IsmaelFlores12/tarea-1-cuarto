using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_1_cuarto
{
    internal interface IAcciones
    {
        List<Alumno> consultar();
        void agregar(string nombre, int edad, int matricula);
        void Elimminar(int matricula);
        void Actualizar(int matriculaActual, string NombreNuevo, int EdadNueva, int MatriculaNueva);
        void ExportarExcel();
    }
}
