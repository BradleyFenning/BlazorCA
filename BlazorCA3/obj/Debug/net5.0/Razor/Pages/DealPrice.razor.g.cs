#pragma checksum "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec9243c92f007ba9b492d1fa73d11f9b7526f5f5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCA3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\_Imports.razor"
using BlazorCA3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
using System.Runtime.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
using BlazorCA3;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DealPrice")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/DealPrice/{DEALID}")]
    public partial class DealPrice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Deal Detail</h3>\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, 
#nullable restore
#line 9 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
     strfeedback

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
 if (found)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "h1");
            __builder.AddContent(4, 
#nullable restore
#line 14 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
         deal.gameInfo.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 15 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
               deal.gameInfo.thumb

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<h2>Deal Price</h2>\r\n    ");
            __builder.OpenElement(10, "h4");
            __builder.AddMarkupContent(11, "???");
            __builder.AddContent(12, 
#nullable restore
#line 17 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
          deal.gameInfo.salePrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "<h2>Cheaper Deals</h2>\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-sm border rounded");
            __builder.AddAttribute(16, "style", "border-color:darkgray; background-color:aqua");
            __builder.OpenElement(17, "table");
            __builder.AddAttribute(18, "class", "table");
            __builder.AddMarkupContent(19, "<thead><tr><th>Store Id</th>\r\n                    <th>Deal ID</th>\r\n                    <th>Deal Price</th>\r\n                    <th>Retail Price</th></tr></thead>\r\n            ");
            __builder.OpenElement(20, "tbody");
#nullable restore
#line 32 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
                 foreach (CheaperStore d in deal.cheaperStores)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "tr");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 35 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
                             d.storeID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", "/DealPrice/" + (
#nullable restore
#line 36 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
                                                 d.dealID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, 
#nullable restore
#line 36 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
                                                            d.dealID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(29, "D");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "td");
            __builder.AddMarkupContent(32, "???");
            __builder.AddContent(33, 
#nullable restore
#line 37 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
                              d.salePrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "td");
            __builder.AddMarkupContent(36, "???");
            __builder.AddContent(37, 
#nullable restore
#line 38 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
                              d.retailPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, 
#nullable restore
#line 45 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
 strfeedback

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Bradley\OneDrive - Technological University Dublin\semester7\EAD\CAs\CA3\BlazorCA3\Pages\DealPrice.razor"
       

    [Parameter]
    public string DEALID { get; set; }


    string strfeedback;
    private bool found;

    private DealDetails deal;
    protected override async Task OnInitializedAsync()
    {
        try
        {
            deal = await Http.GetFromJsonAsync<DealDetails>("https://www.cheapshark.com/api/1.0/deals?id=" + DEALID);
            found = true;
            strfeedback = String.Empty;

        }
        catch (Exception e)
        {
            found = false;
            strfeedback = e.Message;
        }
    }

    public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
    {
        // The unix timestamp is how many seconds since the epoch time
        // so just substract
        var epochDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        epochDateTime = epochDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
        return epochDateTime;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
