#pragma checksum "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/Pages/UIeventargsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bdd9ad84a5040740e2431702526d403ece045a9"
// <auto-generated/>
#pragma warning disable 1591
namespace Excersise_3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/_Imports.razor"
using Excersise_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/_Imports.razor"
using Excersise_3.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UIeventargsPage")]
    public partial class UIeventargsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "text-center");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 6 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/Pages/UIeventargsPage.razor"
                 async (changeargs)=> await TestChangeArguments(changeargs)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "width: 300px;height:300px;border:3px solid #ff0000;");
            __builder.AddAttribute(8, "type", "checkbox");
            __builder.AddAttribute(9, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/Pages/UIeventargsPage.razor"
                                  async (changeargs)=> await TestMouseArguments(changeargs)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n\n");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, 
#nullable restore
#line 15 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/Pages/UIeventargsPage.razor"
    output

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/Pages/UIeventargsPage.razor"
       
  string output;
  
  Task TestChangeArguments(ChangeEventArgs e)
  {
    output = (string)e.Value;
    return Task.CompletedTask;
  }
  
  Task TestMouseArguments(MouseEventArgs e)
  {
    output = "x: " + e.ScreenX + "; y: " + e.ScreenY;
    return Task.CompletedTask;
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
