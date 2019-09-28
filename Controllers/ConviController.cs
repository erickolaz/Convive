using Microsoft.AspNetCore.Mvc;

namespace Convivencia.Controllers
{
    public class ConviController:Controller
    {
       public IActionResult Index(){
         return View();  
       } 
        
    }
}