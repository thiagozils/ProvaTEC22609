using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProvaTEC22609.Models;
using System.Data.Entity;


namespace ProvaTEC22609.Controllers
{

    // Thiago Andrey Zils
    // thiago.zils@catolicasc.org.br

    public class AlunoController : Controller
    {
        // GET: Aluno
        private ApplicationDbContext _context;

        public AlunoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        public ActionResult Index()
        {


            var viewModel = _context.Alunos.Include(a => a.TipoDeAssociacao).Include(a => a.Faixa).ToList();

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var aluno = _context.Alunos.Include(a => a.TipoDeAssociacao).Include(a => a.Faixa).SingleOrDefault(a => a.Id == id);
            
            return View(aluno);

        }

    }
}