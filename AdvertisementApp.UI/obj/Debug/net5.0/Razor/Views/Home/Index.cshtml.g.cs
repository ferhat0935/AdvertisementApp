#pragma checksum "C:\Users\pamuk\OneDrive\Masaüstü\Web Geliştirme\AspNet.Core\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "669bcc424480ca1bea3e433e75b205d14110a2e84010b3c73baf437d71960d20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\pamuk\OneDrive\Masaüstü\Web Geliştirme\AspNet.Core\AdvertisementApp\AdvertisementApp.UI\Views\_ViewImports.cshtml"
using AdvertisementApp.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pamuk\OneDrive\Masaüstü\Web Geliştirme\AspNet.Core\AdvertisementApp\AdvertisementApp.UI\Views\_ViewImports.cshtml"
using AdvertisementApp.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pamuk\OneDrive\Masaüstü\Web Geliştirme\AspNet.Core\AdvertisementApp\AdvertisementApp.UI\Views\_ViewImports.cshtml"
using AdvertisementApp.Common.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"669bcc424480ca1bea3e433e75b205d14110a2e84010b3c73baf437d71960d20", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0dedda4bc35c6120cd38b63c46e7a463bef12885b32160e42e3ba3b13be8ba73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProvidedServiceListDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\pamuk\OneDrive\Masaüstü\Web Geliştirme\AspNet.Core\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Header-->
<header class=""masthead text-center text-white"">
    <div class=""masthead-content"">
        <div class=""container px-5"">
            <h1 class=""masthead-heading mb-0"">Solmaz Bilişim</h1>
            <h2 class=""masthead-subheading mb-0"">Web,Mobil ve Masaüstü Uygulamaları</h2>
            <a class=""btn btn-primary btn-xl rounded-pill mt-5"" href=""#scroll"">Daha Fazla</a>
        </div>
    </div>
    <div class=""bg-circle-1 bg-circle""></div>
    <div class=""bg-circle-2 bg-circle""></div>
    <div class=""bg-circle-3 bg-circle""></div>
    <div class=""bg-circle-4 bg-circle""></div>
</header>
");
#nullable restore
#line 20 "C:\Users\pamuk\OneDrive\Masaüstü\Web Geliştirme\AspNet.Core\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
 for (int i=0; i<Model?.Count;i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section id=\"scroll\">\r\n        <div class=\"container px-5\">\r\n            <div class=\"row gx-5 align-items-center\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 923, "\"", 965, 2);
            WriteAttributeValue("", 931, "col-lg-6", 931, 8, true);
#nullable restore
#line 25 "C:\Users\pamuk\OneDrive\Masaüstü\Web Geliştirme\AspNet.Core\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 939, i%2==0?"order-lg-2":"", 940, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"p-5\"><img class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 1043, "\"", 1068, 1);
#nullable restore
#line 26 "C:\Users\pamuk\OneDrive\Masaüstü\Web Geliştirme\AspNet.Core\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 1049, Model[i].ImagePath, 1049, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1124, "\"", 1166, 2);
            WriteAttributeValue("", 1132, "col-lg-6", 1132, 8, true);
#nullable restore
#line 28 "C:\Users\pamuk\OneDrive\Masaüstü\Web Geliştirme\AspNet.Core\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1140, i%2==0?"order-lg-1":"", 1141, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"p-5\">\r\n                        <h2 class=\"display-4\">");
#nullable restore
#line 30 "C:\Users\pamuk\OneDrive\Masaüstü\Web Geliştirme\AspNet.Core\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
                                         Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>");
#nullable restore
#line 31 "C:\Users\pamuk\OneDrive\Masaüstü\Web Geliştirme\AspNet.Core\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"
                      Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 37 "C:\Users\pamuk\OneDrive\Masaüstü\Web Geliştirme\AspNet.Core\AdvertisementApp\AdvertisementApp.UI\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProvidedServiceListDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
