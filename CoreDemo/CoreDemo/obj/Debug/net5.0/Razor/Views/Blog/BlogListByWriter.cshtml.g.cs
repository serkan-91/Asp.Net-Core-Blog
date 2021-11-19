#pragma checksum "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0270eba039d77e9df0bd26616e4cc3066ddba15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
using CoreDemo.Shared.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0270eba039d77e9df0bd26616e4cc3066ddba15", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yazarin Bloglari</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Blog Basligi</th>
        <th>Olusturma Tarihi</th>
        <th>Kategori</th>
        <th>Durum</th>
        <th>Sil</th>
        <th>Duzenle</th>
    </tr>
");
#nullable restore
#line 20 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 23 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 27 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
             if (item.BlogStatus == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><span class=\"text-success\">Aktif </span> </td>\r\n");
#nullable restore
#line 30 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><span class=\"text-danger\"> Pasif </span> </td>\r\n");
#nullable restore
#line 34 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"


            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><span data-id=\"");
#nullable restore
#line 37 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                          Write(item.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger test \">Sil</span></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1058, "\"", 1092, 2);
            WriteAttributeValue("", 1065, "/Blog/EditBlog/", 1065, 15, true);
#nullable restore
#line 38 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1080, item.BlogId, 1080, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("   class=\"btn alert-warning\">Duzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>
<a href=""/Blog/BlogAdd"" class=""btn btn-info"">Yeni Blog Olustur</a>


<script>
     $(document).on(""click"","".test"",function() {
         var testid = $(this).attr(""data-id"")
         if(testid != null ){
           swal({
      title: ""Dikkat!"",
      text: ""Bu Blogu silmek istediginizden emin misiniz?"",
      icon: ""warning"",
      buttons: true,
      dangerMode: true,
    })
    .then((willDelete) => {
      if (willDelete) {
    $.ajax({
        url:""/Blog/DeleteBlog/""+testid,
        type:""GET"",
        success: function(){
              window.location.href = '/Blog/BlogListByWriter/'
        }
    })

      } 
    });
         }

        });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591