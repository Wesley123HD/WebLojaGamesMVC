using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLojaGamesMVC.Models;
using System.Collections.ObjectModel;

namespace WebLojaGamesMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            Cliente cli = new Cliente();
            return View(cli);
        }
        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                return View("ListarCli", cliente);
            }
            return View(cliente);
        }
        public ActionResult ListarCli(Cliente cliente)
        {
            return View(cliente);
        }
    }
}