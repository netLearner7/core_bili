#pragma checksum "E:\core_bili\Views\Home\_Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f031a4881af09773100485329bb83225f6385dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Index1), @"mvc.1.0.view", @"/Views/Home/_Index1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_Index1.cshtml", typeof(AspNetCore.Views_Home__Index1))]
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
#line 1 "E:\core_bili\Views\_ViewImports.cshtml"
using core_bili;

#line default
#line hidden
#line 2 "E:\core_bili\Views\_ViewImports.cshtml"
using core_bili.Models;

#line default
#line hidden
#line 1 "E:\core_bili\Views\Home\_Index1.cshtml"
using core_bili.Myserver;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f031a4881af09773100485329bb83225f6385dc", @"/Views/Home/_Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b8ca8e170092c352ce0fc627ca32f905d16aa6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "E:\core_bili\Views\Home\_Index1.cshtml"
  

    foreach (var item in Model)
    {
        

#line default
#line hidden
            BeginContext(109, 7, false);
#line 9 "E:\core_bili\Views\Home\_Index1.cshtml"
   Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(118, 9, false);
#line 9 "E:\core_bili\Views\Home\_Index1.cshtml"
            Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(129, 16, true);
            WriteLiteral("        <br />\r\n");
            EndContext();
#line 11 "E:\core_bili\Views\Home\_Index1.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
