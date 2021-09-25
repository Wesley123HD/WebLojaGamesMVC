using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLojaGamesMVC.Models;
using WebLojaGamesMVC.Repositorio;
using System.Collections.ObjectModel;

namespace WebLojaGamesMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult Cliente(Cliente cliente)
        {
            ac.CadastrarCliente(cliente);
            return View(cliente);
        }
        Acoes ac = new Acoes();


        [HttpPost]
        public ActionResult CadCliente(Cliente cli)
        {
            ac.CadastrarCliente(cli);
            return View(cli);
        }
        
        public ActionResult ListarCli()
        {
            var ExibirCliente = new Acoes();
            var AllClientes = ExibirCliente.ListarCliente();
            return View(AllClientes);
        }
    }
}