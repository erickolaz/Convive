#pragma checksum "C:\Users\Clase\Desktop\Convive\Views\Home\MostrarEstudiante.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b74a9d933097d50dfd2fd8bbce3fa2ac88e67b88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MostrarEstudiante), @"mvc.1.0.view", @"/Views/Home/MostrarEstudiante.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MostrarEstudiante.cshtml", typeof(AspNetCore.Views_Home_MostrarEstudiante))]
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
#line 1 "C:\Users\Clase\Desktop\Convive\Views\_ViewImports.cshtml"
using Convivencia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74a9d933097d50dfd2fd8bbce3fa2ac88e67b88", @"/Views/Home/MostrarEstudiante.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df0e8181a10727be038fccc74d81ba242ce55ba6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MostrarEstudiante : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Estudiante>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"es\">\r\n");
            EndContext();
            BeginContext(54, 300, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43697de4b84f4ee88d32a9d741e056f8", async() => {
                BeginContext(60, 287, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Detalles Estudiante - Convivencia</title>
    <link rel=""stylesheet"" type=""text/css"" href=""css/Estilos.css"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(354, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(356, 1160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e54f0fcbab784251a64996552dacbaf3", async() => {
                BeginContext(362, 124, true);
                WriteLiteral("\r\n    <h1 style=\"color: lightblue; margin-top: 40px;\">Lista de Estudiantes > Detalle de Estudiante</h1><br/>\r\n    <label><b>");
                EndContext();
                BeginContext(487, 36, false);
#line 13 "C:\Users\Clase\Desktop\Convive\Views\Home\MostrarEstudiante.cshtml"
         Write(Html.DisplayNameFor(model=>model.ID));

#line default
#line hidden
                EndContext();
                BeginContext(523, 42, true);
                WriteLiteral("</b></label>\r\n    <div class=\"form-group\">");
                EndContext();
                BeginContext(566, 36, false);
#line 14 "C:\Users\Clase\Desktop\Convive\Views\Home\MostrarEstudiante.cshtml"
                       Write(Html.DisplayTextFor(model=>model.ID));

#line default
#line hidden
                EndContext();
                BeginContext(602, 27, true);
                WriteLiteral("</div><br/>\r\n    <label><b>");
                EndContext();
                BeginContext(630, 38, false);
#line 15 "C:\Users\Clase\Desktop\Convive\Views\Home\MostrarEstudiante.cshtml"
         Write(Html.DisplayNameFor(model=>model.Apep));

#line default
#line hidden
                EndContext();
                BeginContext(668, 42, true);
                WriteLiteral("</b></label>\r\n    <div class=\"form-group\">");
                EndContext();
                BeginContext(711, 38, false);
#line 16 "C:\Users\Clase\Desktop\Convive\Views\Home\MostrarEstudiante.cshtml"
                       Write(Html.DisplayTextFor(model=>model.Apep));

#line default
#line hidden
                EndContext();
                BeginContext(749, 27, true);
                WriteLiteral("</div><br/>\r\n    <label><b>");
                EndContext();
                BeginContext(777, 38, false);
#line 17 "C:\Users\Clase\Desktop\Convive\Views\Home\MostrarEstudiante.cshtml"
         Write(Html.DisplayNameFor(model=>model.Apem));

#line default
#line hidden
                EndContext();
                BeginContext(815, 42, true);
                WriteLiteral("</b></label>\r\n    <div class=\"form-group\">");
                EndContext();
                BeginContext(858, 38, false);
#line 18 "C:\Users\Clase\Desktop\Convive\Views\Home\MostrarEstudiante.cshtml"
                       Write(Html.DisplayTextFor(model=>model.Apem));

#line default
#line hidden
                EndContext();
                BeginContext(896, 27, true);
                WriteLiteral("</div><br/>\r\n    <label><b>");
                EndContext();
                BeginContext(924, 38, false);
#line 19 "C:\Users\Clase\Desktop\Convive\Views\Home\MostrarEstudiante.cshtml"
         Write(Html.DisplayNameFor(model=>model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(962, 42, true);
                WriteLiteral("</b></label>\r\n    <div class=\"form-group\">");
                EndContext();
                BeginContext(1005, 38, false);
#line 20 "C:\Users\Clase\Desktop\Convive\Views\Home\MostrarEstudiante.cshtml"
                       Write(Html.DisplayTextFor(model=>model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1043, 32, true);
                WriteLiteral(" años</div><br/>\r\n    <label><b>");
                EndContext();
                BeginContext(1076, 38, false);
#line 21 "C:\Users\Clase\Desktop\Convive\Views\Home\MostrarEstudiante.cshtml"
         Write(Html.DisplayNameFor(model=>model.Carr));

#line default
#line hidden
                EndContext();
                BeginContext(1114, 42, true);
                WriteLiteral("</b></label>\r\n    <div class=\"form-group\">");
                EndContext();
                BeginContext(1157, 38, false);
#line 22 "C:\Users\Clase\Desktop\Convive\Views\Home\MostrarEstudiante.cshtml"
                       Write(Html.DisplayTextFor(model=>model.Carr));

#line default
#line hidden
                EndContext();
                BeginContext(1195, 27, true);
                WriteLiteral("</div><br/>\r\n    <label><b>");
                EndContext();
                BeginContext(1223, 37, false);
#line 23 "C:\Users\Clase\Desktop\Convive\Views\Home\MostrarEstudiante.cshtml"
         Write(Html.DisplayNameFor(model=>model.Cic));

#line default
#line hidden
                EndContext();
                BeginContext(1260, 42, true);
                WriteLiteral("</b></label>\r\n    <div class=\"form-group\">");
                EndContext();
                BeginContext(1303, 37, false);
#line 24 "C:\Users\Clase\Desktop\Convive\Views\Home\MostrarEstudiante.cshtml"
                       Write(Html.DisplayTextFor(model=>model.Cic));

#line default
#line hidden
                EndContext();
                BeginContext(1340, 169, true);
                WriteLiteral("</div><br/>\r\n    <input type=\"submit\" class=\"btn btn-info\" value=\"Volver\" style=\"margin: auto; display: block; margin-bottom: 40px;\" onclick=\"window.history.back();\"/>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1516, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Estudiante> Html { get; private set; }
    }
}
#pragma warning restore 1591
