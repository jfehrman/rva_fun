#pragma checksum "/Users/jfehrman/Development/rva_fun/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbb4bc2cddc73c59f42b1eec7fb9856b18d49721"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace rva_fun.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using rva_fun;
    using rva_fun.Shared;
    using Models;
    using Constants;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 6 "/Users/jfehrman/Development/rva_fun/Pages/Index.cshtml"
            
    private Models.Activity[] activities { get; set; } 

    protected override async Task OnInitAsync()
    {
      activities = await Http.GetJsonAsync<Models.Activity[]>(RouteConstants.apiActivities);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
