#pragma checksum "C:\Users\joell\dev\CottageApp-master\Backend\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b6b75ac0fc73cc9eacdc0f856691189cb6d10fe"
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
#line 1 "C:\Users\joell\dev\CottageApp-master\Backend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joell\dev\CottageApp-master\Backend\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joell\dev\CottageApp-master\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joell\dev\CottageApp-master\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joell\dev\CottageApp-master\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joell\dev\CottageApp-master\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joell\dev\CottageApp-master\Backend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joell\dev\CottageApp-master\Backend\_Imports.razor"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joell\dev\CottageApp-master\Backend\_Imports.razor"
using Backend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\joell\dev\CottageApp-master\Backend\_Imports.razor"
using Backend.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\joell\dev\CottageApp-master\Backend\_Imports.razor"
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
#line 3 "C:\Users\joell\dev\CottageApp-master\Backend\Pages\Index.razor"
 foreach (var cottage in cottages)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Backend.Shared.CottageListItem>(0);
            __builder.AddAttribute(1, "Cottage", 
#nullable restore
#line 5 "C:\Users\joell\dev\CottageApp-master\Backend\Pages\Index.razor"
                               cottage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseComponent();
#nullable restore
#line 6 "C:\Users\joell\dev\CottageApp-master\Backend\Pages\Index.razor"
                                                                
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\joell\dev\CottageApp-master\Backend\Pages\Index.razor"
       
    public Cottage cottage { get; set; }
    private List<Cottage> cottages { get; set; }

    protected override void OnInitialized()
    {
        cottages = new List<Cottage>()
        {
            new Cottage()
            {
                Title = "Foo",
                Description = $"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                PictureUrl = "img/log-cabin-1886620_1920.jpg",
                DateAdded = DateTime.Now,
                Ratings = new int[] {1,2, 4, 1, 3}
            },
            new Cottage()
            {
                Title = "Bar",
                PictureUrl = "img/cabin-1082063__340.webp",
                DateAdded = new DateTime(2020, 12, 31),
                Ratings = new int[] {5}
            }
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
