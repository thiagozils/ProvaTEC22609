using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ProvaTEC22609.Models;

namespace ProvaTEC22609.Controllers
{
    public class TipoDeAssociacaoController : Controller
    {
        // Thiago Andrey Zils
        // thiago.zils@catolicasc.org.br


        private ApplicationDbContext _context;

        public TipoDeAssociacaoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        // GET: TipoDeAssociacao
        public ActionResult Index()
        {
            var viewModel = _context.TiposDeAssociacao.ToList();

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var tipo = _context.TiposDeAssociacao.Find(id);

            return View(tipo);

        }


    }
}