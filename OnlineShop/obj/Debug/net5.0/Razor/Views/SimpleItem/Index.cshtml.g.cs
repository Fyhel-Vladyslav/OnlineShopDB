#pragma checksum "D:\vodnik\2 курс\курсова\GitHub\OnlineShopDB\OnlineShop\Views\SimpleItem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1dcc813adf4e6be44ceb147fe91e704bd122df1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SimpleItem_Index), @"mvc.1.0.view", @"/Views/SimpleItem/Index.cshtml")]
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
#line 1 "D:\vodnik\2 курс\курсова\GitHub\OnlineShopDB\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\vodnik\2 курс\курсова\GitHub\OnlineShopDB\OnlineShop\Views\SimpleItem\Index.cshtml"
using OnlineShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1dcc813adf4e6be44ceb147fe91e704bd122df1", @"/Views/SimpleItem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d90dc07541a5c6d64c93e024fee34b85f8e0e69", @"/Views/_ViewImports.cshtml")]
    public class Views_SimpleItem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/boiler.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1dcc813adf4e6be44ceb147fe91e704bd122df13959", async() => {
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n        <div class=\"greating_line\">\r\n            <div class=\"item_image\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1dcc813adf4e6be44ceb147fe91e704bd122df14347", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
            <div class=""item_sInfo"">
                <div class=""title item_name"">Велика назва предметa</div>
                <div class=""title deskription"">Короткий опис</div>

                <div class=""icon_info"">
                    <div class=""stars"">
                        <div class=""rate_background"">
                            ★★★★★
                            <div class=""rate_bar"">★★★</div>
                        </div>
                    </div>
                    <div class=""isAvailable"">Є в наявності</div>


                    <div class=""price"">1234.56 грн</div>
                    <div");
                BeginWriteAttribute("style", " style=\"", 855, "\"", 863, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <label class=""checkbox"">
                            <input type=""checkbox"" class=""checkbox_input_heart"">
                            <span class=""check_box_heart""></span>
                        </label>
                        <label class=""checkbox"">
                            <input type=""checkbox"" class=""checkbox_input_cart"">
                            <span class=""check_box_cart""></span>
                        </label>
                    </div>

");
                WriteLiteral("                    <input type=\"button\" onclick=\"CreateMergeReport()\" value=\"Купити\" />\r\n                </div>\r\n                <div class=\"pay_info\">\r\n                    <h3>Опис</h3>");
#nullable restore
#line 42 "D:\vodnik\2 курс\курсова\GitHub\OnlineShopDB\OnlineShop\Views\SimpleItem\Index.cshtml"
                            Write(Model.longDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <div class=""pay_info"">
                    <h3>Гарантія</h3>
                    Готівкою, по безготівковому розрахунку для юр. осіб з ПДВ, терміналами
                    ПриватБанку, в кредит/розстрочку, за допомогою платіжних
                    систем Visa/Mastercard, Privat24, Liqpay, Portmone та іншими.
                    Обмін/повернення товару належної якості протягом 14 днів. Детальніше
                    Офіційна гарантія виробника: 12 міс. Детальніше
                </div>
            </div>
        </div>
        <div class=""title item_fInfo"">
            Характеристики {велика назва предмету}
        </div>





        <div class=""full_info"">
            <div class=""fInfo_line gray_line"">
                <div>Тип</div>
                <div>полароїд</div>
            </div>
            <div class=""fInfo_line"">
                <div>Гарантія\міс.</div>
                <div>12</div>
            </div>
            <div class=""fInf");
                WriteLiteral(@"o_line gray_line"">
                <div>Країна-виробник</div>
                <div>Китай</div>
            </div>
        </div>

        <div class=""review title"">Відгуки та питання  </div>
        <div class=""review"">
            <div class=""review_item"">
                <img class=""review_photo"" src=""/images/coment.png""");
                BeginWriteAttribute("alt", " alt=\"", 3129, "\"", 3135, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <div class=\"review_text\">топ дизайн.</div>\r\n                <div class=\"review_author\">Johan</div>\r\n            </div>\r\n            <div class=\"review_item\">\r\n                <img class=\"review_photo\" src=\"/images/coment.png\"");
                BeginWriteAttribute("alt", " alt=\"", 3380, "\"", 3386, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <div class=""review_text"">{хороший постачальник}.</div>
                <div class=""review_author"">Marin</div>
            </div>
        </div>
    </div>


    <script type=""text/jscript"">
        function CreateMergeReport() {
            $.get(""/Cart/AddToCart/");
#nullable restore
#line 95 "D:\vodnik\2 курс\курсова\GitHub\OnlineShopDB\OnlineShop\Views\SimpleItem\Index.cshtml"
                              Write(Model.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n        };\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
