#pragma checksum "/Users/momo/Desktop/BankAccount/Views/Home/Bank.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "494824b2eeed96aa0ea0a13eaeb85ce4940ac49c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Bank), @"mvc.1.0.view", @"/Views/Home/Bank.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Bank.cshtml", typeof(AspNetCore.Views_Home_Bank))]
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
#line 1 "/Users/momo/Desktop/BankAccount/Views/_ViewImports.cshtml"
using BankAccount;

#line default
#line hidden
#line 2 "/Users/momo/Desktop/BankAccount/Views/_ViewImports.cshtml"
using BankAccount.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"494824b2eeed96aa0ea0a13eaeb85ce4940ac49c", @"/Views/Home/Bank.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b20f887a8df0d276701ac0f260ce405b9af56dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Bank : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Transaction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Calculate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/momo/Desktop/BankAccount/Views/Home/Bank.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 39, true);
            WriteLiteral("\n<div class=\"top_bar\">\n    <h1>Welcome ");
            EndContext();
            BeginContext(82, 22, false);
#line 6 "/Users/momo/Desktop/BankAccount/Views/Home/Bank.cshtml"
           Write(ViewBag.user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(104, 110, true);
            WriteLiteral("</h1>\n    <div class=\"balance_container\">\n        <p>Current Balance</p>\n        <div class=\"balance_amount\">$");
            EndContext();
            BeginContext(215, 15, false);
#line 9 "/Users/momo/Desktop/BankAccount/Views/Home/Bank.cshtml"
                                Write(ViewBag.balance);

#line default
#line hidden
            EndContext();
            BeginContext(230, 26, true);
            WriteLiteral("</div>\n    </div>\n</div>\n\n");
            EndContext();
            BeginContext(281, 68, true);
            WriteLiteral("\n<div class=\"top_bar2\">\n    <div class=\"balance_container\">\n        ");
            EndContext();
            BeginContext(349, 277, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "494824b2eeed96aa0ea0a13eaeb85ce4940ac49c4950", async() => {
                BeginContext(388, 231, true);
                WriteLiteral("\n                <span validation-for=\"Amount\"></span>\n                <label for=\"Amount\">Deposit/Withdraw</label>\n                <input type=\"number\" name=\"Amount\">\n\n                <input value=\"Submit\" type=\"submit\"> \n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(626, 110, true);
            WriteLiteral("\n        \n    </div>\n</div>\n\n<table class=\"chef_table\">\n  <tr>\n    <th>Amount</th>\n    <th>Date</th> \n  </tr>\n");
            EndContext();
#line 33 "/Users/momo/Desktop/BankAccount/Views/Home/Bank.cshtml"
     foreach(var trans in Model){



#line default
#line hidden
            BeginContext(772, 21, true);
            WriteLiteral("    <tr>\n        <td>");
            EndContext();
            BeginContext(794, 12, false);
#line 37 "/Users/momo/Desktop/BankAccount/Views/Home/Bank.cshtml"
       Write(trans.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(806, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(825, 15, false);
#line 38 "/Users/momo/Desktop/BankAccount/Views/Home/Bank.cshtml"
       Write(trans.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(840, 16, true);
            WriteLiteral("</td>\n    </tr>\n");
            EndContext();
#line 40 "/Users/momo/Desktop/BankAccount/Views/Home/Bank.cshtml"
    }

#line default
#line hidden
            BeginContext(862, 9, true);
            WriteLiteral("\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
