#pragma checksum "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f148c1bdf6898141b8b2c109444a1062c10e9987"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(IndivisibleArk.Pages.Contacts.Pages_Contacts_Delete), @"mvc.1.0.razor-page", @"/Pages/Contacts/Delete.cshtml")]
namespace IndivisibleArk.Pages.Contacts
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
#line 1 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/_ViewImports.cshtml"
using IndivisibleArk;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f148c1bdf6898141b8b2c109444a1062c10e9987", @"/Pages/Contacts/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8a1b1cd0a866241704cfeccd646d0660175652b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contacts_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Contact</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.F_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.F_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.M_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.M_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.L_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.L_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.M_address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.M_address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Apt_lot_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Apt_lot_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.County));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.County));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.P_aff));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.P_aff));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Precinct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Precinct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 100 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 106 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Registration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 109 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Registration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 112 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 115 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Location.LocationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 118 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Interest));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 121 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Interest.InterestId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f148c1bdf6898141b8b2c109444a1062c10e998717964", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f148c1bdf6898141b8b2c109444a1062c10e998718229", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 126 "/Users/joshthomeczek/GithubStuff/DBWS/Indivisible-Arkansas-Statistics/IndivisibleArk/IndivisibleArk/Pages/Contacts/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Contact.ContactId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f148c1bdf6898141b8b2c109444a1062c10e998720058", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndivisibleArk.Pages.Contacts.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndivisibleArk.Pages.Contacts.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndivisibleArk.Pages.Contacts.DeleteModel>)PageContext?.ViewData;
        public IndivisibleArk.Pages.Contacts.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
