#pragma checksum "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckListItem\Remover.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bafc7d6b215907d116e955ea7af3e83812c6c8c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CheckListItem_Remover), @"mvc.1.0.view", @"/Views/CheckListItem/Remover.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bafc7d6b215907d116e955ea7af3e83812c6c8c7", @"/Views/CheckListItem/Remover.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc97fd5ea0d9a47f58cfac4bd32cb9bedbfcfe9e", @"/Views/_ViewImports.cshtml")]
    public class Views_CheckListItem_Remover : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckList.ViewModel.CheckListItem.RemoverViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Remover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckListItem\Remover.cshtml"
  
    ViewData["Title"] = "Remover Item";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Remover um Item</h1>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bafc7d6b215907d116e955ea7af3e83812c6c8c74456", async() => {
                WriteLiteral("\r\n    \r\n    <div class=\"form-group\">\r\n        <label for=\"Id\">Id: </label>\r\n        <input type=\"text\" class=\"form-control\" id=\"id\"  name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 375, "\"", 392, 1);
#nullable restore
#line 15 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckListItem\Remover.cshtml"
WriteAttributeValue("", 383, Model.id, 383, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    \r\n    <div class=\"form-group\">\r\n        <label for=\"Titulo\">Titulo: ");
#nullable restore
#line 19 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckListItem\Remover.cshtml"
                               Write(Model.titulo);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"checklistId\">CheckList: ");
#nullable restore
#line 23 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckListItem\Remover.cshtml"
                                       Write(Model.checklistId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n                    \r\n    </div>\r\n    \r\n    <div class=\"form-group\">\r\n        <label for=\"SubItem\">SubItem:");
#nullable restore
#line 28 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckListItem\Remover.cshtml"
                                Write(Model.checklistItemId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n               \r\n    </div>\r\n    \r\n            \r\n    <div class=\"form-group\">\r\n        <label for=\"Realizado\">Realizado? ");
#nullable restore
#line 34 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckListItem\Remover.cshtml"
                                     Write(Model.realizado);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n                \r\n    </div>\r\n    \r\n            \r\n    <div class=\"form-group\">\r\n        <label for=\"DataRealizado\">Data de relização:");
#nullable restore
#line 40 "C:\Users\PedroVitorDev\Desktop\Checklist trabalho final Leonardo\Trabalho final Leo\CheckList\Views\CheckListItem\Remover.cshtml"
                                                Write(Model.dataRealizacao);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                \r\n    </div>\r\n    \r\n    <button type=\"submit\" class=\"btn btn-danger\">Remover </button>\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckList.ViewModel.CheckListItem.RemoverViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
