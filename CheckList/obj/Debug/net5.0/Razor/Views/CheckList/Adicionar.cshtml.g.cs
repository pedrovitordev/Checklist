#pragma checksum "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckList\Adicionar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "408c39a3a355bad5ea116481ef4467aadc38b2e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CheckList_Adicionar), @"mvc.1.0.view", @"/Views/CheckList/Adicionar.cshtml")]
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
#nullable restore
#line 1 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\_ViewImports.cshtml"
using CheckList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\_ViewImports.cshtml"
using CheckList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"408c39a3a355bad5ea116481ef4467aadc38b2e3", @"/Views/CheckList/Adicionar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc97fd5ea0d9a47f58cfac4bd32cb9bedbfcfe9e", @"/Views/_ViewImports.cshtml")]
    public class Views_CheckList_Adicionar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckList.ViewModel.CheckList.AdicionarViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Adicionar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckList\Adicionar.cshtml"
  
    ViewData["Title"] = "Adicionar CheckList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Adicionar uma CheckList</h1>\r\n</div>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckList\Adicionar.cshtml"
 if (@Model.msgErros != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("     <ul>\r\n");
#nullable restore
#line 14 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckList\Adicionar.cshtml"
          foreach (var msgErro in @Model.msgErros)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 16 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckList\Adicionar.cshtml"
                   Write(msgErro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 17 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckList\Adicionar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("     </ul>            \r\n");
#nullable restore
#line 19 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckList\Adicionar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "408c39a3a355bad5ea116481ef4467aadc38b2e35862", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"Nome\">Nome: </label>\r\n        <input type=\"text\" class=\"form-control\" id=\"Nome\" aria-describedby=\"emailHelp\" name=\"Nome\">\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Criar </button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckList.ViewModel.CheckList.AdicionarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
