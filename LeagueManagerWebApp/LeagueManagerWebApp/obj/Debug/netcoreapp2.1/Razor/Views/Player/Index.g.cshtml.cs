#pragma checksum "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c3557944f5579205896d7443c3d94d936d54be0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Player_Index), @"mvc.1.0.view", @"/Views/Player/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Player/Index.cshtml", typeof(AspNetCore.Views_Player_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c3557944f5579205896d7443c3d94d936d54be0", @"/Views/Player/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5454ee5753f3ce4da448d50e61a9e2ea96b13d00", @"/Views/_ViewImports.cshtml")]
    public class Views_Player_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeagueManagerWebApp.ViewModels.PlayerViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 117, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <h1 class=\"text-left\">Nick: ");
            EndContext();
            BeginContext(216, 10, false);
#line 10 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(226, 147, true);
            WriteLiteral("</h1> <br/>\r\n        </div>\r\n    </div>\r\n    <br/>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <h3 class=\"text-left\">Rozegrane: ");
            EndContext();
            BeginContext(374, 19, false);
#line 16 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
                                        Write(Model.MatchesPlayed);

#line default
#line hidden
            EndContext();
            BeginContext(393, 58, true);
            WriteLiteral("</h3> <br>\r\n            <h3 class=\"text-left\">Zwycięstwa: ");
            EndContext();
            BeginContext(452, 17, false);
#line 17 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
                                         Write(Model.MatchesLost);

#line default
#line hidden
            EndContext();
            BeginContext(469, 55, true);
            WriteLiteral("</h3> <br>\r\n            <h3 class=\"text-left\">Porażki: ");
            EndContext();
            BeginContext(525, 16, false);
#line 18 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
                                      Write(Model.MatchesWon);

#line default
#line hidden
            EndContext();
            BeginContext(541, 51, true);
            WriteLiteral("</h3> <br>\r\n            <h3 class=\"text-left\">Elo: ");
            EndContext();
            BeginContext(593, 9, false);
#line 19 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
                                  Write(Model.Elo);

#line default
#line hidden
            EndContext();
            BeginContext(602, 12, true);
            WriteLiteral("</h3> <br>\r\n");
            EndContext();
#line 20 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
             if (Model.MatchesPlayed != 0)
            {

#line default
#line hidden
            BeginContext(673, 51, true);
            WriteLiteral("                <h3 class=\"text-left\">% zwycięstw: ");
            EndContext();
            BeginContext(726, 44, false);
#line 22 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
                                               Write(Model.MatchesWon * 100 / Model.MatchesPlayed);

#line default
#line hidden
            EndContext();
            BeginContext(771, 31, true);
            WriteLiteral(" %</h3>\r\n                <br>\r\n");
            EndContext();
#line 24 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(850, 60, true);
            WriteLiteral("                <h3 class=\"text-left\">% zwycięstw: 0%</h3>\r\n");
            EndContext();
#line 28 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(925, 114, true);
            WriteLiteral("        </div>\r\n    </div>\r\n        <div class=\"row\">\r\n            <a class=\"text-right\">Historia gier:</a> <br>\r\n");
            EndContext();
#line 33 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
             if (Model.MatchesPlayed > 0)
            {

#line default
#line hidden
            BeginContext(1097, 625, true);
            WriteLiteral(@"                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>
                                    Player 1
                                </th>
                                <th>
                                    Player 2
                                </th>
                                <th>
                                    Zwycięzca
                                </th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 51 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
                             if (Model.MatchupsHistory != null)
                            {
                                foreach (var elem in Model.MatchupsHistory)
                                {

#line default
#line hidden
            BeginContext(1930, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2063, 12, false);
#line 57 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
                                       Write(elem.Player1);

#line default
#line hidden
            EndContext();
            BeginContext(2075, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2215, 12, false);
#line 60 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
                                       Write(elem.Player2);

#line default
#line hidden
            EndContext();
            BeginContext(2227, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2367, 11, false);
#line 63 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
                                       Write(elem.Winner);

#line default
#line hidden
            EndContext();
            BeginContext(2378, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 66 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(2536, 64, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
            EndContext();
#line 70 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Player\Index.cshtml"
                
            }

#line default
#line hidden
            BeginContext(2633, 30, true);
            WriteLiteral("        </div>\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeagueManagerWebApp.ViewModels.PlayerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
