using System.ComponentModel.DataAnnotations;
using System;
namespace Convivencia.Models{
    public class Estudiante{

        public int ID{get;set;}
        [Display(Name="Nombre")]
        public String Name{get;set;}

         public String Apell{get;set;}
          public String Cic{get;set;}
        [DataType(DataType.Date)]
        public DateTime Birth{get; set;}
        public int Edad{get;set;}
        public String Hobbie{get;set;}
        public String Curso{get;set;}
        public Double Costo{get;set;}
        public int Creditos{get;set;}
    }
}