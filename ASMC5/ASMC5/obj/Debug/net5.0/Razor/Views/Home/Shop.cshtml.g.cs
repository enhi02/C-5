#pragma checksum "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\Home\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe543cbe026a5020e4720c2f4e064d2b3b070db1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Shop), @"mvc.1.0.view", @"/Views/Home/Shop.cshtml")]
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
#line 2 "D:\Skyfolder\Desktop\c5\ASMC5\ASMC5\Views\_ViewImports.cshtml"
using WebMonAn.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe543cbe026a5020e4720c2f4e064d2b3b070db1", @"/Views/Home/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef9abffc3b1a959530ba4a46c7f60295039b7722", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FoodModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark btn btn-sm text-dark p-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-fluid bg-secondary mb-5"">
        <div class=""d-flex flex-column align-items-center justify-content-center"" style=""min-height: 300px"">
            <h1 class=""font-weight-semi-bold text-uppercase mb-3"">Our Shop</h1>
            <div class=""d-inline-flex"">
                <p class=""m-0""><a");
            BeginWriteAttribute("href", " href=\"", 340, "\"", 347, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe543cbe026a5020e4720c2f4e064d2b3b070db16034", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
                <p class=""m-0 px-2"">-</p>
                <p class=""m-0"">Shop</p>
            </div>
        </div>
    </div>
    <!-- Page Header End -->


    <!-- Shop Start -->
    <div class=""container-fluid pt-5"">
        <div class=""row px-xl-5"">
            <!-- Shop Sidebar Start -->
            <div class=""col-lg-3 col-md-12"">
                <!-- Price Start -->
                <div class=""border-bottom mb-4 pb-4"">
                    <h5 class=""font-weight-semi-bold mb-4"">Filter by price</h5>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe543cbe026a5020e4720c2f4e064d2b3b070db18240", async() => {
                WriteLiteral(@"
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" checked id=""price-all"">
                            <label class=""custom-control-label"" for=""price-all"">All Price</label>
                            <span class=""badge border font-weight-normal"">1000</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""price-1"">
                            <label class=""custom-control-label"" for=""price-1"">$0 - $100</label>
                            <span class=""badge border font-weight-normal"">150</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
              ");
                WriteLiteral(@"              <input type=""checkbox"" class=""custom-control-input"" id=""price-2"">
                            <label class=""custom-control-label"" for=""price-2"">$100 - $200</label>
                            <span class=""badge border font-weight-normal"">295</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""price-3"">
                            <label class=""custom-control-label"" for=""price-3"">$200 - $300</label>
                            <span class=""badge border font-weight-normal"">246</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""price-4"">
                            <label class=""custom-control-label"" for=""");
                WriteLiteral(@"price-4"">$300 - $400</label>
                            <span class=""badge border font-weight-normal"">145</span>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""price-5"">
                            <label class=""custom-control-label"" for=""price-5"">$400 - $500</label>
                            <span class=""badge border font-weight-normal"">168</span>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <!-- Price End -->
                
                
            </div>
            <!-- Shop Sidebar End -->


            <!-- Shop Product Start -->
            <div class=""col-lg-9 col-md-12"">
                <div class=""row pb-3"">
                    <div class=""col-12 pb-1"">
                        <div class=""d-flex align-items-center justify-content-between mb-4"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe543cbe026a5020e4720c2f4e064d2b3b070db112734", async() => {
                WriteLiteral(@"
                                <div class=""input-group"">
                                    <input type=""text"" class=""form-control"" placeholder=""Search by name"">
                                    <div class=""input-group-append"">
                                        <span class=""input-group-text bg-transparent text-primary"">
                                            <i class=""fa fa-search""></i>
                                        </span>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""dropdown ml-4"">
                                <button class=""btn border dropdown-toggle"" type=""button"" id=""triggerId"" data-toggle=""dropdown"" aria-haspopup=""true""
                                        aria-expanded=""false"">
                                            Sort by
                                        </button>
                                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""triggerId"">
                                    <a class=""dropdown-item"" href=""#"">Latest</a>
                                    <a class=""dropdown-item"" href=""#"">Popularity</a>
                                    <a class=""dropdown-item"" href=""#"">Best Rating</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 col-sm-12 pb-1"">
                        <div class=""card product-item border-0 mb-4"">
         ");
            WriteLiteral("                   <div class=\"card-header product-img position-relative overflow-hidden bg-transparent border p-0\">\r\n                                <img class=\"img-fluid w-100\" src=\"img/product-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 5936, "\"", 5942, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""card-body border-left border-right text-center p-0 pt-4 pb-3"">
                                <h6 class=""text-truncate mb-3"">Colorful Stylish Shirt</h6>
                                <div class=""d-flex justify-content-center"">
                                    <h6>$123.00</h6><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                                </div>
                            </div>
                            <div class=""card-footer d-flex justify-content-between bg-light border"">
");
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe543cbe026a5020e4720c2f4e064d2b3b070db116737", async() => {
                WriteLiteral("<i class=\"fas fa-eye text-primary mr-1\"></i>View Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 6916, "\"", 6923, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm text-dark p-0""><i class=""fas fa-shopping-cart text-primary mr-1""></i>Add To Cart</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 col-sm-12 pb-1"">
                        <div class=""card product-item border-0 mb-4"">
                            <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                                <img class=""img-fluid w-100"" src=""img/product-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7475, "\"", 7481, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""card-body border-left border-right text-center p-0 pt-4 pb-3"">
                                <h6 class=""text-truncate mb-3"">Colorful Stylish Shirt</h6>
                                <div class=""d-flex justify-content-center"">
                                    <h6>$123.00</h6><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                                </div>
                            </div>
                            <div class=""card-footer d-flex justify-content-between bg-light border"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 8111, "\"", 8118, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm text-dark p-0\"><i class=\"fas fa-eye text-primary mr-1\"></i>View Detail</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 8248, "\"", 8255, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm text-dark p-0""><i class=""fas fa-shopping-cart text-primary mr-1""></i>Add To Cart</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 col-sm-12 pb-1"">
                        <div class=""card product-item border-0 mb-4"">
                            <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                                <img class=""img-fluid w-100"" src=""img/product-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8807, "\"", 8813, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""card-body border-left border-right text-center p-0 pt-4 pb-3"">
                                <h6 class=""text-truncate mb-3"">Colorful Stylish Shirt</h6>
                                <div class=""d-flex justify-content-center"">
                                    <h6>$123.00</h6><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                                </div>
                            </div>
                            <div class=""card-footer d-flex justify-content-between bg-light border"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 9443, "\"", 9450, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm text-dark p-0\"><i class=\"fas fa-eye text-primary mr-1\"></i>View Detail</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 9580, "\"", 9587, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm text-dark p-0""><i class=""fas fa-shopping-cart text-primary mr-1""></i>Add To Cart</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 col-sm-12 pb-1"">
                        <div class=""card product-item border-0 mb-4"">
                            <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                                <img class=""img-fluid w-100"" src=""img/product-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10139, "\"", 10145, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""card-body border-left border-right text-center p-0 pt-4 pb-3"">
                                <h6 class=""text-truncate mb-3"">Colorful Stylish Shirt</h6>
                                <div class=""d-flex justify-content-center"">
                                    <h6>$123.00</h6><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                                </div>
                            </div>
                            <div class=""card-footer d-flex justify-content-between bg-light border"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 10775, "\"", 10782, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm text-dark p-0\"><i class=\"fas fa-eye text-primary mr-1\"></i>View Detail</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 10912, "\"", 10919, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm text-dark p-0""><i class=""fas fa-shopping-cart text-primary mr-1""></i>Add To Cart</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 col-sm-12 pb-1"">
                        <div class=""card product-item border-0 mb-4"">
                            <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                                <img class=""img-fluid w-100"" src=""img/product-5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11471, "\"", 11477, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""card-body border-left border-right text-center p-0 pt-4 pb-3"">
                                <h6 class=""text-truncate mb-3"">Colorful Stylish Shirt</h6>
                                <div class=""d-flex justify-content-center"">
                                    <h6>$123.00</h6><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                                </div>
                            </div>
                            <div class=""card-footer d-flex justify-content-between bg-light border"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 12107, "\"", 12114, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm text-dark p-0\"><i class=\"fas fa-eye text-primary mr-1\"></i>View Detail</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 12244, "\"", 12251, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm text-dark p-0""><i class=""fas fa-shopping-cart text-primary mr-1""></i>Add To Cart</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 col-sm-12 pb-1"">
                        <div class=""card product-item border-0 mb-4"">
                            <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                                <img class=""img-fluid w-100"" src=""img/product-6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12803, "\"", 12809, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""card-body border-left border-right text-center p-0 pt-4 pb-3"">
                                <h6 class=""text-truncate mb-3"">Colorful Stylish Shirt</h6>
                                <div class=""d-flex justify-content-center"">
                                    <h6>$123.00</h6><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                                </div>
                            </div>
                            <div class=""card-footer d-flex justify-content-between bg-light border"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 13439, "\"", 13446, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm text-dark p-0\"><i class=\"fas fa-eye text-primary mr-1\"></i>View Detail</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 13576, "\"", 13583, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm text-dark p-0""><i class=""fas fa-shopping-cart text-primary mr-1""></i>Add To Cart</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 col-sm-12 pb-1"">
                        <div class=""card product-item border-0 mb-4"">
                            <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                                <img class=""img-fluid w-100"" src=""img/product-7.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14135, "\"", 14141, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""card-body border-left border-right text-center p-0 pt-4 pb-3"">
                                <h6 class=""text-truncate mb-3"">Colorful Stylish Shirt</h6>
                                <div class=""d-flex justify-content-center"">
                                    <h6>$123.00</h6><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                                </div>
                            </div>
                            <div class=""card-footer d-flex justify-content-between bg-light border"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 14771, "\"", 14778, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm text-dark p-0\"><i class=\"fas fa-eye text-primary mr-1\"></i>View Detail</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 14908, "\"", 14915, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm text-dark p-0""><i class=""fas fa-shopping-cart text-primary mr-1""></i>Add To Cart</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 col-sm-12 pb-1"">
                        <div class=""card product-item border-0 mb-4"">
                            <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                                <img class=""img-fluid w-100"" src=""img/product-8.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15467, "\"", 15473, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""card-body border-left border-right text-center p-0 pt-4 pb-3"">
                                <h6 class=""text-truncate mb-3"">Colorful Stylish Shirt</h6>
                                <div class=""d-flex justify-content-center"">
                                    <h6>$123.00</h6><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                                </div>
                            </div>
                            <div class=""card-footer d-flex justify-content-between bg-light border"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 16103, "\"", 16110, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm text-dark p-0\"><i class=\"fas fa-eye text-primary mr-1\"></i>View Detail</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 16240, "\"", 16247, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm text-dark p-0""><i class=""fas fa-shopping-cart text-primary mr-1""></i>Add To Cart</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 col-sm-12 pb-1"">
                        <div class=""card product-item border-0 mb-4"">
                            <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                                <img class=""img-fluid w-100"" src=""img/product-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 16799, "\"", 16805, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""card-body border-left border-right text-center p-0 pt-4 pb-3"">
                                <h6 class=""text-truncate mb-3"">Colorful Stylish Shirt</h6>
                                <div class=""d-flex justify-content-center"">
                                    <h6>$123.00</h6><h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                                </div>
                            </div>
                            <div class=""card-footer d-flex justify-content-between bg-light border"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 17435, "\"", 17442, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm text-dark p-0\"><i class=\"fas fa-eye text-primary mr-1\"></i>View Detail</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 17572, "\"", 17579, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm text-dark p-0""><i class=""fas fa-shopping-cart text-primary mr-1""></i>Add To Cart</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-12 pb-1"">
                        <nav aria-label=""Page navigation"">
                          <ul class=""pagination justify-content-center mb-3"">
                            <li class=""page-item disabled"">
                              <a class=""page-link"" href=""#"" aria-label=""Previous"">
                                <span aria-hidden=""true"">&laquo;</span>
                                <span class=""sr-only"">Previous</span>
                              </a>
                            </li>
                            <li class=""page-item active""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a><");
            WriteLiteral(@"/li>
                            <li class=""page-item"">
                              <a class=""page-link"" href=""#"" aria-label=""Next"">
                                <span aria-hidden=""true"">&raquo;</span>
                                <span class=""sr-only"">Next</span>
                              </a>
                            </li>
                          </ul>
                        </nav>
                    </div>
                </div>
            </div>
            <!-- Shop Product End -->
        </div>
    </div>
    <!-- Shop End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FoodModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
