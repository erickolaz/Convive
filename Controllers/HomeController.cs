using Microsoft.AspNetCore.Mvc;
using Convivencia.Models;
using System;

namespace Convivencia.Controllers
{
    public class HomeController:Controller
    {


      
        //private readonly DatabaseContext _context;

        //public HomeController(DatabaseContext context)
        //{
          //  _context = context;
        //}
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

        public IActionResult EstudianteRegistrado(Estudiante es){

          int age = DateTime.Now.Year - es.Birth.Year;
            es.Edad=age;
         //_context.Add(es);
           // _context.SaveChanges();
       return View(es);  
       } 
        



    
    
}
}