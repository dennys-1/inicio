#pragma checksum "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\Reserva\Reserva.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b17821fa2dc5d34340f30171554e801225e83fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reserva_Reserva), @"mvc.1.0.view", @"/Views/Reserva/Reserva.cshtml")]
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
#nullable restore
#line 1 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\_ViewImports.cshtml"
using inicio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\_ViewImports.cshtml"
using inicio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b17821fa2dc5d34340f30171554e801225e83fb", @"/Views/Reserva/Reserva.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffe0b0c2d64a52b5b8783471f9372a65ab76b4fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Reserva_Reserva : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<inicio.Models.Reserva>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportarExcel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2 style=\"color: white; margin-top:5%;margin-bottom:5%;\">Lista Reservas</h2>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b17821fa2dc5d34340f30171554e801225e83fb4230", async() => {
                WriteLiteral("Nueva Reserva");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-hover\">\r\n     <thead class=\"thead-dark\">\r\n        <tr>\r\n                <th scope=\"col\">\r\n                    #\r\n                </th>\r\n                \r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 19 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\Reserva\Reserva.cshtml"
               Write(Html.DisplayNameFor(model => model.n_personas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 22 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\Reserva\Reserva.cshtml"
               Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 25 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\Reserva\Reserva.cshtml"
               Write(Html.DisplayNameFor(model => model.ocasion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 28 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\Reserva\Reserva.cshtml"
               Write(Html.DisplayNameFor(model => model.fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                 \r\n                 <th scope=\"col\">\r\n                    ");
#nullable restore
#line 32 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\Reserva\Reserva.cshtml"
               Write(Html.DisplayNameFor(model => model.hora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\Reserva\Reserva.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">\r\n                    ");
#nullable restore
#line 41 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\Reserva\Reserva.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                </th>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 45 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\Reserva\Reserva.cshtml"
               Write(Html.DisplayFor(modelItem => item.n_personas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\Reserva\Reserva.cshtml"
               Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\Reserva\Reserva.cshtml"
               Write(Html.DisplayFor(modelItem => item.ocasion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\Reserva\Reserva.cshtml"
               Write(Html.DisplayFor(modelItem => item.fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\Reserva\Reserva.cshtml"
               Write(Html.DisplayFor(modelItem => item.hora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 60 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio\Views\Reserva\Reserva.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b17821fa2dc5d34340f30171554e801225e83fb10334", async() => {
                WriteLiteral("Exporta a Excel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<inicio.Models.Reserva>> Html { get; private set; }
    }
}
#pragma warning restore 1591
