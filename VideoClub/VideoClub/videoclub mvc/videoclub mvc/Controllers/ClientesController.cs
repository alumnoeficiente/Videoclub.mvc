using System.Collections.Generic;
using System.Linq;
using System.Web;
using videoclub_mvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using videoclub_mvc.Base_de_Datos;

namespace videoclub_mvc.Controllers
{
    public class ClientesController : Controller
    {
        private DataBaseContext contexto; 
        // GET: HomeController1

        public ClientesController()
        {
            contexto = new DataBaseContext();
        }

        protected override void Dispose(bool disposing)
        {
            contexto.Dispose();
        }

        //public ActionResult New()
        //{
        //    var membershipTypes = _contexto.
        //    return View();
        //}
        //public ViewResult Index()
        //{
        //    var clientes = contexto.Clientes.Include 
        //}
        public ActionResult Index()
        {
            var clientes = contexto.Clientes.ToList();
            return View(clientes);
        }

        // GET: HomeController1/Details/5
        public ActionResult Detalles(int id)
        {
            var cliente = contexto.Clientes.SingleOrDefault(c => c.Id == id);
            if (cliente == null) 
            return View("error, imbecil");          
            return View(cliente);
        }


        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
