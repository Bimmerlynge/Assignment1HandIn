#pragma checksum "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bda43593f7776bbaafd7cbbb5700bf785b81f786"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1HandIn.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\_Imports.razor"
using Assignment1HandIn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\_Imports.razor"
using Assignment1HandIn.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
using Assignment1HandIn.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
           [Authorize (Policy = "SecurityLevel10")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddAdult</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                 newAdultItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                                               AddNewAdult

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "\r\n        First Name:\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                                newAdultItem.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.FirstName = __value, newAdultItem.FirstName))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "\r\n        Last Name:\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                                newAdultItem.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.LastName = __value, newAdultItem.LastName))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\r\n        Age:\r\n        ");
                __Blazor.Assignment1HandIn.Pages.AddAdult.TypeInference.CreateInputNumber_0(__builder2, 28, 29, 
#nullable restore
#line 25 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                                  newAdultItem.Age

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Age = __value, newAdultItem.Age)), 31, () => newAdultItem.Age);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "\r\n        Hair Color:\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                                newAdultItem.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.HairColor = __value, newAdultItem.HairColor))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.HairColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "\r\n        Eye Color:\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                                newAdultItem.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.EyeColor = __value, newAdultItem.EyeColor))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.EyeColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "\r\n        Weight:\r\n        ");
                __Blazor.Assignment1HandIn.Pages.AddAdult.TypeInference.CreateInputNumber_1(__builder2, 52, 53, 
#nullable restore
#line 37 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                                  newAdultItem.Weight

#line default
#line hidden
#nullable disable
                , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Weight = __value, newAdultItem.Weight)), 55, () => newAdultItem.Weight);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "\r\n        Height:\r\n        ");
                __Blazor.Assignment1HandIn.Pages.AddAdult.TypeInference.CreateInputNumber_2(__builder2, 60, 61, 
#nullable restore
#line 41 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                                  newAdultItem.Height

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Height = __value, newAdultItem.Height)), 63, () => newAdultItem.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n    ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group");
                __builder2.AddMarkupContent(67, "\r\n        Sex:\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(68);
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                                newAdultItem.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Sex = __value, newAdultItem.Sex))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.Sex));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n    ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group");
                __builder2.AddMarkupContent(75, "\r\n        Job Title:\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(76);
                __builder2.AddAttribute(77, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                                newJobItem.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newJobItem.JobTitle = __value, newJobItem.JobTitle))));
                __builder2.AddAttribute(79, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newJobItem.JobTitle));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group");
                __builder2.AddMarkupContent(83, "\r\n        Salary:\r\n        ");
                __Blazor.Assignment1HandIn.Pages.AddAdult.TypeInference.CreateInputNumber_3(__builder2, 84, 85, 
#nullable restore
#line 53 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                                  newJobItem.Salary

#line default
#line hidden
#nullable disable
                , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newJobItem.Salary = __value, newJobItem.Salary)), 87, () => newJobItem.Salary);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n    ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-group");
                __builder2.AddMarkupContent(91, "\r\n        Weight:\r\n        ");
                __Blazor.Assignment1HandIn.Pages.AddAdult.TypeInference.CreateInputNumber_4(__builder2, 92, 93, 
#nullable restore
#line 57 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                                  newAdultItem.Weight

#line default
#line hidden
#nullable disable
                , 94, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Weight = __value, newAdultItem.Weight)), 95, () => newAdultItem.Weight);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n    ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group");
                __builder2.AddMarkupContent(99, "\r\n        Height:\r\n        ");
                __Blazor.Assignment1HandIn.Pages.AddAdult.TypeInference.CreateInputNumber_5(__builder2, 100, 101, 
#nullable restore
#line 61 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                                  newAdultItem.Height

#line default
#line hidden
#nullable disable
                , 102, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Height = __value, newAdultItem.Height)), 103, () => newAdultItem.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n    ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "form-group");
                __builder2.AddMarkupContent(107, "\r\n        Sex:\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(108);
                __builder2.AddAttribute(109, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 65 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
                                newAdultItem.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Sex = __value, newAdultItem.Sex))));
                __builder2.AddAttribute(111, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.Sex));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n\r\n    ");
                __builder2.AddMarkupContent(113, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Add</button></p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\mathi\RiderProjects\Aflevering\Assignment1HandIn\Assignment1HandIn\Pages\AddAdult.razor"
       
    private Adult newAdultItem = new Adult();
    private Job newJobItem = new Job();


    private void AddNewAdult()
    {
        newAdultItem.JobTitle = newJobItem;
        AdultService.AddAdult(newAdultItem);
        NavigationManager.NavigateTo("/Adults");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
namespace __Blazor.Assignment1HandIn.Pages.AddAdult
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
