#pragma checksum "C:\Dokumenty\CSHARP\ASPNetCore\SingletonAspNet\SingletonAspNet\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "069e4ae564f9b45b603b474cc79a939bb2264bc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"069e4ae564f9b45b603b474cc79a939bb2264bc8", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(7, 14, false);
#line 2 "C:\Dokumenty\CSHARP\ASPNetCore\SingletonAspNet\SingletonAspNet\Views\Home\Index.cshtml"
Write(ViewBag.Number);

#line default
#line hidden
            EndContext();
            BeginContext(21, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 3 "C:\Dokumenty\CSHARP\ASPNetCore\SingletonAspNet\SingletonAspNet\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(58, 61, true);
            WriteLiteral("\t<input type=\"submit\" name=\"response\" value=\"Increase Number\"");
            EndContext();
            BeginWriteAttribute("formaction", " formaction=", 119, "", 153, 1);
#line 5 "C:\Dokumenty\CSHARP\ASPNetCore\SingletonAspNet\SingletonAspNet\Views\Home\Index.cshtml"
WriteAttributeValue("", 131, Url.Action("Default"), 131, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(153, 46, true);
            WriteLiteral(" formmethod=\"post\" class=\"btn btn-primary\"/>\r\n");
            EndContext();
#line 6 "C:\Dokumenty\CSHARP\ASPNetCore\SingletonAspNet\SingletonAspNet\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
