#pragma checksum "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71fd3d19b107841e3916830cc656dd28cc11cd5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PagingXTL), @"mvc.1.0.view", @"/Views/Shared/_PagingXTL.cshtml")]
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
#line 1 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\_ViewImports.cshtml"
using WebMonAn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
using WebMonAn.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71fd3d19b107841e3916830cc656dd28cc11cd5b", @"/Views/Shared/_PagingXTL.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef9abffc3b1a959530ba4a46c7f60295039b7722", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PagingXTL : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebMonAn.Models.PagingModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
  
    int currentPage  = Model.currentpage;
    int countPages   = Model.countpages;
    var generateUrl  = Model.generateUrl;


    
    if (currentPage > countPages) 
      currentPage = countPages;

    if (countPages <= 1) return;
    

    int? preview = null;
    int? next = null;

    if (currentPage > 1)
        preview = currentPage - 1;

    if (currentPage < countPages)
        next = currentPage + 1;

    // C??c trang hi???n th??? trong ??i???u h?????ng
    List<int> pagesRanges = new List<int>();    

        
    int delta      = 5;             // S??? trang m??? r???ng v??? m???i b??n trang hi???n t???i     
    int remain     = delta * 2;     // S??? trang hai b??n trang hi???n t???i

    pagesRanges.Add(currentPage);
    // C??c trang ph??t tri???n v??? hai b??n trang hi???n t???i
    for (int i = 1; i <= delta; i++)
    {
        if (currentPage + i  <= countPages) {
            pagesRanges.Add(currentPage + i); 
            remain --;
        }
               
        if (currentPage - i >= 1) {
            pagesRanges.Insert(0, currentPage - i);
            remain --;
        }
            
    }    
    // X??? l?? th??m v??o c??c trang cho ????? remain 
    //(x???y ra ??? ?????u m??t c???a kho???ng trang kh??ng ????? trang ch??n  v??o)
    if (remain > 0) {
        if (pagesRanges[0] == 1) {
            for (int i = 1; i <= remain; i++)
            {
                if (pagesRanges.Last() + 1 <= countPages) {
                    pagesRanges.Add(pagesRanges.Last() + 1);
                }
            }
        }
        else {
            for (int i = 1; i <= remain; i++)
            {
                if (pagesRanges.First() - 1 > 1) {
                    pagesRanges.Insert(0, pagesRanges.First() - 1);
                }
            }
        }
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<ul class=\"pagination\">\r\n    <!-- Previous page link -->\r\n");
#nullable restore
#line 82 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
     if (preview != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2244, "\"", 2272, 1);
#nullable restore
#line 85 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
WriteAttributeValue("", 2251, generateUrl(preview), 2251, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trang tr?????c</a>\r\n        </li>\r\n");
#nullable restore
#line 87 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item disabled\">\r\n            <a class=\"page-link\" href=\"#\" tabindex=\"-1\" aria-disabled=\"true\">Trang tr?????c</a>\r\n        </li>\r\n");
#nullable restore
#line 93 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("      \r\n    <!-- Numbered page links -->\r\n");
#nullable restore
#line 96 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
     foreach (var pageitem in pagesRanges)
    {
        if (pageitem != currentPage) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2692, "\"", 2721, 1);
#nullable restore
#line 100 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
WriteAttributeValue("", 2699, generateUrl(pageitem), 2699, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 101 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
               Write(pageitem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 104 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
        }   
        else 
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item active\" aria-current=\"page\">\r\n                <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 108 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
                                         Write(pageitem);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n            </li>\r\n");
#nullable restore
#line 110 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <!-- Next page link -->\r\n");
#nullable restore
#line 115 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
     if (next != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3165, "\"", 3190, 1);
#nullable restore
#line 118 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
WriteAttributeValue("", 3172, generateUrl(next), 3172, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trang sau</a>\r\n        </li>\r\n");
#nullable restore
#line 120 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
    }
    else 
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item disabled\">\r\n            <a class=\"page-link\" href=\"#\" tabindex=\"-1\" aria-disabled=\"true\">Trang sau</a>\r\n        </li>\r\n");
#nullable restore
#line 126 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Shared\_PagingXTL.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebMonAn.Models.PagingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
