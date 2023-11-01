using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using preferencia_pelicula.Models;

namespace preferencia_pelicula.Controllers;

public class HomeController : Controller {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) {  _logger = logger; }

    private static List<Genero> generos = new List<Genero> {
        new Genero { Id = 1, Nombre = "Acción" },
        new Genero { Id = 2, Nombre = "Comedia" },
        new Genero { Id = 3, Nombre = "Drama" }
    };

    private static List<Pelicula> peliculas = new List<Pelicula> {
        new Pelicula { Id = 1, Nombre = "Avengers: Endgame", GeneroId = 1 },
        new Pelicula { Id = 2, Nombre = "Deadpool", GeneroId = 1 },
        new Pelicula { Id = 3, Nombre = "La La Land", GeneroId = 3 }
    };

    public IActionResult Index() {
        ViewBag.Generos = generos;
        ViewBag.Peliculas = peliculas; // Agrega esta línea para inicializar Peliculas
        return View();
    }

    [HttpPost]
    public IActionResult Resumen(int generoId, int peliculaId) {
        var genero = generos.Find(g => g.Id == generoId);
        var pelicula = peliculas.Find(p => p.Id == peliculaId);

        ViewBag.Genero = genero.Nombre;
        ViewBag.Pelicula = pelicula.Nombre;

        return View();
    }

    public IActionResult Privacy() { return View(); }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
