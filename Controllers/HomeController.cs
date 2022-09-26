using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet_mvc.Models;

namespace dotnet_mvc.Controllers;

public class HomeController : Controller
{
    
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Index(User user)
    {
        if(user.apellidos!= null && user.nombre!= null && user.password!= null &&
        user.verify_password != null && user.correo != null)
        {
            if(user.password == user.verify_password){
                ViewBag.Message = "Usuario creado";
            }else{
                ViewBag.Message = "Las contraseñas no coinciden";
            }
            
        }else{
            ViewBag.Message = "Ingrese en todos los campos obligatorios";
        }
        
        return View(user);
    }
    public IActionResult login()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
