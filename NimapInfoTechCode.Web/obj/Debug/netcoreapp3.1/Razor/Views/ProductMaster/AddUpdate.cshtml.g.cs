#pragma checksum "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "455ed9aae4a4f265c9a68aefbd3e7c52aa15010a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductMaster_AddUpdate), @"mvc.1.0.view", @"/Views/ProductMaster/AddUpdate.cshtml")]
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
#line 1 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\_ViewImports.cshtml"
using NimapInfoTechCode.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\_ViewImports.cshtml"
using NimapInfoTechCode.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\_ViewImports.cshtml"
using NimapInfoTechCode.Core.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\_ViewImports.cshtml"
using NimapInfoTechCode.Infrastructure.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\_ViewImports.cshtml"
using NimapInfoTechCode.Core.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"455ed9aae4a4f265c9a68aefbd3e7c52aa15010a", @"/Views/ProductMaster/AddUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f46ac69228689f9f9c02d35d39a2ac0bbe402fb0", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductMaster_AddUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductMasterDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
  
    ViewData["Title"] = "AddUpdate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
 if (Model != null && Model.product != null && Model.product.ID > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Edit</h2>\r\n");
#nullable restore
#line 10 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Add</h2>\r\n");
#nullable restore
#line 14 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<hr />\r\n\r\n");
#nullable restore
#line 19 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
 using (Html.BeginForm("AddUpdate", "ProductMaster", FormMethod.Post))
{
    if (ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>Danger!</strong> ");
#nullable restore
#line 24 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
                                Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>  Product Name : </label>\r\n");
#nullable restore
#line 29 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
Write(Html.TextBox("Name", Model == null ? string.Empty : Model.product == null ? "" : Model.product.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 31 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
Write(Html.DropDownList("CategoryId", new SelectList(Model.categories, "ID", "Name", Model == null ? 1 : Model.product == null ? 1 : Model.product.CategoryId)));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 33 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
Write(Html.Hidden("IsActive", Model == null ? true : Model.product == null ? true : Model.product.IsActive));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
                                                                                                          ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
Write(Html.Hidden("ID", Model == null ? 0 : Model.product == null ? 0 : Model.product.ID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
                                                                                        ;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 39 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
     if (Model != null && Model.product != null && Model.product.ID > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" name=\"Update\" value=\"Update\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 42 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" name=\"Add\" value=\"Add\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 46 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "455ed9aae4a4f265c9a68aefbd3e7c52aa15010a9607", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\globe365india\source\repos\NimapInfoTechCode\NimapInfoTechCode.Web\Views\ProductMaster\AddUpdate.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductMasterDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
