#pragma checksum "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b6eb2104eec44c7670a70e8cc168256eeb98349"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GourmetPizzaPrac3.Pages.Purchases.Pages_Purchases_Create), @"mvc.1.0.razor-page", @"/Pages/Purchases/Create.cshtml")]
namespace GourmetPizzaPrac3.Pages.Purchases
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
#line 1 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/_ViewImports.cshtml"
using GourmetPizzaPrac3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/_ViewImports.cshtml"
using GourmetPizzaPrac3.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b6eb2104eec44c7670a70e8cc168256eeb98349", @"/Pages/Purchases/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d642aa168989a57144fcba325f9b1d6674eca3d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Purchases_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Purchases Pizza</h1>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b6eb2104eec44c7670a70e8cc168256eeb983496097", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b6eb2104eec44c7670a70e8cc168256eeb983496365", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b6eb2104eec44c7670a70e8cc168256eeb983498130", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 15 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Purchases.pizzaID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b6eb2104eec44c7670a70e8cc168256eeb983499775", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 16 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Purchases.pizzaID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 16 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.TitleList;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b6eb2104eec44c7670a70e8cc168256eeb9834912011", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 19 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Purchases.PizzaCount);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4b6eb2104eec44c7670a70e8cc168256eeb9834913660", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 20 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Purchases.PizzaCount);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b6eb2104eec44c7670a70e8cc168256eeb9834915303", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 21 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Purchases.PizzaCount);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Order Pizza\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<hr />\r\n");
#nullable restore
#line 31 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
 if (ViewData["TotalPrice"] != null)
{
    if (Model.Purchases.pizzaID == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Purchase Confirmation:</h2>\r\n        <h4>\r\n            Your have purchased <b>");
#nullable restore
#line 37 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
                              Write(Model.Purchases.PizzaCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            pizzas of <b>Beef Pizza</b>\r\n        </h4>\r\n        <h4>\r\n            The Total Price is: <b>");
#nullable restore
#line 41 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
                              Write(ViewData["TotalPrice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</b>\r\n        </h4>\r\n");
#nullable restore
#line 43 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
    }

    if (Model.Purchases.pizzaID == 2)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Purchase Confirmation:</h2>\r\n        <h4>\r\n            Your have purchased <b>");
#nullable restore
#line 49 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
                              Write(Model.Purchases.PizzaCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            pizzas of <b>Chicken Pineapple Pizza</b>\r\n        </h4>\r\n        <h4>\r\n            The Total Price is: <b>");
#nullable restore
#line 53 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
                              Write(ViewData["TotalPrice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</b>\r\n        </h4>\r\n");
#nullable restore
#line 55 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
    }

    if (Model.Purchases.pizzaID == 3)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Purchase Confirmation:</h2>\r\n        <h4>\r\n            Your have purchased <b>");
#nullable restore
#line 61 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
                              Write(Model.Purchases.PizzaCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            pizzas of <b>Pepperoni Pizza</b>\r\n        </h4>\r\n        <h4>\r\n            The Total Price is: <b>");
#nullable restore
#line 65 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
                              Write(ViewData["TotalPrice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</b>\r\n        </h4>\r\n");
#nullable restore
#line 67 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
    }

    if (Model.Purchases.pizzaID == 4)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Purchase Confirmation:</h2>\r\n        <h4>\r\n            Your have purchased <b>");
#nullable restore
#line 73 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
                              Write(Model.Purchases.PizzaCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            pizzas of <b>Vegetarian Pizza</b>\r\n        </h4>\r\n        <h4>\r\n            The Total Price is: <b>");
#nullable restore
#line 77 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
                              Write(ViewData["TotalPrice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</b>\r\n        </h4>\r\n");
#nullable restore
#line 79 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
    }

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 85 "/Users/luongnguyendinh1999gmail.com/Desktop/GourmetPizzaPrac3/GourmetPizzaPrac3LastestVersion/GourmetPizzaPrac3/Pages/Purchases/Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GourmetPizzaPrac3.Pages.Purchases.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GourmetPizzaPrac3.Pages.Purchases.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GourmetPizzaPrac3.Pages.Purchases.CreateModel>)PageContext?.ViewData;
        public GourmetPizzaPrac3.Pages.Purchases.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
