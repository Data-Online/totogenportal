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
    public partial class EditOrderComponent : ComponentBase
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

        [Parameter]
        public dynamic OrderId { get; set; }

        Totogen.Models.TotogenDb.Order _order;
        protected Totogen.Models.TotogenDb.Order order
        {
            get
            {
                return _order;
            }
            set
            {
                if (!object.Equals(_order, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "order", NewValue = value, OldValue = _order };
                    _order = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Totogen.Models.TotogenDb.FeeArrangement> _getFeeArrangementsForFeeArrangementResult;
        protected IEnumerable<Totogen.Models.TotogenDb.FeeArrangement> getFeeArrangementsForFeeArrangementResult
        {
            get
            {
                return _getFeeArrangementsForFeeArrangementResult;
            }
            set
            {
                if (!object.Equals(_getFeeArrangementsForFeeArrangementResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getFeeArrangementsForFeeArrangementResult", NewValue = value, OldValue = _getFeeArrangementsForFeeArrangementResult };
                    _getFeeArrangementsForFeeArrangementResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Totogen.Models.TotogenDb.FeeStatus> _getFeeStatusesForFeeStatusResult;
        protected IEnumerable<Totogen.Models.TotogenDb.FeeStatus> getFeeStatusesForFeeStatusResult
        {
            get
            {
                return _getFeeStatusesForFeeStatusResult;
            }
            set
            {
                if (!object.Equals(_getFeeStatusesForFeeStatusResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getFeeStatusesForFeeStatusResult", NewValue = value, OldValue = _getFeeStatusesForFeeStatusResult };
                    _getFeeStatusesForFeeStatusResult = value;
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
            var totogenDbGetOrderByOrderIdResult = await TotogenDb.GetOrderByOrderId(OrderId);
            order = totogenDbGetOrderByOrderIdResult;

            var totogenDbGetFeeArrangementsResult = await TotogenDb.GetFeeArrangements();
            getFeeArrangementsForFeeArrangementResult = totogenDbGetFeeArrangementsResult;

            var totogenDbGetFeeStatusesResult = await TotogenDb.GetFeeStatuses();
            getFeeStatusesForFeeStatusResult = totogenDbGetFeeStatusesResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Totogen.Models.TotogenDb.Order args)
        {
            try
            {
                var totogenDbUpdateOrderResult = await TotogenDb.UpdateOrder(OrderId, order);
                DialogService.Close(order);
            }
            catch (System.Exception totogenDbUpdateOrderException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to update Order" });
            }
        }

        protected async System.Threading.Tasks.Task Button4Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
