using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLojaGamesMVC.Models;
using System.Collections.ObjectModel;

namespace WebLojaGamesMVC.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult Index()
        {
            Jogo jogo = new Jogo();
            return View(jogo);
        }
        [HttpPost]
        public ActionResult Index(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                return View("ListarJogo", jogo);
            }
            return View(jogo);
        }
        public ActionResult ListarJogo(Jogo jogo)
        {
            return View(jogo);
        }
    }
}