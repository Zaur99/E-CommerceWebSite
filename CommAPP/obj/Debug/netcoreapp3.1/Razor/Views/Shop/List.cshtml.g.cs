#pragma checksum "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17667bbfa0e9b26fb51012683fd71841a4e0dd86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_List), @"mvc.1.0.view", @"/Views/Shop/List.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\_ViewImports.cshtml"
using CommAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\_ViewImports.cshtml"
using CommAPP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\_ViewImports.cshtml"
using CommAPP.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\_ViewImports.cshtml"
using CommAPP.Models.ViewModels.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\_ViewImports.cshtml"
using Comm.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\_ViewImports.cshtml"
using Comm.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\_ViewImports.cshtml"
using CommAPP.Models.ViewModels.OrderRelated;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\_ViewImports.cshtml"
using CommAPP.Models.ViewModels.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17667bbfa0e9b26fb51012683fd71841a4e0dd86", @"/Views/Shop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f223fd6d2d0ecc38cce307fa10b0a098f96bbb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml"
   Write(await Component.InvokeAsync("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"d-flex\">\r\n");
#nullable restore
#line 13 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml"
             foreach (var item in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card"" style=""width: 18rem;"">
                    <img class=""card-img-top"" src=""..."" alt=""Card image cap"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">
                            ");
#nullable restore
#line 19 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 21 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml"
                                        Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml"
                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17667bbfa0e9b26fb51012683fd71841a4e0dd868263", async() => {
                WriteLiteral("Go somewhere");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productname", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml"
                                                                                 WriteLiteral(item.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productname"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productname", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productname"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 26 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n<section class=\"populerproduct\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                ");
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml"
           Write(await Component.InvokeAsync("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 42 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml"
             foreach (var item in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 col-sm-6\">\r\n                    <div class=\"product-item\">\r\n                        <div class=\"product-item-image\">\r\n                            <a href=\"product-details.html\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "17667bbfa0e9b26fb51012683fd71841a4e0dd8612098", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1553, "~/img/", 1553, 6, true);
#nullable restore
#line 48 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml"
AddHtmlAttributeValue("", 1559, item.ImageUrl, 1559, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                            <div class=""cart-icon"">
                                <a href=""#""><i class=""far fa-heart""></i></a>
                                <a href=""#"">
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16.75"" height=""16.75""
                                         viewBox=""0 0 16.75 16.75"">
                                        <g id=""Your_Bag"" data-name=""Your Bag"" transform=""translate(0.75)"">
                                            <g id=""Icon"" transform=""translate(0 1)"">
                                                <ellipse id=""Ellipse_2"" data-name=""Ellipse 2"" cx=""0.682"" cy=""0.714""
                                                         rx=""0.682"" ry=""0.714"" transform=""translate(4.773 13.571)""
                                                         fill=""none"" stroke=""#1a2224"" stroke-linecap=""round""
                                                         stroke-linejoin=""round"" stroke-width=""1.5""");
            WriteLiteral(@" />
                                                <ellipse id=""Ellipse_3"" data-name=""Ellipse 3"" cx=""0.682"" cy=""0.714""
                                                         rx=""0.682"" ry=""0.714"" transform=""translate(12.273 13.571)""
                                                         fill=""none"" stroke=""#1a2224"" stroke-linecap=""round""
                                                         stroke-linejoin=""round"" stroke-width=""1.5"" />
                                                <path id=""Path_3"" data-name=""Path 3""
                                                      d=""M1,1H3.727l1.827,9.564a1.38,1.38,0,0,0,1.364,1.15h6.627a1.38,1.38,0,0,0,1.364-1.15L16,4.571H4.409""
                                                      transform=""translate(-1 -1)"" fill=""none"" stroke=""#1a2224""
                                                      stroke-linecap=""round"" stroke-linejoin=""round""
                                                      stroke-width=""1.5"" />
                                    ");
            WriteLiteral(@"        </g>
                                        </g>
                                    </svg>
                                </a>
                            </div>
                        </div>
                        <div class=""product-item-info"">
                            <a href=""product-details.html"">");
#nullable restore
#line 78 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <span>");
#nullable restore
#line 79 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml"
                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 83 "C:\Users\ASUS\source\repos\E-CommerceWebSite\CommAPP\Views\Shop\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
