// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea_9.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\_Imports.razor"
using Tarea_9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\_Imports.razor"
using Tarea_9.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\Pages\Counter.razor"
using Tarea_9.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\Pages\Counter.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListadoRegistros")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\a\Downloads\ITLA-seaon 6\Prog 3\T9\Tarea9-P3\Pages\Counter.razor"
       
    //Metodos para manejar la Base de Datos
    List<Vacunados> Vacunados = new List<Vacunados>();
    protected override async Task OnInitializedAsync()
    {
        await RefreshVacunados();
    }

    /*protected async Task ExportToPdf()
    {
      using (MemoryStream memory = ExportService.CreatePdf(vacuna))
      {
          await js.SaveAs("Sample.pdf" , memory.ToArray());
      }
    }*/

    private async Task RefreshVacunados()
    {
        Vacunados = await service.GetVacunadosAsync();
    }

    public Vacunados NewVacunados { get; set; } = new Vacunados();
    private async Task AddNewVacunados()
    {
        await service.AddVacunadosAsync(NewVacunados);
        NewVacunados = new Vacunados();
        await RefreshVacunados();
    }

    Vacunados UpdateVacunados = new Vacunados();
    private void SetVacunadosForUpdate(Vacunados Vacunado)
    {
        UpdateVacunados = Vacunado;
    }

    private async Task UpdateVacunadosData()
    {
        await service.UpdateVacunadosAsync(UpdateVacunados);
        await RefreshVacunados();
    }

    private async Task DeleteVacunados(Vacunados Vacunado)
    {
        await service.DeleteVacunadosAsync(Vacunado);
        await RefreshVacunados();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ExportService ExportService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VacunadosServices service { get; set; }
    }
}
#pragma warning restore 1591
