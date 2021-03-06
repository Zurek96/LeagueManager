#pragma checksum "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Rules.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "885ab10ad428ac42ff340dd29d87e1d605714049"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Rules), @"mvc.1.0.view", @"/Views/Home/Rules.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Rules.cshtml", typeof(AspNetCore.Views_Home_Rules))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"885ab10ad428ac42ff340dd29d87e1d605714049", @"/Views/Home/Rules.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5454ee5753f3ce4da448d50e61a9e2ea96b13d00", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Rules : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\MZurowsk\source\repos\LeagueManagerWebApp\LeagueManagerWebApp\Views\Home\Rules.cshtml"
  
    ViewData["Title"] = "Rules";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(90, 3363, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b22ab2c853874a00a8766df488694b6a", async() => {
                BeginContext(96, 3290, true);
                WriteLiteral(@"
    <div class=""container"" style=""margin-left: 10%"">
        <h2>Rules</h2>

        <h4>
            Postanowienia ogólne <br />
        </h4>
        <p>
            <ol>
                <li>Liga ma na celu dobrą zabawę uczestników, ale też przyzwyczajenie do turniejowego stylu rozgrywania partii,</li>
                <li>W przypadku wszelkich wątpliwości, spory rozstrzygane są przez wszystkich uczestników, nie ma jednogłośnego sędziego,</li>
                <li>Liga rozgrywana jest w formacie standard constructed. Każda talia składa się z minimum 60 kart oraz maksymalnie 15 kart na sideboardzie,</li>
                <li>Liga składa się z kolejek (turniejów). W każdym turnieju rozgrywane są mecze na zasadzie ""każdy z każdym"", chyba, że liczba uczestników będzie na tyle duża, że zajęłoby to za dużo czasu. Wtedy turniej przeprowadzany jest w formie 4 rund losowanych na podstawie wyników rozgrywek,</li>
                <li>Nagrodą za zwycięstwo w turnieju jest booster z setu wybranego przez zwyci");
                WriteLiteral(@"ęzcę. Booster jest finansowany z funduszu wspólnego na który składają się kazdorazowo uczestnicy ligi,</li>
                <li>Dzień turniejowy został określony większością głosów na wtorek. W wypadku określonych wydarzeń, dzień turniejowy ulega zmianie na inny, wybrany większością głosów,</li>
                <li>Mecze rozgrywane sa do dwóch wygranych partii. W przypadku wyjątkowo długich partii, po 50 minutach następuje terminacja na standardowych zasadach,</li>
                <li>Jeśli gracz zapowie swoją nieobecność na turnieju z minimum dniowym wyprzedzeniem, nie sa wyciągane zadne konsekwencje,</li>
                <li>Jeśli gracz nie zapowie swojej nieobecności minimum dzień przed rozpoczęciem turnieju, oraz nie będzie miał odpowiedniego usprawiedliwienia, wyciągane sa konsekwencje konsultowane przez obecnych zawodników na turnieju.</li>
                <li>Format kolejnego spotkania ustalany jest w ciągu 48 godzin od zakończenia poprzedniego przez głosowanie przez stronę.</li>
            </ol");
                WriteLiteral(@">
        </p>
        <h4>
            Punkty <br />
        </h4>
        <p>
            <ol>
                <li>Punktacja prowadzona jest w systemie punktów ELO,</li>
                <li>Każdy gracz rozpozyna z pulą 1600 punktów ELO, i po każdym turnieju ilosć punktów jest zmieniana,</li>
                <li>Zwycięzcą turnieju zostaje osoba, która wygra najwięcej partii w danym turnieju,</li>
                <li>Zwycięzcą ligi zostaje ten, kto ma najwięcej punktów ELO po całej lidze,</li>
                <li>Zwyciązcą osiągnięć zostaje ten, kto ma najwięcej punktów za osiągnięcia po całej lidze,</li>
                <li>Nagrody zostają ustalone po rozegraniu ligi.</li>
            </ol>
        </p>
        <h4>
            Pozostałe kwestie <br />
        </h4>
        <p>
            <ol>
                <li>Administratorem portalu jestem ja, tzn. Mikołaj Żurowski. Wszelkie bugi, błędy, wyjątki, uwagi oraz propozycje proszę zgłaszać na bieżąco.</li>
                <li>Portal będzi");
                WriteLiteral("e wysyłał podsumowania i przypomnienia mailowe tylko i wyłącznie osobom, które dały mi na to jasne pozwolenie na Facebooku lub w inny, niewerbalny sposób</li>\r\n            </ol>\r\n        </p>\r\n        <p>\r\n            ");
                EndContext();
                BeginContext(3386, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "929cd52195bb4c5dbd0a8accb3cf79c1", async() => {
                    BeginContext(3408, 6, true);
                    WriteLiteral("Powrót");
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
                BeginContext(3418, 28, true);
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
