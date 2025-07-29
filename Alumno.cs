using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TP_1_PROGRAMACION_1
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public Alumno(string nombre)
        {
            Nombre = nombre;
        }
    }

}