#pragma checksum "C:\Users\Familia\Desktop\Convive-1\Views\Home\Exam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4af6e5518f3a6a5acdb15185ce41b4c8c7cab714"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Exam), @"mvc.1.0.view", @"/Views/Home/Exam.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Exam.cshtml", typeof(AspNetCore.Views_Home_Exam))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Familia\Desktop\Convive-1\Views\_ViewImports.cshtml"
using Convivencia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af6e5518f3a6a5acdb15185ce41b4c8c7cab714", @"/Views/Home/Exam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df0e8181a10727be038fccc74d81ba242ce55ba6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Exam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 11629, true);
            WriteLiteral(@" <!--
 <header class=""w3-container w3-light-grey w3-center"" style=""padding:45px 16px"">
  <h1 class=""w3-margin w3-jumbo"">Banco de Examenes pasados</h1>
  
</header>
  <section>
    <div class=""w3-row-padding w3-padding-64 w3-container"">
  <div class=""dropdown row"">
  <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
    Elegir carrera
  </button>
  <div class=""w3-container"" id=""escuela"">
  <div class=""dropdown-menu col-md-4"" aria-labelledby=""dropdownMenuButton"">
    <a class=""dropdown-item"" href=""javascript:void(0)""class=""w3-col s3 escu1"" onclick=""openEscuela(event, 'Arquitectura'); "" id=""myLink"">Arquitectura</a>
    <a class=""dropdown-item"" href=""javascript:void(0)""class=""w3-col s3 escu1""  onclick=""openEscuela(event, 'Aeronautica');"">Ciencias Aeronauticas</a>
    <a class=""dropdown-item"" href=""javascript:void(0)""class=""w3-col s3 escu1""  onclick=""openEscuela(event, 'Sistemas');"">Ingeniería de");
            WriteLiteral(@" computación y Sistemas</a>
    <a class=""dropdown-item"" href=""javascript:void(0)""class=""w3-col s3 escu1""  onclick=""openEscuela(event, 'Industrial');"">Ingeniería Industrial</a>
    <a class=""dropdown-item"" href=""javascript:void(0)""class=""w3-col s3 escu1""  onclick=""openEscuela(event, 'Civil');"">Ingeniería Civil</a>
    </div> 
    
    <div class=""col-md-6"">
      <div id=""Sistemas"" class=""w3-container escuela "">
        <div class=""container"">
    <div class=""row"">
        <div class=""dropdown btn-group"">
            <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenu1"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              Cursos Generales
            </button>
            <ul class=""dropdown-menu multi-level"" role=""menu"" aria-labelledby=""dropdownMenu"">
               <li class=""dropdown-item""><a href="""">Algebra Lineal</a></li>
              <li class=""dropdown-item""><a href="""">Calculo I</a></li>
              <li class=""dropdown-item""><a");
            WriteLiteral(@" href="""">Estadística y probabilidad I</a></li>
              <li class=""dropdown-item""><a href="""">Estadística y probabilidad II</a></li>
              <li class=""dropdown-item""><a href="""">Filosofía</a></li>
              <li class=""dropdown-item""><a href="""">Física I</a></li>
              <li class=""dropdown-item""><a href="""">Física II</a></li>
              <li class=""dropdown-item""><a href="""">Geometría analítica</a></li>
              <li class=""dropdown-item""><a href="""">Ingles I</a></li>
              <li class=""dropdown-item""><a href="""">Ingles II</a></li>
              <li class=""dropdown-item""><a href="""">Introducción a la economía</a></li>
              <li class=""dropdown-item""><a href="""">Lenguaje</a></li>
              <li class=""dropdown-item""><a href="""">Matemática discreta</a></li>
              <li class=""dropdown-item""><a href="""">Metodo de estudio</a></li>
              <li class=""dropdown-item""><a href="""">Microeconomía</a></li>
              <li class=""dropdown-item""><a href="""">Realida");
            WriteLiteral(@"d Nacional</a></li> 
              </ul>
              <div class=""dropdown"">
            <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenu1"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              Cursos de carrera
            </button>
            <ul class=""dropdown-menu multi-level"" role=""menu"" aria-labelledby=""dropdownMenu"">
          
                <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Introducción a la ingeniería</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Fundamentos de diseño Web</a>
                  <ul class=""dropdown-menu"">
                    <li clas");
            WriteLiteral(@"s=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Introducción a la programación</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Algoritmo y estructura de datos I</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">");
            WriteLiteral(@"
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Tecnología de información I</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Sistemas de información</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Algoritmo y estructura de datos II</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
    ");
            WriteLiteral(@"                <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Tecnología de información II</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Teoría y diseño de base de datos</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex");
            WriteLiteral(@"=""-1"" href=""#"">Gestión de procesos</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Servidores y sistemas operativos</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Ingeniería de Software I</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laborator");
            WriteLiteral(@"io</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Programación I</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Teoría general de Sistemas</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Ingeniería de sofware II</a>
                  <ul class=""dropdown-");
            WriteLiteral(@"menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Inteligencia artficial y robótica</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
                 <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#""></a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>

              </ul>
        </div>
 ");
            WriteLiteral(@"        <div class=""dropdown"">
            <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenu1"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              Dropdown
            </button>
            <ul class=""dropdown-menu multi-level"" role=""menu"" aria-labelledby=""dropdownMenu"">
          
                <li class=""dropdown-submenu"">
                  <a  class=""dropdown-item"" tabindex=""-1"" href=""#"">Redes y Conectividad I</a>
                  <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a href=""#"">Teoría</a></li>
                    <li class=""dropdown-item""><a href=""#"">Laboratorio</a></li>
                  </ul>
                </li>
              </ul>
        </div>
 
        

        </div>
    </div>
</div>
            </div>
  </div>
  <div id=""Arquitectura"" class=""w3-container escuela "">
    vegeta
  </div>
  <div id=""Aeronautica"" class=""w3-container escuela "">
    linux
  </div>
    </div>");
            WriteLiteral(@"
    
    </div>  
  </div>
</div>
  </section>
     -->
 
 
 <header class=""w3-container w3-light-grey w3-center"" style=""padding:45px 16px"">
  <h1 class=""w3-margin w3-jumbo"">Banco de Examenes pasados</h1>
 
 <section>
    <div class=""w3-row-padding w3-padding-64 w3-container"">
  <div class=""dropdown row"">
        


      </div>
      </div>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591