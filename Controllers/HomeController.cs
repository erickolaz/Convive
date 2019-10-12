using Microsoft.AspNetCore.Mvc;
using Convive.models;

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
        


      [HttpPost]
     public IActionResult Registrar (Estudiante es){

       int age;
       age=DateTime.Now.Year - follow.Birth.Year;
       es.edad=age;
         _context.Add(es);
            _context.SaveChanges();
       return View(es);
     }
    }
}