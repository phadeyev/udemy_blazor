// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages.LearnBlazor
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
#line 12 "D:\dev\udemy\blazor\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lifecycle")]
    public partial class Lifecycle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
       
    List<string> EventType = new List<string>();
    private int currentCount = 0;
    private int Count { get; set; } = 5;
    private void IncrementCount()
    {
        currentCount++;
    }
    protected override void OnInitialized()
    {
        EventType.Add("OnInitialized is called");
    }
    protected override async Task OnInitializedAsync()
    {
        EventType.Add("OnInitializedAsync is called");
        await Task.Delay(1000);
    }
    protected override void OnParametersSet()
    {
        EventType.Add("OnParametersSet is called");
    }
    protected override async Task OnParametersSetAsync()
    {
        EventType.Add("OnParametersSetAsync is called");
        await Task.Delay(1000);
    }
    protected override void OnAfterRender(bool firstRender)
    {
        EventType.Add("OnAfterRender is called");
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        EventType.Add("OnAfterRenderAsync is called");
        await Task.Delay(1000);
    }
    protected override bool ShouldRender()
        {
            EventType.Add("ShouldRender is called");
            return base.ShouldRender();
        }

    void StartCountDown()
    {
        var timer = new Timer(TimeCallback, null, 1000, 1000);
    }

    void TimeCallback(object state)
    {
        if (Count > 0)
        {
            Count--;
            InvokeAsync(StateHasChanged);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
