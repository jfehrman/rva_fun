#pragma checksum "/Users/jfehrman/Development/rva_fun/Shared/NavMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e6c87ccaa3d203215af1e54b123743d26f38511"
// <auto-generated/>
#pragma warning disable 1591
namespace rva_fun.Shared
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
    public class NavMenu : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "nav");
            builder.AddAttribute(1, "class", "navbar navbar-inverse navbar-expand-lg navbar-dark bg-dark");
            builder.AddContent(2, "\n  ");
            builder.OpenElement(3, "a");
            builder.AddAttribute(4, "class", "navbar-brand");
            builder.AddAttribute(5, "href", "#");
            builder.AddContent(6, "Richmond Virginia Fun");
            builder.CloseElement();
            builder.AddContent(7, "\n  ");
            builder.OpenElement(8, "button");
            builder.AddAttribute(9, "class", "navbar-toggler");
            builder.AddAttribute(10, "type", "button");
            builder.AddAttribute(11, "data-toggle", "collapse");
            builder.AddAttribute(12, "data-target", "#navbarSupportedContent");
            builder.AddAttribute(13, "aria-controls", "navbarSupportedContent");
            builder.AddAttribute(14, "aria-expanded", "false");
            builder.AddAttribute(15, "aria-label", "Toggle navigation");
            builder.AddContent(16, "\n    ");
            builder.OpenElement(17, "span");
            builder.AddAttribute(18, "class", "navbar-toggler-icon");
            builder.CloseElement();
            builder.AddContent(19, "\n  ");
            builder.CloseElement();
            builder.AddContent(20, "\n\n  ");
            builder.OpenElement(21, "div");
            builder.AddAttribute(22, "class", "collapse  navbar-collapse");
            builder.AddAttribute(23, "id", "navbarSupportedContent");
            builder.AddContent(24, "\n  ");
            builder.CloseElement();
            builder.AddContent(25, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
