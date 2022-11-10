#pragma checksum "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4510376d3a20d7e76e13ff8d6fc5f4a6a4d8384"
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
#line 6 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
using Totogen.Models.TotogenDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
using Totogen.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/customer")]
    public partial class Customer : Totogen.Pages.CustomerComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "Customers");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(11);
                __builder2.AddAttribute(12, "Icon", "add_circle_outline");
                __builder2.AddAttribute(13, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(14, "Text", "Add");
                __builder2.AddAttribute(15, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                               Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSplitButton>(17);
                __builder2.AddAttribute(18, "Icon", "get_app");
                __builder2.AddAttribute(19, "style", "margin-bottom: 10px; margin-left: 10px");
                __builder2.AddAttribute(20, "Text", "Export");
                __builder2.AddAttribute(21, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenSplitButtonItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenSplitButtonItem>(this, 
#nullable restore
#line 21 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                               Splitbutton0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(23);
                    __builder3.AddAttribute(24, "Text", "Excel");
                    __builder3.AddAttribute(25, "Value", "xlsx");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(27);
                    __builder3.AddAttribute(28, "Text", "CSV");
                    __builder3.AddAttribute(29, "Value", "csv");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(31);
                __builder2.AddAttribute(32, "Placeholder", "Search ...");
                __builder2.AddAttribute(33, "style", "display: block; margin-bottom: 10px; width: 100%");
                __builder2.AddAttribute(34, "Name", "Textbox0");
                __builder2.AddAttribute(35, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                                                     async(args) => {search = $"{args.Value}";await grid0.GoToPage(0);await Load();}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<Totogen.Models.TotogenDb.Customer>>(37);
                __builder2.AddAttribute(38, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Totogen.Models.TotogenDb.Customer>>(
#nullable restore
#line 31 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                         getCustomersResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ExpandMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DataGridExpandMode>(
#nullable restore
#line 31 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                                                         DataGridExpandMode.Single

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "FilterMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 31 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                                                                                                Radzen.FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "RowExpand", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Totogen.Models.TotogenDb.Customer>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Totogen.Models.TotogenDb.Customer>(this, 
#nullable restore
#line 31 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                                                                                                                                                                                  Grid0RowExpand

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(45, "RowSelect", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Totogen.Models.TotogenDb.Customer>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Totogen.Models.TotogenDb.Customer>(this, 
#nullable restore
#line 31 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                                                                                                                                                                                                              Grid0RowSelect

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(46, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Totogen.Models.TotogenDb.Customer>>(47);
                    __builder3.AddAttribute(48, "Property", "CustomerName");
                    __builder3.AddAttribute(49, "Title", "Customer Name");
                    __builder3.AddAttribute(50, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Totogen.Models.TotogenDb.Customer>)((data) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenLink>(51);
                        __builder4.AddAttribute(52, "class", "totogenHeading");
                        __builder4.AddAttribute(53, "path", 
#nullable restore
#line 35 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                         $"customer-details/{data.CustomerId}"

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(54, "Target", "_self");
                        __builder4.AddAttribute(55, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                                        data.CustomerName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddEventStopPropagationAttribute(56, "onclick", 
#nullable restore
#line 35 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                                                                                      true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(57, "\n              ");
                        __builder4.OpenElement(58, "div");
                        __builder4.AddAttribute(59, "class", "row");
                        __builder4.OpenElement(60, "div");
                        __builder4.AddAttribute(61, "class", "col-md-6 totogenTableDetail");
                        __builder4.OpenElement(62, "span");
                        __builder4.AddAttribute(63, "class", "totogenTableDetail");
#nullable restore
#line 39 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
__builder4.AddContent(64, data.Address1);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(65, "<br>\n              \t\t");
                        __builder4.OpenElement(66, "span");
#nullable restore
#line 40 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
__builder4.AddContent(67, data.Address2);

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(68, " &nbsp ");
#nullable restore
#line 40 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
__builder4.AddContent(69, data.Address2);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Totogen.Models.TotogenDb.Customer>>(71);
                    __builder3.AddAttribute(72, "Property", "TotalOrders");
                    __builder3.AddAttribute(73, "Title", "Total Orders");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Totogen.Models.TotogenDb.Customer>>(75);
                    __builder3.AddAttribute(76, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                        false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(77, "Sortable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                         false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(78, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 47 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                                           TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(79, "Width", "70px");
                    __builder3.AddAttribute(80, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Totogen.Models.TotogenDb.Customer>)((totogenModelsTotogenDbCustomer) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(81);
                        __builder4.AddAttribute(82, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 49 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(83, "Icon", "close");
                        __builder4.AddAttribute(84, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 49 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(85, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, totogenModelsTotogenDbCustomer)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddEventStopPropagationAttribute(86, "onclick", 
#nullable restore
#line 49 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                                                                                                                              true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(87, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Totogen.Models.TotogenDb.Customer>)((totogenModelsTotogenDbCustomer) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHeading>(88);
                    __builder3.AddAttribute(89, "Size", "H1");
                    __builder3.AddAttribute(90, "Text", "Orders");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(92);
                    __builder3.AddAttribute(93, "Icon", "add_circle_outline");
                    __builder3.AddAttribute(94, "style", "margin-bottom: 10px");
                    __builder3.AddAttribute(95, "Text", "Add");
                    __builder3.AddAttribute(96, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                    (args) =>OrderAddButtonClick(args, totogenModelsTotogenDbCustomer)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(97, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGrid<Totogen.Models.TotogenDb.Order>>(98);
                    __builder3.AddAttribute(99, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 59 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                         true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(100, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 59 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(101, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 59 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(102, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Totogen.Models.TotogenDb.Order>>(
#nullable restore
#line 59 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                              totogenModelsTotogenDbCustomer.Orders

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(103, "FilterMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 59 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                                                                                  Radzen.FilterMode.Advanced

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(104, "RowSelect", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Totogen.Models.TotogenDb.Order>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Totogen.Models.TotogenDb.Order>(this, 
#nullable restore
#line 59 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                                                                                                                                                                  (args) =>Grid1RowSelect(args, totogenModelsTotogenDbCustomer)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(105, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Totogen.Models.TotogenDb.Order>>(106);
                        __builder4.AddAttribute(107, "Property", "OrderNumber");
                        __builder4.AddAttribute(108, "Title", "Order Number");
                        __builder4.AddAttribute(109, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Totogen.Models.TotogenDb.Order>)((data) => (__builder5) => {
                            __builder5.OpenElement(110, "p");
                            __builder5.AddAttribute(111, "class", "totogenHeading");
#nullable restore
#line 63 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
__builder5.AddContent(112, data.OrderNumber);

#line default
#line hidden
#nullable disable
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(113, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Totogen.Models.TotogenDb.Order>>(114);
                        __builder4.AddAttribute(115, "FormatString", "{0:d}");
                        __builder4.AddAttribute(116, "Property", "SampleExpectedDate");
                        __builder4.AddAttribute(117, "Title", "Date Expected");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(118, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Totogen.Models.TotogenDb.Order>>(119);
                        __builder4.AddAttribute(120, "Property", "TermsSent");
                        __builder4.AddAttribute(121, "Title", "Terms Sent");
                        __builder4.AddAttribute(122, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Totogen.Models.TotogenDb.Order>)((data) => (__builder5) => {
#nullable restore
#line 70 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                   if (data.TermsSent == true)
                                          {

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<Radzen.Blazor.RadzenIcon>(123);
                            __builder5.AddAttribute(124, "Icon", "done");
                            __builder5.AddAttribute(125, "IconStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.IconStyle?>(
#nullable restore
#line 72 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                         IconStyle.Success

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
#nullable restore
#line 74 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                  }
                                  else
                                  {

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<Radzen.Blazor.RadzenIcon>(126);
                            __builder5.AddAttribute(127, "Icon", "clear");
                            __builder5.AddAttribute(128, "IconStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.IconStyle?>(
#nullable restore
#line 77 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                          IconStyle.Warning

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
#nullable restore
#line 79 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                      }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(129, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Totogen.Models.TotogenDb.Order>>(130);
                        __builder4.AddAttribute(131, "Property", "InstructionsSent");
                        __builder4.AddAttribute(132, "Title", "Instructions Sent");
                        __builder4.AddAttribute(133, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Totogen.Models.TotogenDb.Order>)((data) => (__builder5) => {
#nullable restore
#line 84 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                   if (data.InstructionsSent == true)
                                          {

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<Radzen.Blazor.RadzenIcon>(134);
                            __builder5.AddAttribute(135, "Icon", "done");
                            __builder5.AddAttribute(136, "IconStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.IconStyle?>(
#nullable restore
#line 86 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                         IconStyle.Success

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
#nullable restore
#line 88 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                  }
                                  else
                                  {

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<Radzen.Blazor.RadzenIcon>(137);
                            __builder5.AddAttribute(138, "Icon", "clear");
                            __builder5.AddAttribute(139, "IconStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.IconStyle?>(
#nullable restore
#line 91 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                          IconStyle.Warning

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
#nullable restore
#line 93 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                      }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(140, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Totogen.Models.TotogenDb.Order>>(141);
                        __builder4.AddAttribute(142, "FilterProperty", "FeeArrangement1.FeeArrangement1");
                        __builder4.AddAttribute(143, "GroupProperty", "FeeArrangement1.FeeArrangement1");
                        __builder4.AddAttribute(144, "Property", "FeeArrangement");
                        __builder4.AddAttribute(145, "SortProperty", "FeeArrangement1.FeeArrangement1");
                        __builder4.AddAttribute(146, "Title", "Fee Arrangement");
                        __builder4.AddAttribute(147, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Totogen.Models.TotogenDb.Order>)((data) => (__builder5) => {
#nullable restore
#line 98 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
__builder5.AddContent(148, data.FeeArrangement1?.FeeArrangement1);

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(149, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Totogen.Models.TotogenDb.Order>>(150);
                        __builder4.AddAttribute(151, "FilterProperty", "FeeStatus1.FeeStatus1");
                        __builder4.AddAttribute(152, "GroupProperty", "FeeStatus1.FeeStatus1");
                        __builder4.AddAttribute(153, "Property", "FeeStatus");
                        __builder4.AddAttribute(154, "SortProperty", "FeeStatus1.FeeStatus1");
                        __builder4.AddAttribute(155, "Title", "Fee Status");
                        __builder4.AddAttribute(156, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Totogen.Models.TotogenDb.Order>)((data) => (__builder5) => {
#nullable restore
#line 103 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
__builder5.AddContent(157, data.FeeStatus1?.FeeStatus1);

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(158, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<Totogen.Models.TotogenDb.Order>>(159);
                        __builder4.AddAttribute(160, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 106 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                         false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(161, "Sortable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 106 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                          false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(162, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 106 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                                            TextAlign.Center

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(163, "Width", "70px");
                        __builder4.AddAttribute(164, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Totogen.Models.TotogenDb.Order>)((totogenModelsTotogenDbOrder) => (__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenButton>(165);
                            __builder5.AddAttribute(166, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 108 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                               ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(167, "Icon", "close");
                            __builder5.AddAttribute(168, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 108 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                      ButtonSize.Small

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(169, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                                 (args) =>OrderDeleteButtonClick(args, totogenModelsTotogenDbOrder)

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddEventStopPropagationAttribute(170, "onclick", 
#nullable restore
#line 108 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                                                                                                                                                                                                true

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddComponentReferenceCapture(171, (__value) => {
#nullable restore
#line 59 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                                  grid1 = (Radzen.Blazor.RadzenDataGrid<Totogen.Models.TotogenDb.Order>)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(172, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenIcon>(173);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(174, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenIcon>(175);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(176, (__value) => {
#nullable restore
#line 31 "C:\Users\atkin\Source\Repos\Totogen\server\Pages\Customer.razor"
                              grid0 = (Radzen.Blazor.RadzenDataGrid<Totogen.Models.TotogenDb.Customer>)__value;

#line default
#line hidden
#nullable disable
                }
                );
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
#pragma warning restore 1591