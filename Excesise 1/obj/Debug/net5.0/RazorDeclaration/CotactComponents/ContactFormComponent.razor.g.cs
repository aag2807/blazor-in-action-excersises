// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ebs2.CotactComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/alvaro/Documents/csharp/ebs2/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/alvaro/Documents/csharp/ebs2/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alvaro/Documents/csharp/ebs2/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/alvaro/Documents/csharp/ebs2/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/alvaro/Documents/csharp/ebs2/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/alvaro/Documents/csharp/ebs2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/alvaro/Documents/csharp/ebs2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/alvaro/Documents/csharp/ebs2/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/alvaro/Documents/csharp/ebs2/_Imports.razor"
using ebs2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/alvaro/Documents/csharp/ebs2/_Imports.razor"
using ebs2.Shared;

#line default
#line hidden
#nullable disable
    public partial class ContactFormComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "/home/alvaro/Documents/csharp/ebs2/CotactComponents/ContactFormComponent.razor"
       
  public string name;
  public string email;
  public string message;

  public bool displayboxopened = false;
  public string displayboxmessage;

  public async void SendMessageAsync()
  {
    if(await cnservice.SendMessage(name,email,message))
    {
      displayboxmessage = "Message send succesfully";
      displayboxopened = true;
      await Task.Delay(7000);
      displayboxopened = false;
    }
    else
    {
      displayboxmessage = "Sending failed, please try again";
      displayboxopened = true;
      await Task.Delay(7000);
      displayboxopened = false;
    }
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.ContactService cnservice { get; set; }
    }
}
#pragma warning restore 1591