#pragma checksum "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2584dd8a1c999984b10e483b58e6740dc987c54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Voting), @"mvc.1.0.view", @"/Views/Event/Voting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/Voting.cshtml", typeof(AspNetCore.Views_Event_Voting))]
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
#line 1 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
using System.Reflection.Metadata;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2584dd8a1c999984b10e483b58e6740dc987c54", @"/Views/Event/Voting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5454ee5753f3ce4da448d50e61a9e2ea96b13d00", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Voting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeagueManagerWebApp.Dto.VotingDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubmitVote", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
  
    ViewData["Title"] = "Voting";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(166, 84, true);
            WriteLiteral("\r\n<h2>Voting</h2>\r\n<p>Choose your option: <br/></p>\r\n\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(250, 2858, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29f60041bf884ddb97598e49d26afd2f", async() => {
                BeginContext(303, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(313, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33d5d11d967345308680d27a0a54f1f4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 13 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(349, 76, true);
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(426, 41, false);
#line 16 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.DisplayNameFor(model => model.Stand));

#line default
#line hidden
                EndContext();
                BeginContext(467, 69, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(537, 28, false);
#line 19 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.CheckBoxFor(m=>m.Stand));

#line default
#line hidden
                EndContext();
                BeginContext(565, 130, true);
                WriteLiteral("\r\n                \r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(696, 39, false);
#line 25 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.DisplayNameFor(model => model.Mod));

#line default
#line hidden
                EndContext();
                BeginContext(735, 69, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(805, 28, false);
#line 28 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.CheckBoxFor(m => m.Mod));

#line default
#line hidden
                EndContext();
                BeginContext(833, 112, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(946, 39, false);
#line 33 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.DisplayNameFor(model => model.Pau));

#line default
#line hidden
                EndContext();
                BeginContext(985, 69, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(1055, 28, false);
#line 36 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.CheckBoxFor(m => m.Pau));

#line default
#line hidden
                EndContext();
                BeginContext(1083, 112, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(1196, 40, false);
#line 41 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.DisplayNameFor(model => model.Rain));

#line default
#line hidden
                EndContext();
                BeginContext(1236, 69, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(1306, 29, false);
#line 44 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.CheckBoxFor(m => m.Rain));

#line default
#line hidden
                EndContext();
                BeginContext(1335, 112, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(1448, 41, false);
#line 49 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.DisplayNameFor(model => model.Draft));

#line default
#line hidden
                EndContext();
                BeginContext(1489, 69, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(1559, 30, false);
#line 52 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.CheckBoxFor(m => m.Draft));

#line default
#line hidden
                EndContext();
                BeginContext(1589, 112, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(1702, 40, false);
#line 57 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.DisplayNameFor(model => model.Sing));

#line default
#line hidden
                EndContext();
                BeginContext(1742, 69, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(1812, 29, false);
#line 60 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.CheckBoxFor(m => m.Sing));

#line default
#line hidden
                EndContext();
                BeginContext(1841, 112, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(1954, 39, false);
#line 65 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.DisplayNameFor(model => model.Tri));

#line default
#line hidden
                EndContext();
                BeginContext(1993, 69, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(2063, 28, false);
#line 68 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.CheckBoxFor(m => m.Tri));

#line default
#line hidden
                EndContext();
                BeginContext(2091, 112, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(2204, 39, false);
#line 73 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.DisplayNameFor(model => model.Pea));

#line default
#line hidden
                EndContext();
                BeginContext(2243, 69, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(2313, 28, false);
#line 76 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.CheckBoxFor(m => m.Pea));

#line default
#line hidden
                EndContext();
                BeginContext(2341, 112, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(2454, 39, false);
#line 81 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.DisplayNameFor(model => model.War));

#line default
#line hidden
                EndContext();
                BeginContext(2493, 69, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(2563, 28, false);
#line 84 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.CheckBoxFor(m => m.War));

#line default
#line hidden
                EndContext();
                BeginContext(2591, 112, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(2704, 40, false);
#line 89 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.DisplayNameFor(model => model.Back));

#line default
#line hidden
                EndContext();
                BeginContext(2744, 69, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(2814, 29, false);
#line 92 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\Voting.cshtml"
           Write(Html.CheckBoxFor(m => m.Back));

#line default
#line hidden
                EndContext();
                BeginContext(2843, 258, true);
                WriteLiteral(@"
            </div>
        </div>
        <div class=""row"">
            <div class=""col"">
                Submit vote
            </div>
            <div class=""col"">
                <input type=""submit""/>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3108, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeagueManagerWebApp.Dto.VotingDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
