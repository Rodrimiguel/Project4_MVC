using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project4.Models;
using Project4.Services;

namespace Project4.Controllers;

public class HomeController : Controller // CONTROLLER CLASE PROPIA DE ASP.NET
{
    public HomeController() // CONSTRUCTOR
    {
    }

     
    public IActionResult Index() // ACCION POR DEFECTO INDEX (EN ESTE CASO DEVUELVE UNA VISTA) POR DEFECTO LLAMA A ESTA ACCION
    {
        return View();
    }

    public IActionResult Privacy() // PRIVACY (ENTRA EN EL MISMO CONTROLADOR PERO ESTA LLAMANDO A ESTA ACCION)
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}












































// using System.Diagnostics;
// using Microsoft.AspNetCore.Mvc;
// using Project4.Models;

// namespace Project4.Controllers;

// public class HomeController : Controller // CONTROLADOR OTRA CLASE PROPIA DE MVC
// {
//     private readonly ILogger<HomeController> _logger; // ATRIBUTOS (LOS MISMOS QUE RAZOR PAGE)

//     public HomeController(ILogger<HomeController> logger) // CONSTRUCTOR SE LLAMA IGUAL QUE LA CLASE
//     {
//         _logger = logger;
//     }
//     // AHORA TENEMOS UN CONTROLADOR QUE MANEJA LAS ACCIONES.
//     public IActionResult Index() // ACCION - QUE PUEDEN DEVOLER COSAS, EN ESTE CASO UNA VISTA
//     {   // ACCION SE LLAMA INDEX
//         return View();
//     }

//     public IActionResult Privacy() // ACCION - IDEM, DEVUELVE UNA VISTA.
//     {   //ACCION SE LLAMA PRIVACY
//         return View();
//     }

//     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//     public IActionResult Error()
//     {
//         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//     }
// }
