#pragma checksum "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ece606cede56f36a2a1a3c23865b959368bb614"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
#line 1 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
using CoreDemo.Shared.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ece606cede56f36a2a1a3c23865b959368bb614", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Writer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"main-content-w3layouts-agileits\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<h3 class=\"tittle\">Yazar Kayit Sayfasi</h3>\r\n\t\t\t\t<div class=\"inner-sec\">\r\n\t\t\t<div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 14 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
             using (Html.BeginForm("Index","Register",FormMethod.Post))
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ece606cede56f36a2a1a3c23865b959368bb6144659", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t<div class=\"form-row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-md-6 mb-3\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"validationCustom01\">Adiniz Soyadiniz</label>\r\n\r\n");
                WriteLiteral("\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 22 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                               Write(Html.TextBoxFor(x=>x.WriterName, new { @class= "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 23 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                               Write(Html.ValidationMessageFor(x=> x.WriterName,"", new { @class= "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-md-6 mb-3\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"validationCustom02\">Mail Adresiniz</label>\r\n");
                WriteLiteral("\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 28 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                               Write(Html.TextBoxFor(x => x.WriterMail, new { @class= "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 29 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                               Write(Html.ValidationMessageFor(x => x.WriterMail,"", new { @class= "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-row\">\r\n\t\t\t\t\t\t\t\t<div class=\"form-group col-md-6\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"exampleInputPassword1 mb-2\">Sifre</label>\r\n");
                WriteLiteral("\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 36 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                               Write(Html.TextBoxFor(x => x.WriterPassword, new { @class= "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 37 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                               Write(Html.ValidationMessageFor(x => x.WriterPassword,"", new { @class= "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n");
                WriteLiteral("\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-row\">\r\n\t\t\t\t\t\t\t\t<div class=\"form-group col-md-6\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"exampleInputImage mb-2\">Image</label>\r\n");
                WriteLiteral("\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 49 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                               Write(Html.TextBoxFor(x => x.WriterImage, new { @class= "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 50 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                               Write(Html.ValidationMessageFor(x => x.WriterImage,"", new { @class= "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t \r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-primary submit mb-4\">Kayit Ol</button>\r\n\t\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t\t<a href=\"#\" id=\"btn1\">Tum sartlari okudum. Kabul ediyorum.</a>\r\n\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\serka\OneDrive\Documents\GitHub\Asp.Net-Core-Blog\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		
					</div>
			</div>
		</div>
		<br/>
		 
		<script>
			$(document).on(""click"",""#btn1"",function(){
				swal(""Kullanici Sozlesmesi"",""Sitemizde verdiginiz mail adresi uzerinden bilgi ve haber e-postalari spam olcusune varmadan gonderilmeye devam edilecektir.""+
""Eger e-posta bulteninden cikmak isterseniz mail bultenini durdurabilirsiniz,""+
""sifre ve mail adresleriniz sifrelenmis formatta herhangi bir kullanicinin gormeyecegi formatta veri tabanlarimizda saklanmaktadir!"");
			})
		</script>
	</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591
