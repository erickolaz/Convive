using Microsoft.AspNetCore.Mvc;

namespace Convivencia.Controllers
{
    public class HomeController:Controller
    {
       public IActionResult Index(){
         return View();  
       } 
         public IActionResult Exam(){
         return View();  
       } 
         public IActionResult Problemas(){
         return View();  
       } 
         public IActionResult Ayuda(){
         return View();  
       } 
         public IActionResult Biblioteca(){
         return View();  
       } 

       public IActionResult Registrar(){
         return View();  
       } 
        
    }
}