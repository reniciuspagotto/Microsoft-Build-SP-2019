#pragma checksum "C:\Development\BlazorServerSide\BlazorServerSide\Pages\Customer\Customer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "931fbb408d3c26e548d05027acbd8816b0c4a702"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerSide.Pages.Customer
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using BlazorServerSide.Shared;
    using BlazorServerSide.ViewModel;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/client")]
    public class Customer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 27 "C:\Development\BlazorServerSide\BlazorServerSide\Pages\Customer\Customer.razor"
            

    CustomerViewModel vm = new CustomerViewModel();

    void Create()
    {
        urihelper.NavigateTo("/fetchdata");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper urihelper { get; set; }
    }
}
#pragma warning restore 1591
