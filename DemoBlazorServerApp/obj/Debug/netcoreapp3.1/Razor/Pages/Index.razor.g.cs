#pragma checksum "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "738cfbe36106f598871fa590608cd86750ed0683"
// <auto-generated/>
#pragma warning disable 1591
namespace DemoBlazorServerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\_Imports.razor"
using DemoBlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\_Imports.razor"
using DemoBlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\Index.razor"
using DemoBlazorServerApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <h4><span class=\"oi oi-list\" aria-hidden=\"true\"></span> Liste de plats</h4>\r\n    </div>\r\n\r\n</div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-6");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\Index.razor"
                            () => AddMeal()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "btn btn-sm btn-primary");
            __builder.AddMarkupContent(10, "<span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Ajouter plat ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n<br>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\Index.razor"
 if (meals == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.AddMarkupContent(15, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 23 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\Index.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.OpenElement(17, "table");
            __builder.AddAttribute(18, "class", "table");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.AddMarkupContent(20, "<thead>\r\n            <tr>\r\n                <th>Nom</th>\r\n                <th>Description</th>\r\n                <th>Prix</th>\r\n                <th>Actions</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(21, "tbody");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 37 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\Index.razor"
             foreach (var meal in meals)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 40 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\Index.razor"
                         meal.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 41 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\Index.razor"
                         meal.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 42 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\Index.razor"
                         meal.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, " $");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "th");
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\Index.razor"
                                            () => DeleteMeal(meal.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "btn btn-sm btn-primary");
            __builder.AddContent(41, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        | ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\Index.razor"
                                              () => EditMeal(meal.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "class", "btn btn-sm btn-secondary");
            __builder.AddContent(46, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 48 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 51 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\Index.razor"
       
    private List<Meal> meals;

    protected override async Task OnInitializedAsync()
    {
        meals = await MealService.GetMealsAsync();
    }

    async Task AddMeal()
    {
        var mealModal = Modal.Show<AddMeal>("Ajout de plat");
        var result = await mealModal.Result;

        if (!result.Cancelled)
        {
            meals = await MealService.GetMealsAsync();
        }
    }

    async Task DeleteMeal(int id)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(Meal.Id), id);

        var mealModal = Modal.Show<DeleteMeal>("Suppression de plat", parameters);
        var result = await mealModal.Result;

        if (!result.Cancelled)
        {
            meals = await MealService.GetMealsAsync();
        }
    }

    async Task EditMeal(int id)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(Meal.Id), id);

        var mealModal = Modal.Show<EditMeal>("Mise à jour de plat", parameters);
        var result = await mealModal.Result;

        if (!result.Cancelled)
        {
            meals = await MealService.GetMealsAsync();
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMealService MealService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
    }
}
#pragma warning restore 1591