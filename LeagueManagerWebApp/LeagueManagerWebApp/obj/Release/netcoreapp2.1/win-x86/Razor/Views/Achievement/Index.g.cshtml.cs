#pragma checksum "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Achievement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f14cbf7eb0ab8375b3790c161b71e3dafef80627"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Achievement_Index), @"mvc.1.0.view", @"/Views/Achievement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Achievement/Index.cshtml", typeof(AspNetCore.Views_Achievement_Index))]
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
#line 1 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Achievement\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f14cbf7eb0ab8375b3790c161b71e3dafef80627", @"/Views/Achievement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5454ee5753f3ce4da448d50e61a9e2ea96b13d00", @"/Views/_ViewImports.cshtml")]
    public class Views_Achievement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LeagueManagerWebApp.Models.AchievementModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowStandings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddAchievement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Achievement\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(242, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(244, 2001, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "122a5492da6d412a84320dc31a64be34", async() => {
                BeginContext(250, 172, true);
                WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n        <h2 class=\"display-2\">Osiągnięcia</h2>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <p>\r\n                ");
                EndContext();
                BeginContext(422, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10a5c7d0c558495f98ed4c1ae195b59f", async() => {
                    BeginContext(493, 7, true);
                    WriteLiteral("Ranking");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(504, 36, true);
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n");
                EndContext();
#line 20 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Achievement\Index.cshtml"
         if (User.IsInRole("Admin"))
        {

#line default
#line hidden
                BeginContext(589, 49, true);
                WriteLiteral("            <div class=\"col-6\">\r\n                ");
                EndContext();
                BeginContext(638, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a628eac647a3450c90419f317be78131", async() => {
                    BeginContext(710, 21, true);
                    WriteLiteral("Przydziel osiągnięcie");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(735, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 25 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Achievement\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(768, 281, true);
                WriteLiteral(@"    </div>
    <div class=""row"">
        <div class=""col-12"">
            <table class=""table table-striped table-bordered table-hover"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">
                            ");
                EndContext();
                BeginContext(1050, 40, false);
#line 33 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Achievement\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1090, 103, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th scope=\"col\">\r\n                            ");
                EndContext();
                BeginContext(1194, 47, false);
#line 36 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Achievement\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(1241, 103, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th scope=\"col\">\r\n                            ");
                EndContext();
                BeginContext(1345, 42, false);
#line 39 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Achievement\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Points));

#line default
#line hidden
                EndContext();
                BeginContext(1387, 111, true);
                WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
                EndContext();
#line 44 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Achievement\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
                BeginContext(1571, 127, true);
                WriteLiteral("                        <tr>\r\n                            <td scope=\"row\" data-label=\"Nazwa\">\r\n                                ");
                EndContext();
                BeginContext(1699, 39, false);
#line 48 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Achievement\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1738, 121, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td data-label=\"Opis\">\r\n                                ");
                EndContext();
                BeginContext(1860, 46, false);
#line 51 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Achievement\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
                EndContext();
                BeginContext(1906, 123, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td data-label=\"Punkty\">\r\n                                ");
                EndContext();
                BeginContext(2030, 41, false);
#line 54 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Achievement\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Points));

#line default
#line hidden
                EndContext();
                BeginContext(2071, 68, true);
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 57 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Achievement\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(2162, 76, true);
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
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
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LeagueManagerWebApp.Models.AchievementModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
