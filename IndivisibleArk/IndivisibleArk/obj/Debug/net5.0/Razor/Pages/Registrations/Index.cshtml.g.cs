#pragma checksum "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1af31cf5ebcbb0b449bfe6556e092b9aff6ae6bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(IndivisibleArk.Pages.Registrations.Pages_Registrations_Index), @"mvc.1.0.razor-page", @"/Pages/Registrations/Index.cshtml")]
namespace IndivisibleArk.Pages.Registrations
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
#line 1 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\_ViewImports.cshtml"
using IndivisibleArk;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af31cf5ebcbb0b449bfe6556e092b9aff6ae6bd", @"/Pages/Registrations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2615fd6b3ac41e2f643f482e4bdcb0b6a557f383", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Registrations_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1af31cf5ebcbb0b449bfe6556e092b9aff6ae6bd4593", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].F_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].M_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].L_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].M_address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].Apt_lot_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].County));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].P_aff));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].Precinct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].Registration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 68 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contact[0].Interest));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 74 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
 foreach (var item in Model.Contact) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.F_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.M_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.L_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.M_address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 95 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apt_lot_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 98 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 101 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.County));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 104 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 107 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 110 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.P_aff));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 113 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Precinct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 116 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 119 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 122 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Registration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 125 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Location.LocationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 128 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Interest.InterestId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1af31cf5ebcbb0b449bfe6556e092b9aff6ae6bd19886", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 131 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
                                       WriteLiteral(item.ContactId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1af31cf5ebcbb0b449bfe6556e092b9aff6ae6bd22115", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 132 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
                                          WriteLiteral(item.ContactId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1af31cf5ebcbb0b449bfe6556e092b9aff6ae6bd24350", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 133 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
                                         WriteLiteral(item.ContactId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 136 "C:\Users\maxgi\OneDrive\Documents\csci340\Indivisible-Arkansas-Statistics\IndivisibleArk\IndivisibleArk\Pages\Registrations\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndivisibleArk.Pages.Registrations.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndivisibleArk.Pages.Registrations.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndivisibleArk.Pages.Registrations.IndexModel>)PageContext?.ViewData;
        public IndivisibleArk.Pages.Registrations.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
