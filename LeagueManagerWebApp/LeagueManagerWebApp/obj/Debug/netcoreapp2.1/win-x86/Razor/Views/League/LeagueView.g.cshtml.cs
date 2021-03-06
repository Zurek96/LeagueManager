#pragma checksum "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\League\LeagueView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a121b9ff306a914a323a4ed978ae97b566208aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_League_LeagueView), @"mvc.1.0.view", @"/Views/League/LeagueView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/League/LeagueView.cshtml", typeof(AspNetCore.Views_League_LeagueView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a121b9ff306a914a323a4ed978ae97b566208aa", @"/Views/League/LeagueView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5454ee5753f3ce4da448d50e61a9e2ea96b13d00", @"/Views/_ViewImports.cshtml")]
    public class Views_League_LeagueView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PlayerModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\League\LeagueView.cshtml"
  
    ViewData["Title"] = "LeagueView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(119, 883, true);
            WriteLiteral(@"
<h2>LeagueView</h2>

<div class=""body-content container-fluid"">
    <div class=""container-fluid"">
        <div class=""row justify-content-center"">
            <div class=""col"">
                <table class=""table"">
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
                        <th>
                            Games Won
                        </th>
                        <th>
                            Games Lost
                        </th>
                        <th></th>
                    </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 35 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\League\LeagueView.cshtml"
                     if (Model != null)
                    {
                        foreach (var elem in Model)
                        {

#line default
#line hidden
            BeginContext(1146, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1255, 7, false);
#line 41 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\League\LeagueView.cshtml"
                               Write(elem.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1262, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1378, 9, false);
#line 44 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\League\LeagueView.cshtml"
                               Write(elem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1387, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1503, 8, false);
#line 47 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\League\LeagueView.cshtml"
                               Write(elem.Elo);

#line default
#line hidden
            EndContext();
            BeginContext(1511, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1627, 9, false);
#line 50 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\League\LeagueView.cshtml"
                               Write(elem.Wins);

#line default
#line hidden
            EndContext();
            BeginContext(1636, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1752, 11, false);
#line 53 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\League\LeagueView.cshtml"
                               Write(elem.Losses);

#line default
#line hidden
            EndContext();
            BeginContext(1763, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 56 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\League\LeagueView.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1889, 108, true);
            WriteLiteral("                    </tbody>\r\n            </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PlayerModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
