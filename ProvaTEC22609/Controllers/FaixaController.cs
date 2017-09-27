using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ProvaTEC22609.Models;

namespace ProvaTEC22609.Controllers
{
    // Thiago Andrey Zils
    // thiago.zils@catolicasc.org.br

    public class FaixaController : Controller
    {

        private ApplicationDbContext _context;

        public FaixaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        // GET: Faixa
        public ActionResult Index()
        {
            var viewModel = _context.Faixas.ToList();

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var faixa = _context.Faixas.Find(id);

            return View(faixa);

        }

    }
}