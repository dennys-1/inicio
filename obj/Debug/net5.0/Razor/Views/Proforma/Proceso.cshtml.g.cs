#pragma checksum "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio-1\Views\Proforma\Proceso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1afcdd76aef897b972b9316badb6d55726b84a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proforma_Proceso), @"mvc.1.0.view", @"/Views/Proforma/Proceso.cshtml")]
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
#line 1 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio-1\Views\_ViewImports.cshtml"
using inicio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio-1\Views\_ViewImports.cshtml"
using inicio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1afcdd76aef897b972b9316badb6d55726b84a1", @"/Views/Proforma/Proceso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffe0b0c2d64a52b5b8783471f9372a65ab76b4fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Proforma_Proceso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<inicio.Models.Proforma>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Universidad San Martin de Porres\2021-1\PROGRAMACION 1\TIAVENENO\inicio-1\Views\Proforma\Proceso.cshtml"
  
    ViewData["Title"] = "En Proceso";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""catalogue"" class=""catalogue section-bg"" style=""text-align: center; color: white; "">
<div class=""container"">
 
    <div class=""container"">

        <div class=""section-title"">
          <h2 data-aos=""fade-in"">Proceso de Pago</h2>
        </div>
  <div class=""row"" style=""text-align: center;"" >
    <div class=""col-md-1 order-md-1""></div>
    <div class=""col-md-10 order-md-1"">
      <h4 style=""text-align: center;"" class=""mb-3 colorForm"">Facturación</h4>
      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1afcdd76aef897b972b9316badb6d55726b84a15191", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n          <div class=\"col-md-6 mb-3 formM\">\r\n            <label for=\"firstName\" class=\"colorForm\">Primer Nombre</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"firstName\"  placeholder=\"Ingresa tu nombre\"");
                BeginWriteAttribute("value", " value=\"", 869, "\"", 877, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 878, "\"", 889, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <div class=""invalid-feedback"">
              Valid first name is required.
            </div>
          </div>
          <div class=""col-md-6 mb-3 formM"">
            <label for=""lastName"" class=""colorForm"">Apellidos</label>
            <input type=""text"" class=""form-control"" id=""lastName"" placeholder=""Ingresa tu apellido""");
                BeginWriteAttribute("value", " value=\"", 1235, "\"", 1243, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 1244, "\"", 1255, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <div class=""invalid-feedback"">
              Valid last name is required.
            </div>
          </div>
        </div>

        <div class=""mb-3 formM"">
          <label for=""email"" class=""colorForm"">Email</label>
          <input type=""text"" class=""form-control"" id=""email"" placeholder=""Ingresa tu correo you@example.com"">
          <div class=""invalid-feedback"">
            Please enter a valid email address for shipping updates.
          </div>
        </div>
        

        <div class=""mb-3 formM"">
          <label for=""address"" class=""colorForm"">Dirección</label>
          <input type=""text"" class=""form-control"" id=""address"" placeholder=""Ingresa tu dirección 1234 Main St""");
                BeginWriteAttribute("required", " required=\"", 1980, "\"", 1991, 0);
                EndWriteAttribute();
                WriteLiteral(@">
          <div class=""invalid-feedback"">
            Please enter your shipping address.
          </div>
        </div>

        <div class=""mb-3 formM"">
          <label for=""address2"" class=""colorForm"">Dirección <span class=""text-muted"">(Opcional)</span></label>
          <input type=""text"" class=""form-control"" id=""address2"" placeholder=""Ingresa tu dirección"">
        </div>

        <div class=""row"">
          <div class=""col-md-5 mb-3 formM"">
            <label for=""country"" class=""colorForm"">Pais</label>
            <select class=""custom-select d-block w-100"" id=""country"" style=""height: 45px;""");
                BeginWriteAttribute("required", " required=\"", 2614, "\"", 2625, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1afcdd76aef897b972b9316badb6d55726b84a18385", async() => {
                    WriteLiteral("Elegir...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1afcdd76aef897b972b9316badb6d55726b84a19625", async() => {
                    WriteLiteral("Perú");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </select>
            <div class=""invalid-feedback"">
              Selecciona un pais valido
            </div>
          </div>
          <div class=""col-md-4 mb-3 formM"">
            <label for=""state"" class=""colorForm"">Departamento</label>
            <select class=""custom-select d-block w-100"" style=""height: 45px;"" id=""state""");
                BeginWriteAttribute("required", " required=\"", 3067, "\"", 3078, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1afcdd76aef897b972b9316badb6d55726b84a111179", async() => {
                    WriteLiteral("Elegir...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1afcdd76aef897b972b9316badb6d55726b84a112420", async() => {
                    WriteLiteral("Arequipa");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            
            </select>
            <div class=""invalid-feedback"">
             Selecciona un departamento
            </div>
          </div>

          <div class=""col-md-3 mb-3 formM"">
            <label for=""state"" class=""colorForm"">Distrito</label>
            <select class=""custom-select d-block w-100"" style=""height: 45px;"" id=""state""");
                BeginWriteAttribute("required", " required=\"", 3536, "\"", 3547, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1afcdd76aef897b972b9316badb6d55726b84a113991", async() => {
                    WriteLiteral("Elegir...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1afcdd76aef897b972b9316badb6d55726b84a115232", async() => {
                    WriteLiteral("Jose Luis Bustamante y Rivero");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            
            </select>
            <div class=""invalid-feedback"">
             Selecciona un Distrito
            </div>
          </div>
        </div>
        <hr class=""mb-4"">
        <label class=""mb-3 colorForm"" >Payment</label>

        <div class=""d-block my-3 formM"">
          <div class=""custom-control custom-radio"">
            <input id=""credit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" style=""background-color: #213B52;""");
                BeginWriteAttribute("checked", " checked=\"", 4144, "\"", 4154, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 4155, "\"", 4166, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <label class=""custom-control-label colorForm"" for=""credit"" style=""font-size: 30px"" >Tarjeta de Credito</label>
          </div>
          <div class=""custom-control custom-radio formM"">
            <input id=""debit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" style=""background: #213B52;""");
                BeginWriteAttribute("required", " required=\"", 4492, "\"", 4503, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <label class=""custom-control-label colorForm"" for=""debit"" style=""font-size: 30px"" >Tarjeta de Debito</label>
          </div>
        </div>
        <div class=""row"">
          <div class=""col-md-6 mb-3 formM"">
            <label for=""cc-name"" class=""colorForm"">Nombre del Propietario de la Tarjeta</label>
            <input type=""text"" class=""form-control"" id=""cc-name"" placeholder=""Ingresa el nombre del propietario de la tarjeta""");
                BeginWriteAttribute("required", " required=\"", 4958, "\"", 4969, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <div class=""invalid-feedback"">
              El nombre es requerido
            </div>
          </div>
          <div class=""col-md-6 mb-3 formM"">
            <label for=""cc-number"" class=""colorForm"">Numero de la Tarjeta de Credito</label>
            <input type=""text"" class=""form-control"" id=""cc-number"" placeholder=""Ingresa el numero de la tarjeta""");
                BeginWriteAttribute("required", " required=\"", 5344, "\"", 5355, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <div class=""invalid-feedback"">
              El numero de la tarjeta de credito es requerida
            </div>
          </div>
        </div>
        <div class=""row"">
          <div class=""col-md-6 mb-3 formM"">
            <label for=""cc-expiration"" class=""colorForm"">Fecha de Expiración</label>
            <input type=""text"" class=""form-control"" id=""cc-expiration"" placeholder=""Fecha de expiración es requerida""");
                BeginWriteAttribute("required", " required=\"", 5795, "\"", 5806, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <div class=""invalid-feedback"">
            Fecha de expiración es requerida
            </div>
          </div>
          <div class=""col-md-6 mb-3 formM"">
            <label for=""cc-cvv"" class=""colorForm"">CVV</label>
            <input type=""text"" class=""form-control"" id=""cc-cvv"" placeholder=""El CVV es requerido""");
                BeginWriteAttribute("required", " required=\"", 6143, "\"", 6154, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <div class=""invalid-feedback"">
              El CVV es requerido
            </div>
          </div>
        </div>
        <hr class=""mb-4"">
        <div class=""button"">
        <button  class=""btn btn-primary"" style=""border-radius: 4px;"" type=""submit"" onclick=""confirm('Compra aceptada. Gracias por su compra');  clicked();"">Comprar Ahora</button>
        </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n  </div>\r\n  <div class=\"col-md-1 order-md-1\"></div>\r\n </div> \r\n        \r\n    </div>\r\n  </div>\r\n  <div class=\"col-md-1 order-md-1\"></div>\r\n </div> \r\n </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<inicio.Models.Proforma>> Html { get; private set; }
    }
}
#pragma warning restore 1591
