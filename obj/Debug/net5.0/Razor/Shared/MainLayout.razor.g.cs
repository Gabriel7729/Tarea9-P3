#pragma checksum "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9df8cc3fb441a68e775e113457dbdb3f50bb1d3f"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_9.Shared
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using Tarea_9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using Tarea_9.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using Tarea_9.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-p7el4aeas0");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-p7el4aeas0");
            __builder.OpenComponent<Tarea_9.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-p7el4aeas0");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-p7el4aeas0><a href=\"AcercaDe\" b-p7el4aeas0>Acerca de</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-p7el4aeas0");
            __builder.AddContent(15, 
#nullable restore
#line 14 "C:\Users\Lusan\Downloads\Tarea9-P3\Tarea9-P3\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n            <br b-p7el4aeas0>\r\n\r\n            ");
            __builder.AddMarkupContent(17, @"<footer class=""bg-light text-center text-lg-start"" b-p7el4aeas0><div class=""text-center text-white p-3"" style=""background-color:black;color:white);"" b-p7el4aeas0>
        Acerca de :
        <a class=""text-white"" href=""AcercaDe"" b-p7el4aeas0>Grupo super trabajador E</a></div></footer>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
