#pragma checksum "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe2c4a3ace9eb695e63c8d0c6c9eb0ecfdda04da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
#line 1 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
using CoreDemo.Shared.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe2c4a3ace9eb695e63c8d0c6c9eb0ecfdda04da", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Blog Duzenle</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
 using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Id"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogId, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                                                                ; 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br/>\r\n");
#nullable restore
#line 15 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Basligi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogTitle, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                                                                   ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br/>\r\n");
#nullable restore
#line 18 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Thumbnail Url"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogThumbnailImage, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                                                                            ;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br/>\r\n");
#nullable restore
#line 22 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Gorseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogImage, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                                                                   ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br/>\r\n");
#nullable restore
#line 25 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(x=> x.CategoryId,(List<SelectListItem>)ViewBag.cv, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br/>\r\n");
#nullable restore
#line 28 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Icerigi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextAreaFor(x=>x.BlogContent,10,3, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                                                                           ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br/>\r\n");
#nullable restore
#line 31 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Durumu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(x=>x.BlogStatus,  new List<SelectListItem> {
                     new SelectListItem {
                        Text="Aktif",
                        Value="true" ,
                        // Selected = true, seçili olarak gelsin
                        // Disabled = true  disable olarak gelsin istersek kullanıyoruz
                     },
                     new SelectListItem {
                        Text="Pasif",
                        Value="false",
                     },

                 },  new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
                                                   ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br/>\r\n  <button class=\"btn btn-success\">Guncelle</button>\r\n");
#nullable restore
#line 47 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
