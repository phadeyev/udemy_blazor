#pragma checksum "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\AnotherChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "581aab6e2afddae8f53841b00fabdb8c6d16311c"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\dev\udemy\blazor\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dev\udemy\blazor\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dev\udemy\blazor\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dev\udemy\blazor\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dev\udemy\blazor\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dev\udemy\blazor\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dev\udemy\blazor\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dev\udemy\blazor\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dev\udemy\blazor\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\dev\udemy\blazor\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\dev\udemy\blazor\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\dev\udemy\blazor\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Helper;

#line default
#line hidden
#nullable disable
    public partial class AnotherChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "<h4 class=\"ttext-primary pt3\">Another Child Component</h4>\r\n    ");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "id", "roomName");
            __builder.AddMultipleAttributes(4, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 3 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\AnotherChildComponent.razor"
                                      InputAttributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "placeholder", "Initial Text");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\AnotherChildComponent.razor"
                                              
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string,object> InputAttributes { get; set; } = new Dictionary<string, object>();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
