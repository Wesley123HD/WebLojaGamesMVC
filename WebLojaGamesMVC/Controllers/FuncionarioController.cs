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
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            Funcionario func = new Funcionario();
            return View(func);
        }
        AcoesFunc acFunc = new AcoesFunc();

        [HttpPost]

        public ActionResult Index(Funcionario funcionario)
        {
            acFunc.CadastrarFuncionario(funcionario);
            return View(funcionario);
        }
        public ActionResult Listar(Funcionario funcionario)
        {
            
            return View(funcionario);
        }
    }
}