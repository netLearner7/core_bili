#pragma checksum "E:\core_bili\Views\Shared\Components\Welcome\Defalut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "705cb091cbeb8fec9aa87b3d4a927699614ecdbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Welcome_Defalut), @"mvc.1.0.view", @"/Views/Shared/Components/Welcome/Defalut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Welcome/Defalut.cshtml", typeof(AspNetCore.Views_Shared_Components_Welcome_Defalut))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"705cb091cbeb8fec9aa87b3d4a927699614ecdbd", @"/Views/Shared/Components/Welcome/Defalut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b8ca8e170092c352ce0fc627ca32f905d16aa6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Welcome_Defalut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 11, true);
            WriteLiteral("\r\n<h1>学生总数：");
            EndContext();
            BeginContext(27, 5, false);
#line 3 "E:\core_bili\Views\Shared\Components\Welcome\Defalut.cshtml"
    Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(32, 6, true);
            WriteLiteral(" </h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591