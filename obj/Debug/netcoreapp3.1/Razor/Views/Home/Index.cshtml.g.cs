#pragma checksum "C:\Users\admin\Documents\SQL Server Management Studio\Sonal_TP-5\SonalCRUD_ADO\SonalCRUD_ADO\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29f57a3982a32ed288d1720d5d293e24502116b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\admin\Documents\SQL Server Management Studio\Sonal_TP-5\SonalCRUD_ADO\SonalCRUD_ADO\Views\_ViewImports.cshtml"
using SonalCRUD_ADO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Documents\SQL Server Management Studio\Sonal_TP-5\SonalCRUD_ADO\SonalCRUD_ADO\Views\_ViewImports.cshtml"
using SonalCRUD_ADO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29f57a3982a32ed288d1720d5d293e24502116b1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41c2732093d5111bd211f18159c4b9a3462e7585", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SonalCRUD_ADO.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\admin\Documents\SQL Server Management Studio\Sonal_TP-5\SonalCRUD_ADO\SonalCRUD_ADO\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <table class=""table"" >
        <tr backgroun-colour=""light-blue"">
            <th>Roll No.</th>
            <th>Name</th>
            <th>Stnd</th>
            <th>City</th>
            <th>Stream</th>
           
        </tr>
");
#nullable restore
#line 17 "C:\Users\admin\Documents\SQL Server Management Studio\Sonal_TP-5\SonalCRUD_ADO\SonalCRUD_ADO\Views\Home\Index.cshtml"
         foreach ( var std in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\admin\Documents\SQL Server Management Studio\Sonal_TP-5\SonalCRUD_ADO\SonalCRUD_ADO\Views\Home\Index.cshtml"
       Write(std.Rollno);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\admin\Documents\SQL Server Management Studio\Sonal_TP-5\SonalCRUD_ADO\SonalCRUD_ADO\Views\Home\Index.cshtml"
       Write(std.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\admin\Documents\SQL Server Management Studio\Sonal_TP-5\SonalCRUD_ADO\SonalCRUD_ADO\Views\Home\Index.cshtml"
       Write(std.Stnd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\admin\Documents\SQL Server Management Studio\Sonal_TP-5\SonalCRUD_ADO\SonalCRUD_ADO\Views\Home\Index.cshtml"
       Write(std.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "C:\Users\admin\Documents\SQL Server Management Studio\Sonal_TP-5\SonalCRUD_ADO\SonalCRUD_ADO\Views\Home\Index.cshtml"
       Write(std.Stream);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 26 "C:\Users\admin\Documents\SQL Server Management Studio\Sonal_TP-5\SonalCRUD_ADO\SonalCRUD_ADO\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SonalCRUD_ADO.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
