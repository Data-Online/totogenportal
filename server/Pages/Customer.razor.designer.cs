using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Totogen.Models.TotogenDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Totogen.Models;

namespace Totogen.Pages
{
    public partial class CustomerComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected SecurityService Security { get; set; }

        [Inject]
        protected AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        [Inject]
        protected TotogenDbService TotogenDb { get; set; }
        protected RadzenDataGrid<Totogen.Models.TotogenDb.Customer> grid0;
        protected RadzenDataGrid<Totogen.Models.TotogenDb.Order> grid1;

        string _search;
        protected string search
        {
            get
            {
                return _search;
            }
            set
            {
                if (!object.Equals(_search, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "search", NewValue = value, OldValue = _search };
                    _search = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Totogen.Models.TotogenDb.Customer> _getCustomersResult;
        protected IEnumerable<Totogen.Models.TotogenDb.Customer> getCustomersResult
        {
            get
            {
                return _getCustomersResult;
            }
            set
            {
                if (!object.Equals(_getCustomersResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getCustomersResult", NewValue = value, OldValue = _getCustomersResult };
                    _getCustomersResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        dynamic _master;
        protected dynamic master
        {
            get
            {
                return _master;
            }
            set
            {
                if (!object.Equals(_master, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "master", NewValue = value, OldValue = _master };
                    _master = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Security.InitializeAsync(AuthenticationStateProvider);
            if (!Security.IsAuthenticated())
            {
                UriHelper.NavigateTo("Login", true);
            }
            else
            {
                await Load();
            }
        }
        protected async System.Threading.Tasks.Task Load()
        {
            if (string.IsNullOrEmpty(search)) {
                search = "";
            }

            var totogenDbGetCustomersResult = await TotogenDb.GetCustomers(new Query() { Filter = $@"i => i.CustomerName.Contains(@0) || i.Address1.Contains(@1) || i.Address2.Contains(@2) || i.Address3.Contains(@3) || i.Pcode.Contains(@4)", FilterParameters = new object[] { search, search, search, search, search } });
            getCustomersResult = totogenDbGetCustomersResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddCustomer>("Add Customer", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await TotogenDb.ExportCustomersToCSV(new Query() { Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "CustomerId,CustomerName,Address1,Address2,Address3,Pcode" }, $"Customer");

            }

            if (args == null || args.Value == "xlsx")
            {
                await TotogenDb.ExportCustomersToExcel(new Query() { Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "CustomerId,CustomerName,Address1,Address2,Address3,Pcode" }, $"Customer");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowExpand(Totogen.Models.TotogenDb.Customer args)
        {
            master = args;

            var totogenDbGetOrdersResult = await TotogenDb.GetOrders(new Query() { Filter = $@"i => i.CustomerId == {args.CustomerId}" });
            if (totogenDbGetOrdersResult != null)
            {
                args.Orders = totogenDbGetOrdersResult.ToList();
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Totogen.Models.TotogenDb.Customer args)
        {
            var dialogResult = await DialogService.OpenAsync<EditCustomer>("Edit Customer", new Dictionary<string, object>() { {"CustomerId", args.CustomerId} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var totogenDbDeleteCustomerResult = await TotogenDb.DeleteCustomer(data.CustomerId);
                    if (totogenDbDeleteCustomerResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception totogenDbDeleteCustomerException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete Customer" });
            }
        }

        protected async System.Threading.Tasks.Task OrderAddButtonClick(MouseEventArgs args, dynamic data)
        {
            var dialogResult = await DialogService.OpenAsync<AddOrder>("Add Order", new Dictionary<string, object>() { {"CustomerId", data.CustomerId} });
            await Grid0RowExpand(master);

            await grid1.Reload();
        }

        protected async System.Threading.Tasks.Task Grid1RowSelect(Totogen.Models.TotogenDb.Order args, dynamic data)
        {
            var dialogResult = await DialogService.OpenAsync<EditOrder>("Edit Order", new Dictionary<string, object>() { {"OrderId", args.OrderId} });
            await Grid0RowExpand(master);

            await grid1.Reload();
        }

        protected async System.Threading.Tasks.Task OrderDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var totogenDbDeleteOrderResult = await TotogenDb.DeleteOrder(data.OrderId);
                    await Grid0RowExpand(master);

                    if (totogenDbDeleteOrderResult != null)
                    {
                        await grid1.Reload();
                    }
                }
            }
            catch (System.Exception totogenDbDeleteOrderException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete Customer" });
            }
        }
    }
}
