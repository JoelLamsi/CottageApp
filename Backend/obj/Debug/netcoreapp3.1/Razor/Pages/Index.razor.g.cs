#pragma checksum "E:\dev\CottageApp\Backend\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbfd18fa73d628ff74d5954c6e196fbcdc89e0d8"
// <auto-generated/>
#pragma warning disable 1591
namespace Backend.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "E:\dev\CottageApp\Backend\Pages\Index.razor"
 foreach (var cottage in cottages)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<MatBlazor.MatCard>(1);
            __builder.AddAttribute(2, "class", "mat-card");
            __builder.AddAttribute(3, "style", "margin-bottom: 1vw;");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatCardContent>(6);
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n            ");
                    __builder3.OpenElement(9, "div");
                    __builder3.AddAttribute(10, "class", "mat-layout-grid mat-layout-grid-align-left");
                    __builder3.AddAttribute(11, "style", "max-width: 800px;");
                    __builder3.AddMarkupContent(12, "\r\n                ");
                    __builder3.OpenElement(13, "div");
                    __builder3.AddAttribute(14, "class", "mat-layout-grid-inner");
                    __builder3.AddMarkupContent(15, "\r\n                    ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "class", "mat-layout-grid-cell");
                    __builder3.AddMarkupContent(18, "\r\n                        ");
                    __builder3.OpenElement(19, "img");
                    __builder3.AddAttribute(20, "src", 
#nullable restore
#line 10 "E:\dev\CottageApp\Backend\Pages\Index.razor"
                                   cottage.PictureUrl

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(21, "height", "100vw");
                    __builder3.AddAttribute(22, "width", "100vw");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(23, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(24, "\r\n\r\n                    ");
                    __builder3.OpenElement(25, "div");
                    __builder3.AddAttribute(26, "class", "mat-layout-grid-cell");
                    __builder3.AddMarkupContent(27, "\r\n                        ");
                    __builder3.OpenElement(28, "div");
                    __builder3.AddAttribute(29, "class", "mat-card-content");
                    __builder3.AddMarkupContent(30, "\r\n                            ");
                    __builder3.OpenComponent<MatBlazor.MatHeadline5>(31);
                    __builder3.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(33, 
#nullable restore
#line 15 "E:\dev\CottageApp\Backend\Pages\Index.razor"
                                           cottage.Title

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(35, "\r\n\r\n                        ");
                    __builder3.OpenComponent<MatBlazor.MatBody2>(36);
                    __builder3.AddAttribute(37, "Class", "mat-card-content");
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(39, "\r\n                            ");
                        __builder4.OpenElement(40, "p");
                        __builder4.AddAttribute(41, "class", "card-text");
                        __builder4.AddContent(42, 
#nullable restore
#line 19 "E:\dev\CottageApp\Backend\Pages\Index.razor"
                                                  cottage.Description

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(43, "\r\n                            ");
                        __builder4.OpenElement(44, "small");
                        __builder4.AddContent(45, 
#nullable restore
#line 20 "E:\dev\CottageApp\Backend\Pages\Index.razor"
                                    cottage.DateAdded.Date.ToString("dd.M.yyyy")

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(46, "<br>\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(48, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\r\n            \r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 42 "E:\dev\CottageApp\Backend\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "E:\dev\CottageApp\Backend\Pages\Index.razor"
       
    public Cottage cottage { get; set; }
    bool isLoading = false;
    private List<Cottage> cottages { get; set; }

    protected override void OnInitialized()
    {
        cottages = new List<Cottage>()
        {
            new Cottage()
            {
                Title = "Foo",
                Description = "This is a Foo",
                PictureUrl = "img/log-cabin-1886620_1920.jpg",
                DateAdded = DateTime.Now
            },
            new Cottage()
            {
                Title = "Bar",
                DateAdded = new DateTime(2020, 12, 31)
            }
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
