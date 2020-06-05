#pragma checksum "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\Home\AirlineList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b451b5b318db7870fafe808371da7d1e0912328b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AirlineList), @"mvc.1.0.view", @"/Views/Home/AirlineList.cshtml")]
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
#line 1 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\_ViewImports.cshtml"
using Airlines.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\_ViewImports.cshtml"
using Airlines.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\_ViewImports.cshtml"
using Airlines.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b451b5b318db7870fafe808371da7d1e0912328b", @"/Views/Home/AirlineList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b75abc5c99a101f0c02109c3af0e4d5c5998386b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AirlineList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Flight>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AirlineEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AirlineDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\Home\AirlineList.cshtml"
  
    ViewData["Title"] = "AirlineList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <div class=""container-fluid"">
        <h1 class=""mt-4"">Uçuş Listesi</h1>
        <div class=""card mb-4"">
            <div class=""card-header""><i class=""fas fa-calendar-alt mr-1""></i>Tüm Uçuşlar</div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTables"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Kalkış</th>
                                <th>Varış</th>
                                <th>Fiyat</th>
                                <th>Uçuş Numarası</th>
                                <th>Uçak İsmi</th>
                                <th>Tarih</th>
                                <th>İşlemler</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>ID</t");
            WriteLiteral(@"h>
                                <th>Kalkış</th>
                                <th>Varış</th>
                                <th>Fiyat</th>
                                <th>Uçuş Numarası</th>
                                <th>Uçak İsmi</th>
                                <th>Tarih</th>
                                <th>İşlemler</th>
                            </tr>
                        </tfoot>
                        <tbody>
");
#nullable restore
#line 40 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\Home\AirlineList.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <th scope=\"row\">");
#nullable restore
#line 43 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\Home\AirlineList.cshtml"
                                               Write(item.FlightId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <td>");
#nullable restore
#line 44 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\Home\AirlineList.cshtml"
                                   Write(item.Departure);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 45 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\Home\AirlineList.cshtml"
                                   Write(item.Arrival);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 46 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\Home\AirlineList.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 47 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\Home\AirlineList.cshtml"
                                   Write(item.AirlineNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 48 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\Home\AirlineList.cshtml"
                                   Write(item.PlaneId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 49 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\Home\AirlineList.cshtml"
                                   Write(item.FlightDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b451b5b318db7870fafe808371da7d1e0912328b9273", async() => {
                WriteLiteral("Güncelle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\Home\AirlineList.cshtml"
                                                                                                                    WriteLiteral(item.FlightId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b451b5b318db7870fafe808371da7d1e0912328b11841", async() => {
                WriteLiteral("Sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\Home\AirlineList.cshtml"
                                                                                                                     WriteLiteral(item.FlightId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 55 "C:\Users\İlker ESEN\Source\Repos\Airlines\Airlines.WebUI\Views\Home\AirlineList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</main>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Flight>> Html { get; private set; }
    }
}
#pragma warning restore 1591
