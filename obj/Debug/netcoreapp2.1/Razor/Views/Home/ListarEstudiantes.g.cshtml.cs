#pragma checksum "C:\Users\Clase\Desktop\Convive\Views\Home\ListarEstudiantes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ab224faa4a819f447a00298078970620731a645"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListarEstudiantes), @"mvc.1.0.view", @"/Views/Home/ListarEstudiantes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListarEstudiantes.cshtml", typeof(AspNetCore.Views_Home_ListarEstudiantes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ab224faa4a819f447a00298078970620731a645", @"/Views/Home/ListarEstudiantes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df0e8181a10727be038fccc74d81ba242ce55ba6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListarEstudiantes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Estudiante>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegistrarEstudiante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: red;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MostrarEstudiante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"es\">\r\n");
            EndContext();
            BeginContext(67, 305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a6b83f6732749798e2eaece6786db1c", async() => {
                BeginContext(73, 292, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Estudiantes Matriculados - Convivencia</title>
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
            BeginContext(372, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(374, 1889, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9036613b818649b68f331b59be50b34d", async() => {
                BeginContext(380, 108, true);
                WriteLiteral("\r\n    <h1 style=\"color: lightblue; margin-top: 40px;\">Estudiantes Registrados</h1><br/>\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(488, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b43917b5217455392531c714ad4a75e", async() => {
                    BeginContext(544, 26, true);
                    WriteLiteral("Registrar Nuevo Estudiante");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(574, 131, true);
                WriteLiteral("<br/>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(706, 36, false);
#line 19 "C:\Users\Clase\Desktop\Convive\Views\Home\ListarEstudiantes.cshtml"
                   Write(Html.DisplayNameFor(model=>model.ID));

#line default
#line hidden
                EndContext();
                BeginContext(742, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(822, 38, false);
#line 22 "C:\Users\Clase\Desktop\Convive\Views\Home\ListarEstudiantes.cshtml"
                   Write(Html.DisplayNameFor(model=>model.Apep));

#line default
#line hidden
                EndContext();
                BeginContext(860, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(940, 38, false);
#line 25 "C:\Users\Clase\Desktop\Convive\Views\Home\ListarEstudiantes.cshtml"
                   Write(Html.DisplayNameFor(model=>model.Apem));

#line default
#line hidden
                EndContext();
                BeginContext(978, 80, true);
                WriteLiteral("\r\n                    </th>\r\n                     <th>\r\n                        ");
                EndContext();
                BeginContext(1059, 38, false);
#line 28 "C:\Users\Clase\Desktop\Convive\Views\Home\ListarEstudiantes.cshtml"
                   Write(Html.DisplayNameFor(model=>model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1097, 80, true);
                WriteLiteral("\r\n                    </th>\r\n                     <th>\r\n                        ");
                EndContext();
                BeginContext(1178, 38, false);
#line 31 "C:\Users\Clase\Desktop\Convive\Views\Home\ListarEstudiantes.cshtml"
                   Write(Html.DisplayNameFor(model=>model.Edad));

#line default
#line hidden
                EndContext();
                BeginContext(1216, 177, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Ver\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
                EndContext();
#line 39 "C:\Users\Clase\Desktop\Convive\Views\Home\ListarEstudiantes.cshtml"
                 foreach (var item in Model){

#line default
#line hidden
                BeginContext(1440, 207, true);
                WriteLiteral("                        <!-- <tr style=\"background: white; color: gray;\"> -->\r\n                        <tr style=\"background: gray; color: white;\">\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(1648, 37, false);
#line 43 "C:\Users\Clase\Desktop\Convive\Views\Home\ListarEstudiantes.cshtml"
                       Write(Html.DisplayFor(modelItem=>item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1685, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(1777, 37, false);
#line 46 "C:\Users\Clase\Desktop\Convive\Views\Home\ListarEstudiantes.cshtml"
                       Write(Html.DisplayFor(modelItem=>item.Carr));

#line default
#line hidden
                EndContext();
                BeginContext(1814, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(1906, 36, false);
#line 49 "C:\Users\Clase\Desktop\Convive\Views\Home\ListarEstudiantes.cshtml"
                       Write(Html.DisplayFor(modelItem=>item.Cic));

#line default
#line hidden
                EndContext();
                BeginContext(1942, 92, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            [");
                EndContext();
                BeginContext(2034, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80794495ef3445689dcbc56edae417f9", async() => {
                    BeginContext(2112, 8, true);
                    WriteLiteral("Detalles");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Clase\Desktop\Convive\Views\Home\ListarEstudiantes.cshtml"
                                                                 WriteLiteral(item.ID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2124, 61, true);
                WriteLiteral("]\r\n                        </td>\r\n                    </tr>\r\n");
                EndContext();
#line 55 "C:\Users\Clase\Desktop\Convive\Views\Home\ListarEstudiantes.cshtml"
                }

#line default
#line hidden
                BeginContext(2204, 52, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
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
            BeginContext(2263, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Estudiante>> Html { get; private set; }
    }
}
#pragma warning restore 1591
