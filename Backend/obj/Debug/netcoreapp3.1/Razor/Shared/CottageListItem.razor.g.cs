#pragma checksum "E:\dev\CottageApp\Backend\Shared\CottageListItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d4241f946fb4e319173bbae3332a736067bcc30"
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
#line 1 "E:\dev\CottageApp\Backend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\dev\CottageApp\Backend\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\dev\CottageApp\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\dev\CottageApp\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\dev\CottageApp\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\dev\CottageApp\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\dev\CottageApp\Backend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\dev\CottageApp\Backend\_Imports.razor"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\dev\CottageApp\Backend\_Imports.razor"
using Backend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\dev\CottageApp\Backend\_Imports.razor"
using Backend.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\dev\CottageApp\Backend\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class CottageListItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatCard>(0);
            __builder.AddAttribute(1, "class", "mat-card");
            __builder.AddAttribute(2, "style", "max-width: 500px; margin-bottom: 10px;");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "mat-card-content");
                __builder2.AddAttribute(7, "style", "margin-left: 20px; margin-top: 20px;");
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatHeadline5>(9);
                __builder2.AddAttribute(10, "class", "mat-card-clean-margin");
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(12, 
#nullable restore
#line 3 "E:\dev\CottageApp\Backend\Shared\CottageListItem.razor"
                                                     cottage.Title

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatCardContent>(15);
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(17, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatCardMedia>(18);
                    __builder3.AddAttribute(19, "Wide", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "E:\dev\CottageApp\Backend\Shared\CottageListItem.razor"
                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "ImageUrl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "E:\dev\CottageApp\Backend\Shared\CottageListItem.razor"
                                             cottage.PictureUrl

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatBody1>(22);
                    __builder3.AddAttribute(23, "class", "mat-card-content mat-card-clean-margin");
                    __builder3.AddAttribute(24, "style", "margin-left: 20px; margin-top: 20px; margin-right: 20px;");
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(26, "\r\n            ");
                        __builder4.OpenElement(27, "p");
                        __builder4.AddAttribute(28, "style", "text-overflow: clip;");
                        __builder4.AddContent(29, 
#nullable restore
#line 8 "E:\dev\CottageApp\Backend\Shared\CottageListItem.razor"
                                             cottage.Description

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(30, "\r\n            ");
                        __builder4.OpenElement(31, "small");
                        __builder4.AddContent(32, 
#nullable restore
#line 9 "E:\dev\CottageApp\Backend\Shared\CottageListItem.razor"
                    cottage.DateAdded.Date.ToString("dd.M.yyyy")

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(33, "<br>\r\n            \r\n");
#nullable restore
#line 11 "E:\dev\CottageApp\Backend\Shared\CottageListItem.razor"
             for (var i = 0; i < 5; i++)
            {
                if (i < cottage.AvgRating)
                {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(34, "                    ");
                        __builder4.OpenComponent<MatBlazor.MatIcon>(35);
                        __builder4.AddAttribute(36, "Icon", "star_rate");
                        __builder4.AddAttribute(37, "Style", "color: #fcc00a");
                        __builder4.CloseComponent();
#nullable restore
#line 15 "E:\dev\CottageApp\Backend\Shared\CottageListItem.razor"
                                                                               ;
                }
            }

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(38, "            \r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "  \r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "E:\dev\CottageApp\Backend\Shared\CottageListItem.razor"
       
    [Parameter] public Cottage cottage { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
