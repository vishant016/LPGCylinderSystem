#pragma checksum "H:\SEM 6 session 1\SDP\LPGCylinderSystem\LPGCylinderSystem\Views\Complaint\Resolved.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c2d616bf6cbde8aaeb240ca2142a1c6936527d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Complaint_Resolved), @"mvc.1.0.view", @"/Views/Complaint/Resolved.cshtml")]
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
#line 1 "H:\SEM 6 session 1\SDP\LPGCylinderSystem\LPGCylinderSystem\Views\_ViewImports.cshtml"
using LPGCylinderSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\SEM 6 session 1\SDP\LPGCylinderSystem\LPGCylinderSystem\Views\_ViewImports.cshtml"
using LPGCylinderSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c2d616bf6cbde8aaeb240ca2142a1c6936527d9", @"/Views/Complaint/Resolved.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4add51cf005bb73233dca277d7feb9030e7fe79f", @"/Views/_ViewImports.cshtml")]
    public class Views_Complaint_Resolved : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LPGCylinderSystem.Models.Complaint>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\SEM 6 session 1\SDP\LPGCylinderSystem\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"
  
    ViewData["Title"] = "Resolved";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "H:\SEM 6 session 1\SDP\LPGCylinderSystem\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Resolved</h1>\r\n");
            WriteLiteral("<div>\r\n    <h4>Complaint</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n           Complaint_Id\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "H:\SEM 6 session 1\SDP\LPGCylinderSystem\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"
       Write(item.Complaint_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Category\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "H:\SEM 6 session 1\SDP\LPGCylinderSystem\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"
       Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Description\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "H:\SEM 6 session 1\SDP\LPGCylinderSystem\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"
       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n       \r\n        <dt class = \"col-sm-2\">\r\n            Remark\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "H:\SEM 6 session 1\SDP\LPGCylinderSystem\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"
       Write(item.Remark);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Booking_Id\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "H:\SEM 6 session 1\SDP\LPGCylinderSystem\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"
       Write(item.Booking_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
#nullable restore
#line 49 "H:\SEM 6 session 1\SDP\LPGCylinderSystem\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LPGCylinderSystem.Models.Complaint>> Html { get; private set; }
    }
}
#pragma warning restore 1591