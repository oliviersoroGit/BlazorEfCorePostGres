#pragma checksum "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\EditMeal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47494f42d34648396896c398298a5b6015fa6414"
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
#line 2 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\EditMeal.razor"
using DemoBlazorServerApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editMeal")]
    public partial class EditMeal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\EditMeal.razor"
                      meal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\EditMeal.razor"
                                           FormSubmitted

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.AddMarkupContent(10, "<label for=\"nom\">Nom</label><br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "id", "nom");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\EditMeal.razor"
                                             meal.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => meal.Name = __value, meal.Name))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => meal.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __Blazor.DemoBlazorServerApp.Pages.EditMeal.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 13 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\EditMeal.razor"
                                      () => meal.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.AddMarkupContent(24, "<label for=\"description\">Description</label><br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(25);
                __builder2.AddAttribute(26, "id", "description");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\EditMeal.razor"
                                                         meal.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => meal.Description = __value, meal.Description))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => meal.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.AddMarkupContent(35, "<label for=\"price\">Price</label><br>\r\n            ");
                __Blazor.DemoBlazorServerApp.Pages.EditMeal.TypeInference.CreateInputNumber_1(__builder2, 36, 37, "price", 38, 
#nullable restore
#line 21 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\EditMeal.razor"
                                                 meal.Price

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => meal.Price = __value, meal.Price)), 40, () => meal.Price);
                __builder2.AddMarkupContent(41, "\r\n            ");
                __Blazor.DemoBlazorServerApp.Pages.EditMeal.TypeInference.CreateValidationMessage_2(__builder2, 42, 43, 
#nullable restore
#line 22 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\EditMeal.razor"
                                      () => meal.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n\r\n\r\n        ");
                __builder2.AddMarkupContent(46, "<button type=\"submit\" class=\"btn btn-primary\">Modifier</button>\r\n        ");
                __builder2.OpenElement(47, "button");
                __builder2.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\EditMeal.razor"
                          BlazoredModal.Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "class", "btn btn-secondary");
                __builder2.AddContent(50, "Annuler");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\HP\source\repos\DemoBlazorServerApp\DemoBlazorServerApp\Pages\EditMeal.razor"
       
    [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }

    Meal meal = new Meal();
    [Parameter] public int id { get; set; }

    protected async override void OnInitialized()
    {
        meal = await MealService.GetMealByIdAsync(id);
    }


    private async void FormSubmitted()
    {
        await MealService.UpdateMealAsync(id, meal);
        BlazoredModal.Close(ModalResult.Ok<Meal>(meal));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMealService MealService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService ModalService { get; set; }
    }
}
namespace __Blazor.DemoBlazorServerApp.Pages.EditMeal
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
        __builder.AddAttribute(__seq0, "id", __arg0);
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
    }
}
#pragma warning restore 1591
