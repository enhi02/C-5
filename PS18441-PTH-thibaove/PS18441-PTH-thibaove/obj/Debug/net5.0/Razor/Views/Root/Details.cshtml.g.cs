#pragma checksum "D:\Skyfolder\Desktop\c5\PS18441-PTH-thibaove\PS18441-PTH-thibaove\Views\Root\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce56e069bc1f405e5bddda8409962369e5e1e495"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Root_Details), @"mvc.1.0.view", @"/Views/Root/Details.cshtml")]
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
#line 1 "D:\Skyfolder\Desktop\c5\PS18441-PTH-thibaove\PS18441-PTH-thibaove\Views\_ViewImports.cshtml"
using PS18441_PTH_thibaove;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Skyfolder\Desktop\c5\PS18441-PTH-thibaove\PS18441-PTH-thibaove\Views\_ViewImports.cshtml"
using PS18441_PTH_thibaove.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce56e069bc1f405e5bddda8409962369e5e1e495", @"/Views/Root/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caa4febd31896b99a4b39e3897f6df9fa5ca88da", @"/Views/_ViewImports.cshtml")]
    public class Views_Root_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PS18441_PTH_thibaove.Models.Root>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Skyfolder\Desktop\c5\PS18441-PTH-thibaove\PS18441-PTH-thibaove\Views\Root\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Root</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\Skyfolder\Desktop\c5\PS18441-PTH-thibaove\PS18441-PTH-thibaove\Views\Root\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RootID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\Skyfolder\Desktop\c5\PS18441-PTH-thibaove\PS18441-PTH-thibaove\Views\Root\Details.cshtml"
       Write(Html.DisplayFor(model => model.RootID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\Skyfolder\Desktop\c5\PS18441-PTH-thibaove\PS18441-PTH-thibaove\Views\Root\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\Skyfolder\Desktop\c5\PS18441-PTH-thibaove\PS18441-PTH-thibaove\Views\Root\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\Skyfolder\Desktop\c5\PS18441-PTH-thibaove\PS18441-PTH-thibaove\Views\Root\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PublishTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\Skyfolder\Desktop\c5\PS18441-PTH-thibaove\PS18441-PTH-thibaove\Views\Root\Details.cshtml"
       Write(Html.DisplayFor(model => model.PublishTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "D:\Skyfolder\Desktop\c5\PS18441-PTH-thibaove\PS18441-PTH-thibaove\Views\Root\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HeadImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 2484, "\"", 2535, 1);
#nullable restore
#line 78 "D:\Skyfolder\Desktop\c5\PS18441-PTH-thibaove\PS18441-PTH-thibaove\Views\Root\Details.cshtml"
WriteAttributeValue("", 2490, Html.DisplayFor(model => model.HeadImageUrl), 2490, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px\"/>\r\n            \r\n        </dd>\r\n");
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "D:\Skyfolder\Desktop\c5\PS18441-PTH-thibaove\PS18441-PTH-thibaove\Views\Root\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "D:\Skyfolder\Desktop\c5\PS18441-PTH-thibaove\PS18441-PTH-thibaove\Views\Root\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce56e069bc1f405e5bddda8409962369e5e1e4957547", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PS18441_PTH_thibaove.Models.Root> Html { get; private set; }
    }
}
#pragma warning restore 1591
