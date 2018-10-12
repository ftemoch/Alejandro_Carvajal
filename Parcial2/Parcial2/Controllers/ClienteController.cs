using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parcial2.Models;

namespace Parcial2.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Lista()
        {
            var Cliente = new Cliente()
            {
                Nombre = "Alejandro",
                Apellido = "Carvajal",
                Sueldo = 2500000
                //Crear View
            };
            return View(Cliente);
        }
    }
}