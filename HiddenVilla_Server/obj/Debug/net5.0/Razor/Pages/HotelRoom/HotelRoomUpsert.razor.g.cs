#pragma checksum "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2e86bbb1f58a92c932d53f50637627e18d4f45d"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.HotelRoom
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
#line 3 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/create")]
    public partial class HotelRoomUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-2 mb-5");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "card-title text-info mb-3 ml-3");
            __builder.AddContent(4, 
#nullable restore
#line 10 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " Hotel Room");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                  HotelRoomModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                                 HandleHotelRoomUpsert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label>Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                HotelRoomModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.Name = __value, HotelRoomModel.Name))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 20 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                () => HotelRoomModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label>Occupancy</label>\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateInputNumber_1(__builder2, 34, 35, "form-control", 36, 
#nullable restore
#line 24 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                  HotelRoomModel.Occupancy

#line default
#line hidden
#nullable disable
                , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.Occupancy = __value, HotelRoomModel.Occupancy)), 38, () => HotelRoomModel.Occupancy);
                __builder2.AddMarkupContent(39, "\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_2(__builder2, 40, 41, 
#nullable restore
#line 25 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                () => HotelRoomModel.Occupancy

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label>Rate</label>\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateInputNumber_3(__builder2, 46, 47, "form-control", 48, 
#nullable restore
#line 29 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                  HotelRoomModel.RegularRate

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.RegularRate = __value, HotelRoomModel.RegularRate)), 50, () => HotelRoomModel.RegularRate);
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_4(__builder2, 52, 53, 
#nullable restore
#line 30 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                () => HotelRoomModel.RegularRate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "<label>Sq ft.</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                HotelRoomModel.SqFt

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.SqFt = __value, HotelRoomModel.SqFt))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomModel.SqFt));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                    ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddMarkupContent(66, "<label>Details</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(67);
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                    HotelRoomModel.Details

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.Details = __value, HotelRoomModel.Details))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomModel.Details));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                    ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group");
                __builder2.OpenElement(75, "button");
                __builder2.AddAttribute(76, "class", "btn btn-primary");
                __builder2.AddContent(77, 
#nullable restore
#line 41 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                         Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(78, " room");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(80);
                __builder2.AddAttribute(81, "href", "hotel-room");
                __builder2.AddAttribute(82, "class", "btn btn-secondary");
                __builder2.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(84, "BackTo Index");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\dev\udemy\blazor\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
       
    private HotelRoomDTO HotelRoomModel { get; set; } = new HotelRoomDTO();
    private string Title { get; set; } = "Create";
    private async Task HandleHotelRoomUpsert()
    {
        var roomDetailByName = await HotelRoomRepository.IsRoomUnique(HotelRoomModel.Name);
        if (roomDetailByName != null)
        {
            //there is duplicate room show error
            return;
        }
        var createdResult = await HotelRoomRepository.CreateHotelRoom(HotelRoomModel);
        NavigationManager.NavigateTo("hotel-room");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository HotelRoomRepository { get; set; }
    }
}
namespace __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591