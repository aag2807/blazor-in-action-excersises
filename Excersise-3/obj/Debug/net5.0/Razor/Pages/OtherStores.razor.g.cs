#pragma checksum "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/Pages/OtherStores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e51a8e564ac52b11461d2dfec72b0243e9fc371"
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
#nullable restore
#line 3 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/Pages/OtherStores.razor"
using System.Runtime.Serialization.Formatters.Binary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/otherStores")]
    public partial class OtherStores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "text-center");
            __builder.AddAttribute(2, "style", "display:flex;flex-direction:column; justify-content:center;");
            __builder.AddMarkupContent(3, "<h3>Key to retrieve</h3>\n  ");
            __builder.OpenElement(4, "div");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/Pages/OtherStores.razor"
                               testkey_forget

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => testkey_forget = __value, testkey_forget));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n  ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "text-center");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/Pages/OtherStores.razor"
                  async () => await GetObjectFromLocalStorage()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "btn btn-info");
            __builder.AddMarkupContent(15, "\n      Get Object from local\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n");
            __builder.OpenElement(17, "h5");
            __builder.AddContent(18, 
#nullable restore
#line 19 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/Pages/OtherStores.razor"
     output

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n<hr>\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "text-center");
            __builder.AddAttribute(22, "style", "display:flex;flex-direction:column; justify-content:center;");
            __builder.AddMarkupContent(23, "<h3>Insert Object</h3>\n  ");
            __builder.OpenElement(24, "div");
            __builder.AddMarkupContent(25, "<label for=\"key\">key</label>\n    ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "id", "key");
            __builder.AddAttribute(28, "type", "text");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/Pages/OtherStores.razor"
                                        testkey_forobject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => testkey_forobject = __value, testkey_forobject));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n\n  ");
            __builder.AddMarkupContent(32, "<div><label for=\"id\">Id</label></div>\n\n  ");
            __builder.AddMarkupContent(33, "<div><label for=\"val\">Value</label></div>\n  \n\n  ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "text-center");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/Pages/OtherStores.razor"
                  async () => await AddObjectToLocal()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "class", "btn btn-success");
            __builder.AddMarkupContent(39, "\n      Insert object to local\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "/home/alvaro/Documents/csharp/blazor in action/Excersise-3/Pages/OtherStores.razor"
       
  string testkey_forget;
  string testkey_forobject;

  string output;

  async Task AddObjectToLocal()
  {
    BinaryFormatter formatter = new BinaryFormatter();
    var tempstream = new System.IO.MemoryStream();
    string base64 = Convert.ToBase64String(tempstream.ToArray());
    await js.InvokeAsync<object>("window.localStorage.setItem", testkey_forobject, base64);
  }

  async Task GetObjectFromLocalStorage()
  {
    string base64 = await js.InvokeAsync<string>("window.localStorage.getItem", testkey_forget);
    
    output = base64;
    BinaryFormatter formatter = new BinaryFormatter();
    var tempstream = new System.IO.MemoryStream(Convert.FromBase64String(base64));
  
  }
  

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
