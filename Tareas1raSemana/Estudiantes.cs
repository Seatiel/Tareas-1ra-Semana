using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas1raSemana
{
    class Estudiantes : Personas
    {
        public string Matricula { get; set; }

        public void Aprender()
        {
            Console.WriteLine("Aprende");
        }
    }
}
