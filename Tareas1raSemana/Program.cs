using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas1raSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Personas();
            var estudiante = new Estudiantes();
            var profesor = new Profesores();

            estudiante.Caminar();
            profesor.Comer();
        }
    }
}
