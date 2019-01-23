#pragma checksum "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2705590c43d96d7beea45c1c156a4e21186ce3b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_ScoreView), @"mvc.1.0.view", @"/Views/Administrator/ScoreView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrator/ScoreView.cshtml", typeof(AspNetCore.Views_Administrator_ScoreView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2705590c43d96d7beea45c1c156a4e21186ce3b9", @"/Views/Administrator/ScoreView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5454ee5753f3ce4da448d50e61a9e2ea96b13d00", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_ScoreView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeagueManagerWebApp.ViewModels.ScoreViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administrator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetLeagueMatchups", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddScoreFinal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
  
    ViewData["Title"] = "ScoreView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(146, 107, true);
            WriteLiteral("\r\n<h2>ScoreView</h2>\r\n<div class=\"container-fluid\">\r\n    <div class=\"row justify-content-center\">\r\n        ");
            EndContext();
            BeginContext(253, 914, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf8d35bc3011499a971705eae1b9fba7", async() => {
                BeginContext(335, 300, true);
                WriteLiteral(@"
            <div class=""container-fluid"">
                <div class=""row justify-content-center"">
                    <div class=""col"">
                        Player name: <br />
                    </div>
                    <div class=""col"">
                        <select name=""Name"">
");
                EndContext();
#line 18 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
                             foreach (var elem in Model.Leagues)
                            {

#line default
#line hidden
                BeginContext(732, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(764, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "057c7675b7354bcc8736dfce1b910ea1", async() => {
                    BeginContext(795, 9, false);
#line 20 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
                                                         Write(elem.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 20 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
                                    WriteLiteral(elem.Name);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(814, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 21 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
                            }

#line default
#line hidden
                BeginContext(847, 313, true);
                WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div class=""row justify-content-center"">
                    <div class=""col"">
                        <input type=""submit"" />
                    </div>
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1167, 700, true);
            WriteLiteral(@"
    </div>
    
    <div class=""row justify-content-center"">
        <table>
            <thead>
            <tr>
                <th>
                    Id
                </th>
                <th>
                    Player 1
                </th>
                <th>
                    Player 2
                </th>
                <th>
                    Winner
                </th>
                <th>
                    Loser
                </th>
                <th>
                    Is Finished?
                </th>
                <th>
                    League
                </th>
            </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 62 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
              if (Model.Matchups != null)
             {
                 foreach (var elem in Model.Matchups)
                  {

#line default
#line hidden
            BeginContext(2002, 90, true);
            WriteLiteral("                      <tr>\r\n                          <td>\r\n                              ");
            EndContext();
            BeginContext(2093, 7, false);
#line 68 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
                         Write(elem.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2100, 97, true);
            WriteLiteral("\r\n                          </td>\r\n                          <td>\r\n                              ");
            EndContext();
            BeginContext(2198, 12, false);
#line 71 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
                         Write(elem.Player1);

#line default
#line hidden
            EndContext();
            BeginContext(2210, 97, true);
            WriteLiteral("\r\n                          </td>\r\n                          <td>\r\n                              ");
            EndContext();
            BeginContext(2308, 12, false);
#line 74 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
                         Write(elem.Player2);

#line default
#line hidden
            EndContext();
            BeginContext(2320, 97, true);
            WriteLiteral("\r\n                          </td>\r\n                          <td>\r\n                              ");
            EndContext();
            BeginContext(2418, 11, false);
#line 77 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
                         Write(elem.Winner);

#line default
#line hidden
            EndContext();
            BeginContext(2429, 97, true);
            WriteLiteral("\r\n                          </td>\r\n                          <td>\r\n                              ");
            EndContext();
            BeginContext(2527, 10, false);
#line 80 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
                         Write(elem.Loser);

#line default
#line hidden
            EndContext();
            BeginContext(2537, 97, true);
            WriteLiteral("\r\n                          </td>\r\n                          <td>\r\n                              ");
            EndContext();
            BeginContext(2635, 15, false);
#line 83 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
                         Write(elem.IsFinished);

#line default
#line hidden
            EndContext();
            BeginContext(2650, 97, true);
            WriteLiteral("\r\n                          </td>\r\n                          <td>\r\n                              ");
            EndContext();
            BeginContext(2748, 15, false);
#line 86 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
                         Write(elem.LeagueName);

#line default
#line hidden
            EndContext();
            BeginContext(2763, 97, true);
            WriteLiteral("\r\n                          </td>\r\n                          <td>\r\n                              ");
            EndContext();
            BeginContext(2860, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7fcf8da9d264c3a8f8386adae2422ee", async() => {
                BeginContext(2914, 11, true);
                WriteLiteral("Score sheet");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
                                                              WriteLiteral(elem.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2929, 64, true);
            WriteLiteral("\r\n                          </td>\r\n                      </tr>\r\n");
            EndContext();
#line 92 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Administrator\ScoreView.cshtml"
                  }
             }

#line default
#line hidden
            BeginContext(3030, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeagueManagerWebApp.ViewModels.ScoreViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
