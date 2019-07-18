#pragma checksum "C:\Dokumenty\GIT\Projects\C#\ASP.NET Core\ProductsManager\ProductsManager\Views\Home\ShowOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7da7d77599ad6441656213d9c31481087c0bec6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowOrders), @"mvc.1.0.view", @"/Views/Home/ShowOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowOrders.cshtml", typeof(AspNetCore.Views_Home_ShowOrders))]
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
#line 1 "C:\Dokumenty\GIT\Projects\C#\ASP.NET Core\ProductsManager\ProductsManager\Views\Home\ShowOrders.cshtml"
using ProductsManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da7d77599ad6441656213d9c31481087c0bec6c", @"/Views/Home/ShowOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Dokumenty\GIT\Projects\C#\ASP.NET Core\ProductsManager\ProductsManager\Views\Home\ShowOrders.cshtml"
  
	ViewBag.Title = "orders ";
	Layout = "_Layout";
	List<Order> Orders = ViewBag.Orders;

#line default
#line hidden
            BeginContext(132, 17, true);
            WriteLiteral("<h1>Orders</h1>\r\n");
            EndContext();
            BeginContext(149, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f295cefd25544f18944fad7db2f1f9d1", async() => {
                BeginContext(200, 5, true);
                WriteLiteral("Click");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(209, 260, true);
            WriteLiteral(@"
<table class=""table table-striped table-sm"">
	<thead>
		<tr>

			<th scope=""col""> <b>ProductID</b></th>
			<th scope=""col""> <b>Quantity </b></th>
			<th scope=""col""> <b>Total price</b></th>
			<th scope=""col""><b>Remove</b></th>

		</tr>
	</thead>
");
            EndContext();
#line 22 "C:\Dokumenty\GIT\Projects\C#\ASP.NET Core\ProductsManager\ProductsManager\Views\Home\ShowOrders.cshtml"
     foreach (Order pr in Orders)
	{

#line default
#line hidden
            BeginContext(505, 16, true);
            WriteLiteral("\t\t<tr>\r\n\t\t\t<th> ");
            EndContext();
            BeginContext(522, 12, false);
#line 25 "C:\Dokumenty\GIT\Projects\C#\ASP.NET Core\ProductsManager\ProductsManager\Views\Home\ShowOrders.cshtml"
            Write(pr.ProductID);

#line default
#line hidden
            EndContext();
            BeginContext(534, 15, true);
            WriteLiteral("</th>\r\n\t\t\t<th> ");
            EndContext();
            BeginContext(550, 11, false);
#line 26 "C:\Dokumenty\GIT\Projects\C#\ASP.NET Core\ProductsManager\ProductsManager\Views\Home\ShowOrders.cshtml"
            Write(pr.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(561, 15, true);
            WriteLiteral("</th>\r\n\t\t\t<th> ");
            EndContext();
            BeginContext(577, 13, false);
#line 27 "C:\Dokumenty\GIT\Projects\C#\ASP.NET Core\ProductsManager\ProductsManager\Views\Home\ShowOrders.cshtml"
            Write(pr.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(590, 20, true);
            WriteLiteral("</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(610, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "347bce3ce2d24ca28628710ea82f09f9", async() => {
                BeginContext(688, 75, true);
                WriteLiteral("\r\n\t\t\t\t\t<button class=\"btn btn-primary\">\r\n\t\t\t\t\t\tRemove\r\n\t\t\t\t\t</button>\r\n\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Dokumenty\GIT\Projects\C#\ASP.NET Core\ProductsManager\ProductsManager\Views\Home\ShowOrders.cshtml"
                                                                     WriteLiteral(pr.OrderId);

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
            BeginContext(767, 21, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t</tr>\r\n");
            EndContext();
#line 36 "C:\Dokumenty\GIT\Projects\C#\ASP.NET Core\ProductsManager\ProductsManager\Views\Home\ShowOrders.cshtml"
	}

#line default
#line hidden
            BeginContext(792, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
