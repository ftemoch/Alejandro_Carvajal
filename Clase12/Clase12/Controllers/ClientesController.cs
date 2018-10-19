using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clase12.Models;

namespace Clase12.Controllers
{
    public class ClientesController : Controller
    {
        private ApplicationDbContext _context;

        public ClientesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Clientes
        public ViewResult Lista()
        {
            var Clientes = _context.Clientes.ToList();
            return View(Clientes);
        }
        public ViewResult ListaClientes()
        {
            var Clientes = _context.Clientes.ToList();
            return View(Clientes);
        }
        public ActionResult Details (int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c=> c.ID == id);
            if (cliente == null)
                return HttpNotFound();
            return View(cliente);
        }
        private IEnumerable<Cliente> GetClientes()
        {
            return new List<Cliente>{
                /*new Cliente { ID = 1, Nombre = "Alejandro Carvajal"},
                new Cliente { ID = 2, Nombre = "Cristian Agudelo"},*/
            };
        }


    }
}