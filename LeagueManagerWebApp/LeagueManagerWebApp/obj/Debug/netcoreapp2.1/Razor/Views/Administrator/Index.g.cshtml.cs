#pragma checksum "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbe10995f54d5afdc7b30dfabc4b6a07ace01bb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_Index), @"mvc.1.0.view", @"/Views/Administrator/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrator/Index.cshtml", typeof(AspNetCore.Views_Administrator_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbe10995f54d5afdc7b30dfabc4b6a07ace01bb7", @"/Views/Administrator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5454ee5753f3ce4da448d50e61a9e2ea96b13d00", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeagueManagerWebApp.ViewModels.AdminViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(142, 324, true);
            WriteLiteral(@"
<div class=""body-content container-fluid"">
    <div class=""container-fluid"">
        <div class=""row justify-content-center"">
            <div class=""row justify-content-center"">
                <div class=""col"">
                    <div class=""btn"">
                        <a class=""btn btn-outline-primary btn-lg""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 466, "\"", 518, 1);
#line 13 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
WriteAttributeValue("", 473, Url.Action("PlayerCreator", "Administrator"), 473, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(519, 212, true);
            WriteLiteral(">Player Creator</a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <div class=\"btn\">\r\n                        <a class=\"btn btn-outline-primary btn-lg\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 731, "\"", 789, 1);
#line 18 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
WriteAttributeValue("", 738, Url.Action("AchievementsCreator", "Administrator"), 738, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(790, 218, true);
            WriteLiteral(">Achievements Creator</a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <div class=\"btn\">\r\n                        <a class=\"btn btn-outline-primary btn-lg\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1008, "\"", 1060, 1);
#line 23 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
WriteAttributeValue("", 1015, Url.Action("LeagueCreator", "Administrator"), 1015, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1061, 214, true);
            WriteLiteral(">League Creator</a>\r\n                    </div>\r\n\r\n                </div>\r\n                <div class=\"col\">\r\n                    <div class=\"btn\">\r\n                        <a class=\"btn btn-outline-primary btn-lg\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1275, "\"", 1322, 1);
#line 29 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
WriteAttributeValue("", 1282, Url.Action("AddScore", "Administrator"), 1282, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1323, 283, true);
            WriteLiteral(@">Add score</a>
                    </div>

                </div>
            </div>
            <div class=""row justify-content-center"">
                <div class=""col"">
                    <div class=""btn"">
                        <a class=""btn btn-outline-primary btn-lg""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1606, "\"", 1657, 1);
#line 37 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
WriteAttributeValue("", 1613, Url.Action("PlayerEditor", "Administrator"), 1613, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1658, 211, true);
            WriteLiteral(">Player Editor</a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <div class=\"btn\">\r\n                        <a class=\"btn btn-outline-primary btn-lg\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1869, "\"", 1925, 1);
#line 42 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
WriteAttributeValue("", 1876, Url.Action("AchievementEditor", "Administrator"), 1876, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1926, 217, true);
            WriteLiteral(">Achievements Editor</a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <div class=\"btn\">\r\n                        <a class=\"btn btn-outline-primary btn-lg\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2143, "\"", 2194, 1);
#line 47 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
WriteAttributeValue("", 2150, Url.Action("LeagueEditor", "Administrator"), 2150, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2195, 213, true);
            WriteLiteral(">League Editor</a>\r\n                    </div>\r\n\r\n                </div>\r\n                <div class=\"col\">\r\n                    <div class=\"btn\">\r\n                        <a class=\"btn btn-outline-primary btn-lg\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2408, "\"", 2460, 1);
#line 53 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
WriteAttributeValue("", 2415, Url.Action("LeagueStarter", "Administrator"), 2415, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2461, 684, true);
            WriteLiteral(@">League Starter</a>
                    </div>

                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col"">
                <table class=""table-bordered"">
                    <thead>
                        <tr>
                            <th>
                                Id
                            </th>
                            <th>
                                Name
                            </th>
                            <th>
                                Elo
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 76 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                         if (Model.PlayerList != null)
                        {
                            foreach (var elem in Model.PlayerList)
                            {

#line default
#line hidden
            BeginContext(3327, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3448, 7, false);
#line 82 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                                   Write(elem.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3455, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3583, 9, false);
#line 85 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                                   Write(elem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3592, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3720, 8, false);
#line 88 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                                   Write(elem.Elo);

#line default
#line hidden
            EndContext();
            BeginContext(3728, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 91 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(3870, 625, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
            <div class=""col"">
                <table class=""table-bordered"">
                    <thead>
                        <tr>
                            <th>
                                Id
                            </th>
                            <th>
                                Name
                            </th>
                            <th>
                                Points
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 112 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                         if (Model.AchievementList != null)
                        {
                            foreach (var elem in Model.AchievementList)
                            {

#line default
#line hidden
            BeginContext(4687, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4808, 7, false);
#line 118 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                                   Write(elem.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4815, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4943, 9, false);
#line 121 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                                   Write(elem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4952, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(5080, 11, false);
#line 124 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                                   Write(elem.Points);

#line default
#line hidden
            EndContext();
            BeginContext(5091, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 127 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(5233, 626, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
            <div class=""col"">
                <table class=""table-bordered"">
                    <thead>
                        <tr>
                            <th>
                                Id
                            </th>
                            <th>
                                Name
                            </th>
                            <th>
                                Players
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 148 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                     if (Model.LeagueList != null)
                    {
                        foreach (var elem in Model.LeagueList)
                        {

#line default
#line hidden
            BeginContext(6025, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(6134, 7, false);
#line 154 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                               Write(elem.Id);

#line default
#line hidden
            EndContext();
            BeginContext(6141, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(6257, 9, false);
#line 157 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                               Write(elem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(6266, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(6382, 12, false);
#line 160 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                               Write(elem.Players);

#line default
#line hidden
            EndContext();
            BeginContext(6394, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 163 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\Index.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(6520, 114, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeagueManagerWebApp.ViewModels.AdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591