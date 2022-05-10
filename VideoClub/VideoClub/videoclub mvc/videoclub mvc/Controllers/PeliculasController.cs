using Microsoft.AspNetCore.Mvc;
using videoclub_mvc.Models;

namespace videoclub_mvc.Controllers
{
    public class PeliculasController : Controller
    {
        public IActionResult Aleatorio()
        {
            var pelicula = new Pelicula() { Id = 1, Titulo = "El Planeta de los Simios" };
            //return View(pelicula);
            return Content("hello caracola!");
        }

        //public IActionResult Aleatorio()
        //{ return View(GetPeliculas());}
        //private List<Pelicula>GetPeliculas()
        //{
        //    return new List<Pelicula>();
        //    {
        //         new Pelicula() {Id = 1, Titulo = "El Planeta de los Simios"};
        //         new Pelicula() { Id = 2, Titulo = "Regreso al Planeta de los Simios" };
        //         new Pelicula() { Id = 3, Titulo = "Huida del Planeta de los Simios" };
        //         new Pelicula() { Id = 4, Titulo = "La Rebelión de los Simios" };
        //         new Pelicula() { Id = 5, Titulo = "La Batalla por el Planeta de los Simios" };

        //    }
        //}


    }
}
