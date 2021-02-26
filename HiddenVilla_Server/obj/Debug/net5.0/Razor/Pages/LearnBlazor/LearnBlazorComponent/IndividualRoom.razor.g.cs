#pragma checksum "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "164d2b0ef2adf2bfb810073cf2e332720b2020a9"
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
#nullable restore
#line 1 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
using Model;

#line default
#line hidden
#nullable disable
    public partial class IndividualRoom : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light border p-2 col-5");
            __builder.OpenElement(2, "h4");
            __builder.AddAttribute(3, "class", "text-secondary");
            __builder.AddContent(4, "Room - ");
            __builder.AddContent(5, 
#nullable restore
#line 4 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                                   Room.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "checkbox");
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 6 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                                  RoomCheckBoxSelectionChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.AddContent(11, 
#nullable restore
#line 7 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
 Room.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, " <br>\r\n");
            __builder.AddContent(13, 
#nullable restore
#line 8 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
 Room.Price.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, " <br>\r\n");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "checkbox");
            __builder.AddAttribute(17, "checked", 
#nullable restore
#line 9 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                                                              Room.IsActive?"checked":null

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                                    Room.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Room.IsActive = __value, Room.IsActive));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, " &nbsp; IsActive <br>\r\n");
            __builder.OpenElement(21, "span");
            __builder.AddContent(22, "This room is ");
            __builder.AddContent(23, 
#nullable restore
#line 10 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                     Room.IsActive?"Active":"Inactive"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
 if(Room.IsActive)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
     foreach (var roomProp in Room.RoomProps)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "p");
            __builder.AddContent(25, 
#nullable restore
#line 15 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
        roomProp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, " - ");
            __builder.AddContent(27, 
#nullable restore
#line 15 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                         roomProp.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
     
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent.EditDeleteButton>(28);
            __builder.AddAttribute(29, "IsAdmin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\IndividualRoom.razor"
       
    [Parameter]
    public BlazorRoom Room { get; set; }
    [Parameter]
    public EventCallback<bool> OnRoomCheckBoxSelection { get; set; }
    
    protected async Task RoomCheckBoxSelectionChanged(ChangeEventArgs e)
    {
        await OnRoomCheckBoxSelection.InvokeAsync((bool)e.Value);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
