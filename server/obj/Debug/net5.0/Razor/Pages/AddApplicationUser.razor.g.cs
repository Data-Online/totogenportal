#pragma checksum "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71eda977d770c7a467a94baa923e24e79448a6fd"
// <auto-generated/>
#pragma warning disable 1591
namespace Totogen.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\atkin\Source\Repos\Totogen\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\atkin\Source\Repos\Totogen\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\atkin\Source\Repos\Totogen\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\atkin\Source\Repos\Totogen\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\atkin\Source\Repos\Totogen\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\atkin\Source\Repos\Totogen\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\atkin\Source\Repos\Totogen\server\_Imports.razor"
using Totogen.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
using Totogen.Models.TotogenDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
using Totogen.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-application-user")]
    public partial class AddApplicationUser : Totogen.Pages.AddApplicationUserComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ApplicationUser>>(7);
                __builder2.AddAttribute(8, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ApplicationUser>(
#nullable restore
#line 16 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
                                                           user

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
                                                                            user != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ApplicationUser>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ApplicationUser>(this, 
#nullable restore
#line 16 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
                                                                                                    Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Component", "Email");
                    __builder3.AddAttribute(19, "style", "width: 100%");
                    __builder3.AddAttribute(20, "Text", "Email");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(24);
                    __builder3.AddAttribute(25, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(26, "Name", "Email");
                    __builder3.AddAttribute(27, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
                                                                                  user.Email

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Email = __value, user.Email))));
                    __builder3.AddAttribute(29, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Email));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(31);
                    __builder3.AddAttribute(32, "Component", "Email");
                    __builder3.AddAttribute(33, "style", "position: absolute");
                    __builder3.AddAttribute(34, "Text", "Email is required");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(35, "\n            ");
                    __builder3.OpenElement(36, "div");
                    __builder3.AddAttribute(37, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(38, "class", "row");
                    __builder3.OpenElement(39, "div");
                    __builder3.AddAttribute(40, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(41);
                    __builder3.AddAttribute(42, "Component", "RoleNames");
                    __builder3.AddAttribute(43, "style", "width: 100%");
                    __builder3.AddAttribute(44, "Text", "Roles");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n              ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "class", "col-md-9");
                    __Blazor.Totogen.Pages.AddApplicationUser.TypeInference.CreateRadzenDropDown_0(__builder3, 48, 49, 
#nullable restore
#line 36 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
                                       roles

#line default
#line hidden
#nullable disable
                    , 50, 
#nullable restore
#line 36 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
                                                        true

#line default
#line hidden
#nullable disable
                    , 51, "width: 100%", 52, "Name", 53, "Name", 54, "RoleNames", 55, 
#nullable restore
#line 36 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
                                                                                                 user.RoleNames

#line default
#line hidden
#nullable disable
                    , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.RoleNames = __value, user.RoleNames)), 57, () => user.RoleNames);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n            ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(61, "class", "row");
                    __builder3.OpenElement(62, "div");
                    __builder3.AddAttribute(63, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(64);
                    __builder3.AddAttribute(65, "Component", "Password");
                    __builder3.AddAttribute(66, "style", "width: 100%");
                    __builder3.AddAttribute(67, "Text", "Password");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\n              ");
                    __builder3.OpenElement(69, "div");
                    __builder3.AddAttribute(70, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(71);
                    __builder3.AddAttribute(72, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(73, "Name", "Password");
                    __builder3.AddAttribute(74, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
                                                                                   user.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                    __builder3.AddAttribute(76, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(78);
                    __builder3.AddAttribute(79, "Component", "Password");
                    __builder3.AddAttribute(80, "style", "position: absolute");
                    __builder3.AddAttribute(81, "Text", "Password is required");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\n            ");
                    __builder3.OpenElement(83, "div");
                    __builder3.AddAttribute(84, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(85, "class", "row");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(88);
                    __builder3.AddAttribute(89, "Component", "ConfirmPassword");
                    __builder3.AddAttribute(90, "style", "width: 100%");
                    __builder3.AddAttribute(91, "Text", "Confirm password");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\n              ");
                    __builder3.OpenElement(93, "div");
                    __builder3.AddAttribute(94, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(95);
                    __builder3.AddAttribute(96, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(97, "Name", "ConfirmPassword");
                    __builder3.AddAttribute(98, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
                                                                                   user.ConfirmPassword

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.ConfirmPassword = __value, user.ConfirmPassword))));
                    __builder3.AddAttribute(100, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.ConfirmPassword));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(102);
                    __builder3.AddAttribute(103, "Component", "ConfirmPassword");
                    __builder3.AddAttribute(104, "style", "position: absolute");
                    __builder3.AddAttribute(105, "Text", "ConfirmPassword is required");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n            ");
                    __builder3.OpenElement(107, "div");
                    __builder3.AddAttribute(108, "class", "row");
                    __builder3.OpenElement(109, "div");
                    __builder3.AddAttribute(110, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(111);
                    __builder3.AddAttribute(112, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 66 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(113, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 66 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(114, "Icon", "save");
                    __builder3.AddAttribute(115, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(116, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(117);
                    __builder3.AddAttribute(118, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 68 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(119, "Text", "Cancel");
                    __builder3.AddAttribute(120, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\AddApplicationUser.razor"
                                                                                    Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Totogen.Pages.AddApplicationUser
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Multiple", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "TextProperty", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
