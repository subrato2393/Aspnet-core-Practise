#pragma checksum "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a56514f16a1284cf0c0f59bd607de1b5415c5679"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_GetAll), @"mvc.1.0.view", @"/Views/Student/GetAll.cshtml")]
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
#line 1 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\_ViewImports.cshtml"
using COREMVCCrudAppADO.NET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\_ViewImports.cshtml"
using COREMVCCrudAppADO.NET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a56514f16a1284cf0c0f59bd607de1b5415c5679", @"/Views/Student/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daf915709ad433912e8705b3b20665dbbf301e9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<COREMVCCrudAppADO.NET.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""table table-bordered table-striped"">
    <thead>
       <tr>
           <th>Name</th>
           <th>Address</th>
           <th>Email</th>
           <th>Department Name</th>
           <th colspan=""2"">Action</th>
       </tr>
    </thead>
");
#nullable restore
#line 12 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\GetAll.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\GetAll.cshtml"
   Write(Html.HiddenFor(x=>item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 16 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\GetAll.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 17 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\GetAll.cshtml"
   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 18 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\GetAll.cshtml"
   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 19 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\GetAll.cshtml"
   Write(item.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 20 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\GetAll.cshtml"
   Write(Html.ActionLink("Edit", "Update", "Student",new {id=item.Id },new{@class="btn btn-success"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 21 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\GetAll.cshtml"
   Write(Html.ActionLink("Delete", "Delete", "Student", new { id = item.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 23 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\GetAll.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<COREMVCCrudAppADO.NET.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
