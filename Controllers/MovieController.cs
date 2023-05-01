using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project4.Models;
using Project4.Services;

namespace Project4.Controllers;

public class MovieController : Controller
{
    public MovieController()
    {
    }

    // 1) MANDAR LA LISTA DE PELICULAS PARA QUE LA PUEDA PINTAR Y EN LA HOME TENGAMOS EL TOP TEN DE PELICULAS.
     // 2) VAMOS A USAR EL SERVICIO Y LA VAMOS A MANDAR EN EL MODELO PARA QUE LO REPRESENTE LA VISTA.
     // 3) VER TEMAS DE NAMESPACE (CON RESPECTO AL PROYECTO ACTUAL)
     // 4) CUANDO HAY UNA LLAMADA GET POR DEFECTO VA A ENTRAR A A ESTA ACCION.
    public IActionResult Index()
    {   
        var model = new List<Movie>(); // CREACION LISTA DE PELICULAS.
        model = MovieService.GetAll(); // VOY A LLAMAR AL SERVICIO. (DEBO IMPPORTAR EL NAME SPACE PARA QUE TE LO RENOZCA)

        return View(model); // VAMOS A PASAR A LA VISTA NUESTRO MODELO.
    }

    public IActionResult Detail(string id)
    {
        var model = MovieService.Get(id);

        return View(model);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Movie movie){
        if(!ModelState.IsValid){
            return RedirectToAction("Create");
        }

        MovieService.Add(movie);

        return RedirectToAction("Index");
    }
}
