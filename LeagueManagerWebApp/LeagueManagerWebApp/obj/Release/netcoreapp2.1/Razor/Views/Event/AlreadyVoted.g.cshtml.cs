#pragma checksum "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142d047277ec3480b41439ccd105e87e24c5d3ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_AlreadyVoted), @"mvc.1.0.view", @"/Views/Event/AlreadyVoted.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/AlreadyVoted.cshtml", typeof(AspNetCore.Views_Event_AlreadyVoted))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"142d047277ec3480b41439ccd105e87e24c5d3ea", @"/Views/Event/AlreadyVoted.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5454ee5753f3ce4da448d50e61a9e2ea96b13d00", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_AlreadyVoted : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VotingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
  
    ViewData["Title"] = "AlreadyVoted";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(115, 106, true);
            WriteLiteral("\r\n<h2>AlreadyVoted</h2>\r\n\r\n<p>\r\n    You have already voted. There are the results:\r\n</p>\r\n\r\n<ul>\r\n    <li>");
            EndContext();
            BeginContext(222, 41, false);
#line 14 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
   Write(Html.DisplayNameFor(model => Model.Stand));

#line default
#line hidden
            EndContext();
            BeginContext(263, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(267, 11, false);
#line 14 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
                                                Write(Model.Stand);

#line default
#line hidden
            EndContext();
            BeginContext(278, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(294, 39, false);
#line 15 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
   Write(Html.DisplayNameFor(model => Model.Mod));

#line default
#line hidden
            EndContext();
            BeginContext(333, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(337, 9, false);
#line 15 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
                                              Write(Model.Mod);

#line default
#line hidden
            EndContext();
            BeginContext(346, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(362, 39, false);
#line 16 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
   Write(Html.DisplayNameFor(model => Model.Pau));

#line default
#line hidden
            EndContext();
            BeginContext(401, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(405, 9, false);
#line 16 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
                                              Write(Model.Pau);

#line default
#line hidden
            EndContext();
            BeginContext(414, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(430, 40, false);
#line 17 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
   Write(Html.DisplayNameFor(model => Model.Rain));

#line default
#line hidden
            EndContext();
            BeginContext(470, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(474, 10, false);
#line 17 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
                                               Write(Model.Rain);

#line default
#line hidden
            EndContext();
            BeginContext(484, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(500, 41, false);
#line 18 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
   Write(Html.DisplayNameFor(model => Model.Draft));

#line default
#line hidden
            EndContext();
            BeginContext(541, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(545, 11, false);
#line 18 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
                                                Write(Model.Draft);

#line default
#line hidden
            EndContext();
            BeginContext(556, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(572, 40, false);
#line 19 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
   Write(Html.DisplayNameFor(model => Model.Sing));

#line default
#line hidden
            EndContext();
            BeginContext(612, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(616, 10, false);
#line 19 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
                                               Write(Model.Sing);

#line default
#line hidden
            EndContext();
            BeginContext(626, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(642, 39, false);
#line 20 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
   Write(Html.DisplayNameFor(model => Model.Tri));

#line default
#line hidden
            EndContext();
            BeginContext(681, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(685, 9, false);
#line 20 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
                                              Write(Model.Tri);

#line default
#line hidden
            EndContext();
            BeginContext(694, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(710, 39, false);
#line 21 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
   Write(Html.DisplayNameFor(model => Model.Pea));

#line default
#line hidden
            EndContext();
            BeginContext(749, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(753, 9, false);
#line 21 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
                                              Write(Model.Pea);

#line default
#line hidden
            EndContext();
            BeginContext(762, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(778, 39, false);
#line 22 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
   Write(Html.DisplayNameFor(model => Model.War));

#line default
#line hidden
            EndContext();
            BeginContext(817, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(821, 9, false);
#line 22 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
                                              Write(Model.War);

#line default
#line hidden
            EndContext();
            BeginContext(830, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(846, 40, false);
#line 23 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
   Write(Html.DisplayNameFor(model => Model.Back));

#line default
#line hidden
            EndContext();
            BeginContext(886, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(890, 10, false);
#line 23 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Event\AlreadyVoted.cshtml"
                                               Write(Model.Back);

#line default
#line hidden
            EndContext();
            BeginContext(900, 27, true);
            WriteLiteral("</li>\r\n\r\n</ul>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(927, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd37f2c100394b44b514d7ee00f2ecf3", async() => {
                BeginContext(949, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(957, 8, true);
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VotingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
