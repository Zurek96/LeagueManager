#pragma checksum "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3371d633dbf8d2cae3806e2dec72caebc9c2f28d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\_ViewImports.cshtml"
using LeagueManagerWebApp;

#line default
#line hidden
#line 2 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\_ViewImports.cshtml"
using LeagueManagerWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3371d633dbf8d2cae3806e2dec72caebc9c2f28d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5454ee5753f3ce4da448d50e61a9e2ea96b13d00", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DailyCardModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(70, 3072, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df3aa04aec37407b8c56013a45391f9a", async() => {
                BeginContext(76, 347, true);
                WriteLiteral(@"
    <div class=""container"" style=""margin-left: 10%"">

        <div class=""row "">
            <h1 class=""display-3"">Hello</h1>
        </div>
        <br />
        <div class=""row"">
            <p>
                Witam na portalu. Poniżej losowa karta, linki znajdują się w menu po lewej.
            </p>
        </div>
    </div>
");
                EndContext();
#line 19 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
     if (Model == null)
    {

#line default
#line hidden
                BeginContext(455, 59, true);
                WriteLiteral("        <p>\r\n            Czekam na kartę...\r\n        </p>\r\n");
                EndContext();
#line 24 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(538, 521, true);
                WriteLiteral(@"        <div class=""container"" style=""margin-left: 10%"">
            <div class=""row"">
                <div class=""col-6 col-sm-6"">
                    <table class=""table table-bordered table-striped table-hover"">
                        <tbody>
                            <tr>
                                <td scope=""row"">
                                    <strong>Nazwa</strong>
                                </td>
                                <td scope=""row"">
                                    ");
                EndContext();
                BeginContext(1060, 10, false);
#line 37 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
                               Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1070, 328, true);
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Data wydania</strong>
                                </td>
                                <td>
                                    ");
                EndContext();
                BeginContext(1399, 17, false);
#line 45 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
                               Write(Model.ReleaseDate);

#line default
#line hidden
                EndContext();
                BeginContext(1416, 323, true);
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Cena</strong>
                                </td>
                                <td>
                                    <p>");
                EndContext();
                BeginContext(1740, 11, false);
#line 53 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
                                  Write(Model.price);

#line default
#line hidden
                EndContext();
                BeginContext(1751, 343, true);
                WriteLiteral(@" &euro;</p>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Link do decku:</strong>
                                </td>
                                <td>
                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2094, "\"", 2116, 1);
#line 61 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2101, Model.deckPath, 2101, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2117, 2, true);
                WriteLiteral("> ");
                EndContext();
                BeginContext(2120, 14, false);
#line 61 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
                                                          Write(Model.deckPath);

#line default
#line hidden
                EndContext();
                BeginContext(2134, 340, true);
                WriteLiteral(@"</a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Linki do kupienia:</strong>
                                </td>
                                <td>
                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2474, "\"", 2495, 1);
#line 69 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2481, Model.TCGpath, 2481, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2496, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2498, 13, false);
#line 69 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
                                                        Write(Model.TCGpath);

#line default
#line hidden
                EndContext();
                BeginContext(2511, 58, true);
                WriteLiteral(" </a><br /> <br />\r\n                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2569, "\"", 2589, 1);
#line 70 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2576, Model.CMpath, 2576, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2590, 43, true);
                WriteLiteral(">\r\n                                        ");
                EndContext();
                BeginContext(2634, 12, false);
#line 71 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
                                   Write(Model.CMpath);

#line default
#line hidden
                EndContext();
                BeginContext(2646, 95, true);
                WriteLiteral("\r\n                                    </a><br /> <br />\r\n                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2741, "\"", 2761, 1);
#line 73 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2748, Model.CHpath, 2748, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2762, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2764, 12, false);
#line 73 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
                                                       Write(Model.CHpath);

#line default
#line hidden
                EndContext();
                BeginContext(2776, 264, true);
                WriteLiteral(@"</a> <br /> <br />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class=""col-6 col-sm-6"">
                    <img class=""img""");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3040, "\"", 3060, 1);
#line 80 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3046, Model.ImgPath, 3046, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3061, 65, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 84 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Index.cshtml"

    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DailyCardModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
