#pragma checksum "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Comment\_CommentListByBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "888366efc16ce5bd80c584689629bc394f718f6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment__CommentListByBlog), @"mvc.1.0.view", @"/Views/Comment/_CommentListByBlog.cshtml")]
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
#line 1 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Comment\_CommentListByBlog.cshtml"
using CoreDemo.Shared.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"888366efc16ce5bd80c584689629bc394f718f6a", @"/Views/Comment/_CommentListByBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment__CommentListByBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Comment\_CommentListByBlog.cshtml"
     foreach (var item in Model)
   {
	   

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"comment-top\">\r\n\t\t\t\t\t\t<h4>Yorumlar</h4>\r\n\t\t\t\t\t\t<div class=\"media\"> \r\n\t\t\t\t\t\t\t<div class=\"media-body\">\r\n\t\t\t\t\t\t\t\t<h5 class=\"mt-0\">");
#nullable restore
#line 11 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Comment\_CommentListByBlog.cshtml"
                                            Write(item.CommentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 12 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Comment\_CommentListByBlog.cshtml"
                              Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t \r\n\t\t\t\t\t\t\t\t \r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 18 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Comment\_CommentListByBlog.cshtml"
   }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591