using System.ComponentModel.DataAnnotations;
using System;
namespace Convivencia.Models{
    public class Estudiante{
        
        public int ID{get;set;}
        public String Apep{get;set;}
        public String Apem{get;set;}
        [Display(Name="Nombre")]
        public String Name{get;set;}
        
        [DataType(DataType.Date)]
        public DateTime Birth{get; set;}
        public int Edad{get;set;}
        public String Carr{get;set;}
        public String Cic{get;set;}
    }
}