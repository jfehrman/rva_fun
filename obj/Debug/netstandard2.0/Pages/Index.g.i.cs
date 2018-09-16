#pragma checksum "/Users/codyhalbleib/Desktop/rdnug/rva_fun/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63824cedd02a2f0a5c8c7e55f2e1d576fed06fdf"
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
#line 6 "/Users/codyhalbleib/Desktop/rdnug/rva_fun/Pages/Index.cshtml"
            
  private Models.Activity[] activities { get; set; } 

  protected override async Task OnInitAsync()
  {
    activities = await Http.GetJsonAsync<Models.Activity[]>(RouteConstants.apiActivities);
  }
  protected async Task LikeActivity(Models.Activity activity) {
    activity.Likes++;
    await Http.PutJsonAsync<Models.Activity>(RouteConstants.apiActivities + activity.id, activity);
  }
  protected async Task DislikeActivity(Models.Activity activity) {
    activity.Dislikes++;
    await Http.PutJsonAsync<Models.Activity>(RouteConstants.apiActivities + activity.id, activity);
  }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
