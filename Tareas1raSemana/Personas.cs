using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas1raSemana
{
    class Personas
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public void Caminar()
        {
            Console.WriteLine("Camina");
        }

        public void Hablar()
        {
            Console.WriteLine("Habla");
        }

        public void Comer()
        {
            Console.WriteLine("Come");
        }
    }
}
