#pragma checksum "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/Room/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dff07580f3a84abe63151d54f40912e86460af73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_Index), @"mvc.1.0.view", @"/Views/Room/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Room/Index.cshtml", typeof(AspNetCore.Views_Room_Index))]
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
#line 1 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/_ViewImports.cshtml"
using ASPCoreSample;

#line default
#line hidden
#line 2 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/_ViewImports.cshtml"
using ASPCoreSample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff07580f3a84abe63151d54f40912e86460af73", @"/Views/Room/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f845085478c17c21ccf585a30cbb75e9ac1be715", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASPCoreSample.Models.RoomModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/Room/Index.cshtml"
  
    ViewData["Title"] = "Oda Listesi";

#line default
#line hidden
            BeginContext(101, 324, true);
            WriteLiteral(@"
<h2>Oda Listesi</h2>

<table class=""table"">
    <tr>
        <th>
            Oda İsmi
        </th>
        <th>
            Oda Sahibi
        </th>
        <th>
            Kat
        </th>
        <th>
            Blok
        </th>
        <th>
            Aktiflik
        </th>
    </tr>
    
");
            EndContext();
#line 28 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/Room/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(466, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(503, 43, false);
#line 32 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/Room/Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.roomname));

#line default
#line hidden
            EndContext();
            BeginContext(546, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(590, 39, false);
#line 35 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/Room/Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(629, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(673, 40, false);
#line 38 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/Room/Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.floor));

#line default
#line hidden
            EndContext();
            BeginContext(713, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(757, 40, false);
#line 41 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/Room/Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.block));

#line default
#line hidden
            EndContext();
            BeginContext(797, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(841, 43, false);
#line 44 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/Room/Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.isactive));

#line default
#line hidden
            EndContext();
            BeginContext(884, 17, true);
            WriteLiteral("\r\n        </td>\r\n");
            EndContext();
#line 46 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/Room/Index.cshtml"
         if (@ViewData["department"] != null && @ViewData["department"].Equals("Admin"))
        {

#line default
#line hidden
            BeginContext(1002, 23, true);
            WriteLiteral("            <th></th>\r\n");
            EndContext();
#line 49 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/Room/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1036, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 50 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/Room/Index.cshtml"
         if (@ViewData["department"] != null && @ViewData["department"].Equals("Admin"))
        {

#line default
#line hidden
            BeginContext(1137, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(1171, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2ecf5bacb88463fbd68fe8f31fb60ae", async() => {
                BeginContext(1216, 7, true);
                WriteLiteral("Düzenle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/Room/Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1227, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 55 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/Room/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1259, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 57 "/Users/cansinimac/Desktop/Final Version/Final_Version/ASPCoreSample/Views/Room/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1281, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASPCoreSample.Models.RoomModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
