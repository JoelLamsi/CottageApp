#pragma checksum "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5d337e77ce3a0cab6b6bcfb00c4d91229f01598"
// <auto-generated/>
#pragma warning disable 1591
namespace Backend.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/_Imports.razor"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/_Imports.razor"
using Backend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/_Imports.razor"
using Backend.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class CottageListItem : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MatBlazor.MatCard>(0);
            __builder.AddAttribute(1, "class", "mat-card");
            __builder.AddAttribute(2, "style", "max-width: 500px; margin-bottom: 10px;");
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "mat-card-content");
                __builder2.AddAttribute(6, "style", "margin-left: 20px; margin-top: 20px;");
                __builder2.OpenComponent<global::MatBlazor.MatHeadline5>(7);
                __builder2.AddAttribute(8, "class", "mat-card-clean-margin");
                __builder2.AddAttribute(9, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 3 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
__builder3.AddContent(10, cottage.Title);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\n    ");
                __builder2.OpenComponent<global::MatBlazor.MatCardContent>(12);
                __builder2.AddAttribute(13, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MatBlazor.MatCardMedia>(14);
                    __builder3.AddAttribute(15, "Wide", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 6 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "ImageUrl", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 6 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
                                             cottage.PictureUrl

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\n        ");
                    __builder3.OpenComponent<global::MatBlazor.MatBody1>(18);
                    __builder3.AddAttribute(19, "class", "mat-card-content mat-card-clean-margin");
                    __builder3.AddAttribute(20, "style", "margin-left: 20px; margin-top: 20px; margin-right: 20px;");
                    __builder3.AddAttribute(21, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(22, "p");
                        __builder4.AddAttribute(23, "style", "text-overflow: clip;");
#nullable restore
#line 8 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
__builder4.AddContent(24, cottage.Description);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(25, "\n            ");
                        __builder4.OpenElement(26, "small");
#nullable restore
#line 9 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
__builder4.AddContent(27, cottage.DateAdded.Date.ToString("dd.M.yyyy"));

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(28, "<br>");
#nullable restore
#line 11 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
             for (var i = 0; i < 5; i++)
            {
                if (i < cottage.AvgRating)
                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<global::MatBlazor.MatIcon>(29);
                        __builder4.AddAttribute(30, "Icon", "star_rate");
                        __builder4.AddAttribute(31, "Style", "color: #fcc00a");
                        __builder4.CloseComponent();
#nullable restore
#line 15 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
                                                                               ;
                }
            }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\n    ");
                __builder2.OpenComponent<global::MatBlazor.MatCardActions>(33);
                __builder2.AddAttribute(34, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MatBlazor.MatButton>(35);
                    __builder3.AddAttribute(36, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
                              () => MakeReservation()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(37, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(38, "Make a Reservation");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\n\n");
            __builder.OpenComponent<global::MatBlazor.MatDialog>(40);
            __builder.AddAttribute(41, "CanBeClosed", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 26 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "IsOpen", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 26 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
                          dialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "IsOpenChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dialogIsOpen = __value, dialogIsOpen))));
            __builder.AddAttribute(44, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MatBlazor.MatDialogContent>(45);
                __builder2.AddAttribute(46, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MatBlazor.MatHeadline5>(47);
                    __builder3.AddAttribute(48, "class", "mat-card-clean-margin");
                    __builder3.AddAttribute(49, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 28 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
__builder4.AddContent(50, cottage.Title);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\n        ");
                    __builder3.AddMarkupContent(52, "<label>Check-In</label>\n        ");
                    global::__Blazor.Backend.Shared.CottageListItem.TypeInference.CreateMatDatePicker_0(__builder3, 53, 54, 
#nullable restore
#line 30 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
                                     checkInDate

#line default
#line hidden
#nullable disable
                    , 55, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => checkInDate = __value, checkInDate)), 56, () => checkInDate);
                    __builder3.AddMarkupContent(57, "<br>\n        ");
                    __builder3.AddMarkupContent(58, "<label>Check-Out</label>\n        ");
                    global::__Blazor.Backend.Shared.CottageListItem.TypeInference.CreateMatDatePicker_1(__builder3, 59, 60, 
#nullable restore
#line 32 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
                                     checkOutDate

#line default
#line hidden
#nullable disable
                    , 61, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => checkOutDate = __value, checkOutDate)), 62, () => checkOutDate);
                    __builder3.AddMarkupContent(63, "<br>\n        \n        ");
                    __builder3.OpenComponent<global::MatBlazor.MatButton>(64);
                    __builder3.AddAttribute(65, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
                              () => dialogIsOpen = false

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(66, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(67, "Cancel");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/media/joel/TOSHIBA EXT4/dev/BlazorProjects/CottageApp/CottageApp/Backend/Shared/CottageListItem.razor"
       
    [Parameter] public Cottage cottage { get; set; }
    public Reservation Reservation { get; set; }
    bool dialogIsOpen = false;

    DateTime checkInDate = DateTime.Now;
    DateTime checkOutDate = DateTime.Now;

    decimal totalPrice = 0.00m;
    
    void MakeReservation()
    {
        dialogIsOpen = true;
        Reservation = new Reservation();
        Reservation.CheckInDate = DateTime.Now;
        ReservationState rs = new ReservationState();
        rs.Cottage = cottage;
        TimeSpan interval = checkOutDate - checkInDate;
        Reservation.TotalPrice = interval.Days * cottage.CostPerDay;
        totalPrice = Reservation.TotalPrice;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Backend.Shared.CottageListItem
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatDatePicker_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::MatBlazor.MatDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateMatDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::MatBlazor.MatDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
