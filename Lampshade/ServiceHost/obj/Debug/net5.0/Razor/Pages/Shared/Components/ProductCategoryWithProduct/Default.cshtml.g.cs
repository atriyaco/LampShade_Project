#pragma checksum "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93e4acd9e8c4e6435bcee21ffd5c7ab8deb77583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.ProductCategoryWithProduct.Pages_Shared_Components_ProductCategoryWithProduct_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/ProductCategoryWithProduct/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.ProductCategoryWithProduct
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
#line 1 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93e4acd9e8c4e6435bcee21ffd5c7ab8deb77583", @"/Pages/Shared/Components/ProductCategoryWithProduct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_ProductCategoryWithProduct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_LampshadeQuery.Contracts.ProductCategory.ProductCategoryQueryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""single-row-slider-tab-area section-space"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title-wrapper text-center section-space--half"">
                    <h2 class=""section-title"">محصولات ما</h2>
                    <p class=""section-subtitle"">
                        لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است
                    </p>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""tab-slider-wrapper"">
                    <div class=""tab-product-navigation"">
                        <div class=""nav nav-tabs justify-content-center"" id=""nav-tab2"" role=""tablist"">
");
#nullable restore
#line 20 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                             foreach (var category in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("class", " class=\"", 1107, "\"", 1177, 3);
            WriteAttributeValue("", 1115, "nav-item", 1115, 8, true);
            WriteAttributeValue(" ", 1123, "nav-link", 1124, 9, true);
#nullable restore
#line 22 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue(" ", 1132, Model.First() == category ? "active" : "", 1133, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1178, "\"", 1207, 2);
            WriteAttributeValue("", 1183, "product-tab-", 1183, 12, true);
#nullable restore
#line 22 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 1195, category.Id, 1195, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\"");
            BeginWriteAttribute("href", "\r\n                                   href=\"", 1226, "\"", 1297, 2);
            WriteAttributeValue("", 1269, "#product-series-", 1269, 16, true);
#nullable restore
#line 23 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 1285, category.Id, 1285, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\" aria-selected=\"true\">");
#nullable restore
#line 23 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                                  Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 24 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"tab-content\">\r\n");
#nullable restore
#line 28 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                         foreach (var category in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 1606, "\"", 1677, 4);
            WriteAttributeValue("", 1614, "tab-pane", 1614, 8, true);
            WriteAttributeValue(" ", 1622, "fade", 1623, 5, true);
            WriteAttributeValue(" ", 1627, "show", 1628, 5, true);
#nullable restore
#line 30 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue(" ", 1632, Model.First() == category ? "active" : "", 1633, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1678, "\"", 1710, 2);
            WriteAttributeValue("", 1683, "product-series-", 1683, 15, true);
#nullable restore
#line 30 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 1698, category.Id, 1698, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""tabpanel""
                                 aria-labelledby=""product-tab-1"">
                                <div class=""single-row-slider-wrapper"">
                                    <div class=""ht-slick-slider"" data-slick-setting='{
                                ""slidesToShow"": 4,
                                ""slidesToScroll"": 1,
                                ""arrows"": true,
                                ""autoplay"": false,
                                ""autoplaySpeed"": 5000,
                                ""speed"": 1000,
                                ""infinite"": true,
                                ""rtl"": true,
                                ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                                ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                            }' data-slick-responsive='[
                                {""breakpoint"":1501, ""settings"": {""slidesToShow"": 4} },
   ");
            WriteLiteral(@"                             {""breakpoint"":1199, ""settings"": {""slidesToShow"": 4, ""arrows"": false} },
                                {""breakpoint"":991, ""settings"": {""slidesToShow"": 3, ""arrows"": false} },
                                {""breakpoint"":767, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                                {""breakpoint"":575, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                                {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                            ]'>
");
#nullable restore
#line 52 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                         foreach (var product in category.Products)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"col\">\r\n                                                <div class=\"single-grid-product\">\r\n                                                    <div class=\"single-grid-product__image\">\r\n");
#nullable restore
#line 57 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                         if (product.HasDiscount)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"single-grid-product__label\">\r\n                                                                <span class=\"sale\">-");
#nullable restore
#line 60 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                               Write(product.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                                            </div>\r\n");
#nullable restore
#line 62 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a href=\"single-product.html\">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93e4acd9e8c4e6435bcee21ffd5c7ab8deb7758312958", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4297, "~/ProductPictures/", 4297, 18, true);
#nullable restore
#line 64 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 4315, product.Picture, 4315, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 64 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 4340, product.PictureTitle, 4340, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 65 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 4452, product.PictureAlt, 4452, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </a>
                                                    </div>
                                                    <div class=""single-grid-product__content"">
                                                        <div class=""single-grid-product__category-rating"">
                                                            <span class=""category"">
                                                                <a href=""shop-left-sidebar.html"">");
#nullable restore
#line 71 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                            Write(product.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                            </span>
                                                            <span class=""rating"">
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star-outline""></i>
                                                            </span>
                                                        </div>

                                                        <h3 class=""single-grid-product__title"">
                                                            <a href=""single-product.html"">
                ");
            WriteLiteral("                                                ");
#nullable restore
#line 84 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                           Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </a>\r\n                                                        </h3>\r\n                                                        <p class=\"single-grid-product__price\">\r\n");
#nullable restore
#line 88 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                             if (product.HasDiscount)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"discounted-price\">");
#nullable restore
#line 90 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                          Write(product.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                                                                <span class=\"main-price discounted\">");
#nullable restore
#line 91 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 92 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"main-price\">");
#nullable restore
#line 95 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                    Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 96 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </p>\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 101 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 105 "C:\Hossein\Packages\.NetCoreMvcApi\examples\MVC_Final_Project\Code\Lampshade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_LampshadeQuery.Contracts.ProductCategory.ProductCategoryQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
