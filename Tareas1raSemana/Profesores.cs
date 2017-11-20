using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas1raSemana
{
    class Profesores : Personas
    {
        public string Clase { get; set; }

        public void Enseña()
        {
            Console.WriteLine("Enseña");
        }
    }
}
