#pragma checksum "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16c5c1cd8a87dac598b0179613812963b2414abc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Index), @"mvc.1.0.view", @"/Views/Event/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/Index.cshtml", typeof(AspNetCore.Views_Event_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c5c1cd8a87dac598b0179613812963b2414abc", @"/Views/Event/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5454ee5753f3ce4da448d50e61a9e2ea96b13d00", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LeagueManagerWebApp.Models.EventModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Voting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VotingResults", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 2559, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "298e9fdf10ac49609cc4688428c5e1b0", async() => {
                BeginContext(108, 372, true);
                WriteLiteral(@"
    <div class=""row justify-content-center"">
        <h2 class=""display-2"">Terminarz</h2>
    </div>
    <div class=""row"">
        <div class=""col"">
            <table class=""table table-bordered table-striped table-hover"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">
                            ");
                EndContext();
                BeginContext(481, 38, false);
#line 16 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(519, 103, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th scope=\"col\">\r\n                            ");
                EndContext();
                BeginContext(623, 42, false);
#line 19 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Format));

#line default
#line hidden
                EndContext();
                BeginContext(665, 103, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th scope=\"col\">\r\n                            ");
                EndContext();
                BeginContext(769, 42, false);
#line 22 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Winner));

#line default
#line hidden
                EndContext();
                BeginContext(811, 103, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th scope=\"col\">\r\n                            ");
                EndContext();
                BeginContext(915, 40, false);
#line 25 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
                EndContext();
                BeginContext(955, 219, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th scope=\"col\">\r\n                            Akcje\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
                EndContext();
#line 33 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
                BeginContext(1247, 127, true);
                WriteLiteral("                        <tr>\r\n                            <td scope=\"row\" data-label=\"Numer\">\r\n                                ");
                EndContext();
                BeginContext(1375, 37, false);
#line 37 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(1412, 123, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td data-label=\"Format\">\r\n                                ");
                EndContext();
                BeginContext(1536, 41, false);
#line 40 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Format));

#line default
#line hidden
                EndContext();
                BeginContext(1577, 126, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td data-label=\"Zwycięzca\">\r\n                                ");
                EndContext();
                BeginContext(1704, 41, false);
#line 43 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Winner));

#line default
#line hidden
                EndContext();
                BeginContext(1745, 121, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td data-label=\"Data\">\r\n                                ");
                EndContext();
                BeginContext(1867, 29, false);
#line 46 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                           Write(item.Date.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(1896, 90, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td data-label=\"Akcje\">\r\n");
                EndContext();
#line 49 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                                 if (!item.isVotingFinished)
                                {

#line default
#line hidden
                BeginContext(2083, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(2119, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4601df0b34f84c1c9e3e69d5c2ba97d2", async() => {
                    BeginContext(2197, 10, true);
                    WriteLiteral("Głosowanie");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 51 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                                                                                            WriteLiteral(item.Id);

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
                BeginContext(2211, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 52 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(2321, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(2357, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "224edce39f9f4406a5b45d18787a67c9", async() => {
                    BeginContext(2442, 6, true);
                    WriteLiteral("Wyniki");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 55 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                                                                                                   WriteLiteral(item.Id);

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
                BeginContext(2452, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 56 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(2489, 66, true);
                WriteLiteral("                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 59 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(2578, 76, true);
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LeagueManagerWebApp.Models.EventModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
