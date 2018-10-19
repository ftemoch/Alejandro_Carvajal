using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase12.Models
{
    public class Clientes
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public float Salario { get; set; }
        public bool EstaActivo { get; set; }
    }
}