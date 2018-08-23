#pragma checksum "/Users/jfehrman/Development/rva_fun/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "336e7fe57faad6a51484901567a3a03f20643e03"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
#line 24 "/Users/jfehrman/Development/rva_fun/Pages/Index.cshtml"
 if (activities == null)
{

#line default
#line hidden
            builder.AddContent(0, "  ");
            builder.OpenElement(1, "div");
            builder.AddContent(2, "Loading . . .");
            builder.CloseElement();
            builder.AddContent(3, "\n");
#line 27 "/Users/jfehrman/Development/rva_fun/Pages/Index.cshtml"
}
else
{
  

#line default
#line hidden
#line 30 "/Users/jfehrman/Development/rva_fun/Pages/Index.cshtml"
   foreach (Activity activity in activities)
  {

#line default
#line hidden
            builder.AddContent(4, "    ");
            builder.OpenElement(5, "div");
            builder.AddContent(6, activity.Title);
            builder.CloseElement();
            builder.AddContent(7, "\n");
#line 33 "/Users/jfehrman/Development/rva_fun/Pages/Index.cshtml"
  }

#line default
#line hidden
#line 33 "/Users/jfehrman/Development/rva_fun/Pages/Index.cshtml"
   
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 6 "/Users/jfehrman/Development/rva_fun/Pages/Index.cshtml"
            
  //add back @using Models
    private Activity[] activities { get; set; }

    protected override async Task OnInitAsync()
    {
      var response = await Http.GetStringAsync("http://ec2-52-91-254-158.compute-1.amazonaws.com/activities");
      Console.WriteLine(response);

      activities = await Http.GetJsonAsync<Activity[]>("http://ec2-52-91-254-158.compute-1.amazonaws.com/activities");
      //Console.WriteLine(secondResponse);

      foreach(Activity activity in activities) {
        Console.WriteLine("Here is an activity: " + activity.Title);
      }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
