using Radzen;
using System;
using System.Web;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Data;
using System.Text.Encodings.Web;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using Totogen.Data;

namespace Totogen
{
    public partial class TotogenDbService
    {
        TotogenDbContext Context
        {
           get
           {
             return this.context;
           }
        }

        private readonly TotogenDbContext context;
        private readonly NavigationManager navigationManager;

        public TotogenDbService(TotogenDbContext context, NavigationManager navigationManager)
        {
            this.context = context;
            this.navigationManager = navigationManager;
        }

        public void Reset() => Context.ChangeTracker.Entries().Where(e => e.Entity != null).ToList().ForEach(e => e.State = EntityState.Detached);

        public async Task ExportCustomersToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/totogendb/customers/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/totogendb/customers/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportCustomersToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/totogendb/customers/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/totogendb/customers/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnCustomersRead(ref IQueryable<Models.TotogenDb.Customer> items);

        public async Task<IQueryable<Models.TotogenDb.Customer>> GetCustomers(Query query = null)
        {
            var items = Context.Customers.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p.Trim());
                    }
                }

                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnCustomersRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnCustomerCreated(Models.TotogenDb.Customer item);
        partial void OnAfterCustomerCreated(Models.TotogenDb.Customer item);

        public async Task<Models.TotogenDb.Customer> CreateCustomer(Models.TotogenDb.Customer customer)
        {
            OnCustomerCreated(customer);

            var existingItem = Context.Customers
                              .Where(i => i.CustomerId == customer.CustomerId)
                              .FirstOrDefault();

            if (existingItem != null)
            {
               throw new Exception("Item already available");
            }            

            try
            {
                Context.Customers.Add(customer);
                Context.SaveChanges();
            }
            catch
            {
                Context.Entry(customer).State = EntityState.Detached;
                throw;
            }

            OnAfterCustomerCreated(customer);

            return customer;
        }
        public async Task ExportFeeArrangementsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/totogendb/feearrangements/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/totogendb/feearrangements/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportFeeArrangementsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/totogendb/feearrangements/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/totogendb/feearrangements/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnFeeArrangementsRead(ref IQueryable<Models.TotogenDb.FeeArrangement> items);

        public async Task<IQueryable<Models.TotogenDb.FeeArrangement>> GetFeeArrangements(Query query = null)
        {
            var items = Context.FeeArrangements.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p.Trim());
                    }
                }

                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnFeeArrangementsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnFeeArrangementCreated(Models.TotogenDb.FeeArrangement item);
        partial void OnAfterFeeArrangementCreated(Models.TotogenDb.FeeArrangement item);

        public async Task<Models.TotogenDb.FeeArrangement> CreateFeeArrangement(Models.TotogenDb.FeeArrangement feeArrangement)
        {
            OnFeeArrangementCreated(feeArrangement);

            var existingItem = Context.FeeArrangements
                              .Where(i => i.FeeArrangementId == feeArrangement.FeeArrangementId)
                              .FirstOrDefault();

            if (existingItem != null)
            {
               throw new Exception("Item already available");
            }            

            try
            {
                Context.FeeArrangements.Add(feeArrangement);
                Context.SaveChanges();
            }
            catch
            {
                Context.Entry(feeArrangement).State = EntityState.Detached;
                throw;
            }

            OnAfterFeeArrangementCreated(feeArrangement);

            return feeArrangement;
        }
        public async Task ExportFeeStatusesToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/totogendb/feestatuses/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/totogendb/feestatuses/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportFeeStatusesToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/totogendb/feestatuses/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/totogendb/feestatuses/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnFeeStatusesRead(ref IQueryable<Models.TotogenDb.FeeStatus> items);

        public async Task<IQueryable<Models.TotogenDb.FeeStatus>> GetFeeStatuses(Query query = null)
        {
            var items = Context.FeeStatuses.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p.Trim());
                    }
                }

                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnFeeStatusesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnFeeStatusCreated(Models.TotogenDb.FeeStatus item);
        partial void OnAfterFeeStatusCreated(Models.TotogenDb.FeeStatus item);

        public async Task<Models.TotogenDb.FeeStatus> CreateFeeStatus(Models.TotogenDb.FeeStatus feeStatus)
        {
            OnFeeStatusCreated(feeStatus);

            var existingItem = Context.FeeStatuses
                              .Where(i => i.FeeStatusId == feeStatus.FeeStatusId)
                              .FirstOrDefault();

            if (existingItem != null)
            {
               throw new Exception("Item already available");
            }            

            try
            {
                Context.FeeStatuses.Add(feeStatus);
                Context.SaveChanges();
            }
            catch
            {
                Context.Entry(feeStatus).State = EntityState.Detached;
                throw;
            }

            OnAfterFeeStatusCreated(feeStatus);

            return feeStatus;
        }
        public async Task ExportOrdersToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/totogendb/orders/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/totogendb/orders/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportOrdersToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/totogendb/orders/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/totogendb/orders/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnOrdersRead(ref IQueryable<Models.TotogenDb.Order> items);

        public async Task<IQueryable<Models.TotogenDb.Order>> GetOrders(Query query = null)
        {
            var items = Context.Orders.AsQueryable();

            items = items.Include(i => i.FeeArrangement1);

            items = items.Include(i => i.Customer);

            items = items.Include(i => i.FeeStatus1);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p.Trim());
                    }
                }

                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnOrdersRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnOrderCreated(Models.TotogenDb.Order item);
        partial void OnAfterOrderCreated(Models.TotogenDb.Order item);

        public async Task<Models.TotogenDb.Order> CreateOrder(Models.TotogenDb.Order order)
        {
            OnOrderCreated(order);

            var existingItem = Context.Orders
                              .Where(i => i.OrderId == order.OrderId)
                              .FirstOrDefault();

            if (existingItem != null)
            {
               throw new Exception("Item already available");
            }            

            try
            {
                Context.Orders.Add(order);
                Context.SaveChanges();
            }
            catch
            {
                Context.Entry(order).State = EntityState.Detached;
                order.FeeArrangement1 = null;
                order.Customer = null;
                order.FeeStatus1 = null;
                throw;
            }

            OnAfterOrderCreated(order);

            return order;
        }

        partial void OnCustomerDeleted(Models.TotogenDb.Customer item);
        partial void OnAfterCustomerDeleted(Models.TotogenDb.Customer item);

        public async Task<Models.TotogenDb.Customer> DeleteCustomer(int? customerId)
        {
            var itemToDelete = Context.Customers
                              .Where(i => i.CustomerId == customerId)
                              .Include(i => i.Orders)
                              .FirstOrDefault();

            if (itemToDelete == null)
            {
               throw new Exception("Item no longer available");
            }

            OnCustomerDeleted(itemToDelete);

            Context.Customers.Remove(itemToDelete);

            try
            {
                Context.SaveChanges();
            }
            catch
            {
                Context.Entry(itemToDelete).State = EntityState.Unchanged;
                throw;
            }

            OnAfterCustomerDeleted(itemToDelete);

            return itemToDelete;
        }

        partial void OnCustomerGet(Models.TotogenDb.Customer item);

        public async Task<Models.TotogenDb.Customer> GetCustomerByCustomerId(int? customerId)
        {
            var items = Context.Customers
                              .AsNoTracking()
                              .Where(i => i.CustomerId == customerId);

            var itemToReturn = items.FirstOrDefault();

            OnCustomerGet(itemToReturn);

            return await Task.FromResult(itemToReturn);
        }

        public async Task<Models.TotogenDb.Customer> CancelCustomerChanges(Models.TotogenDb.Customer item)
        {
            var entityToCancel = Context.Entry(item);
            if (entityToCancel.State == EntityState.Modified)
            {
              entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
              entityToCancel.State = EntityState.Unchanged;
            }

            return item;
        }

        partial void OnCustomerUpdated(Models.TotogenDb.Customer item);
        partial void OnAfterCustomerUpdated(Models.TotogenDb.Customer item);

        public async Task<Models.TotogenDb.Customer> UpdateCustomer(int? customerId, Models.TotogenDb.Customer customer)
        {
            OnCustomerUpdated(customer);

            var itemToUpdate = Context.Customers
                              .Where(i => i.CustomerId == customerId)
                              .FirstOrDefault();
            if (itemToUpdate == null)
            {
               throw new Exception("Item no longer available");
            }

            var entryToUpdate = Context.Entry(itemToUpdate);
            entryToUpdate.CurrentValues.SetValues(customer);
            entryToUpdate.State = EntityState.Modified;
            Context.SaveChanges();       

            OnAfterCustomerUpdated(customer);

            return customer;
        }

        partial void OnFeeArrangementDeleted(Models.TotogenDb.FeeArrangement item);
        partial void OnAfterFeeArrangementDeleted(Models.TotogenDb.FeeArrangement item);

        public async Task<Models.TotogenDb.FeeArrangement> DeleteFeeArrangement(int? feeArrangementId)
        {
            var itemToDelete = Context.FeeArrangements
                              .Where(i => i.FeeArrangementId == feeArrangementId)
                              .Include(i => i.Orders)
                              .FirstOrDefault();

            if (itemToDelete == null)
            {
               throw new Exception("Item no longer available");
            }

            OnFeeArrangementDeleted(itemToDelete);

            Context.FeeArrangements.Remove(itemToDelete);

            try
            {
                Context.SaveChanges();
            }
            catch
            {
                Context.Entry(itemToDelete).State = EntityState.Unchanged;
                throw;
            }

            OnAfterFeeArrangementDeleted(itemToDelete);

            return itemToDelete;
        }

        partial void OnFeeArrangementGet(Models.TotogenDb.FeeArrangement item);

        public async Task<Models.TotogenDb.FeeArrangement> GetFeeArrangementByFeeArrangementId(int? feeArrangementId)
        {
            var items = Context.FeeArrangements
                              .AsNoTracking()
                              .Where(i => i.FeeArrangementId == feeArrangementId);

            var itemToReturn = items.FirstOrDefault();

            OnFeeArrangementGet(itemToReturn);

            return await Task.FromResult(itemToReturn);
        }

        public async Task<Models.TotogenDb.FeeArrangement> CancelFeeArrangementChanges(Models.TotogenDb.FeeArrangement item)
        {
            var entityToCancel = Context.Entry(item);
            if (entityToCancel.State == EntityState.Modified)
            {
              entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
              entityToCancel.State = EntityState.Unchanged;
            }

            return item;
        }

        partial void OnFeeArrangementUpdated(Models.TotogenDb.FeeArrangement item);
        partial void OnAfterFeeArrangementUpdated(Models.TotogenDb.FeeArrangement item);

        public async Task<Models.TotogenDb.FeeArrangement> UpdateFeeArrangement(int? feeArrangementId, Models.TotogenDb.FeeArrangement feeArrangement)
        {
            OnFeeArrangementUpdated(feeArrangement);

            var itemToUpdate = Context.FeeArrangements
                              .Where(i => i.FeeArrangementId == feeArrangementId)
                              .FirstOrDefault();
            if (itemToUpdate == null)
            {
               throw new Exception("Item no longer available");
            }

            var entryToUpdate = Context.Entry(itemToUpdate);
            entryToUpdate.CurrentValues.SetValues(feeArrangement);
            entryToUpdate.State = EntityState.Modified;
            Context.SaveChanges();       

            OnAfterFeeArrangementUpdated(feeArrangement);

            return feeArrangement;
        }

        partial void OnFeeStatusDeleted(Models.TotogenDb.FeeStatus item);
        partial void OnAfterFeeStatusDeleted(Models.TotogenDb.FeeStatus item);

        public async Task<Models.TotogenDb.FeeStatus> DeleteFeeStatus(int? feeStatusId)
        {
            var itemToDelete = Context.FeeStatuses
                              .Where(i => i.FeeStatusId == feeStatusId)
                              .Include(i => i.Orders)
                              .FirstOrDefault();

            if (itemToDelete == null)
            {
               throw new Exception("Item no longer available");
            }

            OnFeeStatusDeleted(itemToDelete);

            Context.FeeStatuses.Remove(itemToDelete);

            try
            {
                Context.SaveChanges();
            }
            catch
            {
                Context.Entry(itemToDelete).State = EntityState.Unchanged;
                throw;
            }

            OnAfterFeeStatusDeleted(itemToDelete);

            return itemToDelete;
        }

        partial void OnFeeStatusGet(Models.TotogenDb.FeeStatus item);

        public async Task<Models.TotogenDb.FeeStatus> GetFeeStatusByFeeStatusId(int? feeStatusId)
        {
            var items = Context.FeeStatuses
                              .AsNoTracking()
                              .Where(i => i.FeeStatusId == feeStatusId);

            var itemToReturn = items.FirstOrDefault();

            OnFeeStatusGet(itemToReturn);

            return await Task.FromResult(itemToReturn);
        }

        public async Task<Models.TotogenDb.FeeStatus> CancelFeeStatusChanges(Models.TotogenDb.FeeStatus item)
        {
            var entityToCancel = Context.Entry(item);
            if (entityToCancel.State == EntityState.Modified)
            {
              entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
              entityToCancel.State = EntityState.Unchanged;
            }

            return item;
        }

        partial void OnFeeStatusUpdated(Models.TotogenDb.FeeStatus item);
        partial void OnAfterFeeStatusUpdated(Models.TotogenDb.FeeStatus item);

        public async Task<Models.TotogenDb.FeeStatus> UpdateFeeStatus(int? feeStatusId, Models.TotogenDb.FeeStatus feeStatus)
        {
            OnFeeStatusUpdated(feeStatus);

            var itemToUpdate = Context.FeeStatuses
                              .Where(i => i.FeeStatusId == feeStatusId)
                              .FirstOrDefault();
            if (itemToUpdate == null)
            {
               throw new Exception("Item no longer available");
            }

            var entryToUpdate = Context.Entry(itemToUpdate);
            entryToUpdate.CurrentValues.SetValues(feeStatus);
            entryToUpdate.State = EntityState.Modified;
            Context.SaveChanges();       

            OnAfterFeeStatusUpdated(feeStatus);

            return feeStatus;
        }

        partial void OnOrderDeleted(Models.TotogenDb.Order item);
        partial void OnAfterOrderDeleted(Models.TotogenDb.Order item);

        public async Task<Models.TotogenDb.Order> DeleteOrder(int? orderId)
        {
            var itemToDelete = Context.Orders
                              .Where(i => i.OrderId == orderId)
                              .FirstOrDefault();

            if (itemToDelete == null)
            {
               throw new Exception("Item no longer available");
            }

            OnOrderDeleted(itemToDelete);

            Context.Orders.Remove(itemToDelete);

            try
            {
                Context.SaveChanges();
            }
            catch
            {
                Context.Entry(itemToDelete).State = EntityState.Unchanged;
                throw;
            }

            OnAfterOrderDeleted(itemToDelete);

            return itemToDelete;
        }

        partial void OnOrderGet(Models.TotogenDb.Order item);

        public async Task<Models.TotogenDb.Order> GetOrderByOrderId(int? orderId)
        {
            var items = Context.Orders
                              .AsNoTracking()
                              .Where(i => i.OrderId == orderId);

            items = items.Include(i => i.FeeArrangement1);

            items = items.Include(i => i.Customer);

            items = items.Include(i => i.FeeStatus1);

            var itemToReturn = items.FirstOrDefault();

            OnOrderGet(itemToReturn);

            return await Task.FromResult(itemToReturn);
        }

        public async Task<Models.TotogenDb.Order> CancelOrderChanges(Models.TotogenDb.Order item)
        {
            var entityToCancel = Context.Entry(item);
            if (entityToCancel.State == EntityState.Modified)
            {
              entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
              entityToCancel.State = EntityState.Unchanged;
            }

            return item;
        }

        partial void OnOrderUpdated(Models.TotogenDb.Order item);
        partial void OnAfterOrderUpdated(Models.TotogenDb.Order item);

        public async Task<Models.TotogenDb.Order> UpdateOrder(int? orderId, Models.TotogenDb.Order order)
        {
            OnOrderUpdated(order);

            var itemToUpdate = Context.Orders
                              .Where(i => i.OrderId == orderId)
                              .FirstOrDefault();
            if (itemToUpdate == null)
            {
               throw new Exception("Item no longer available");
            }

            var entryToUpdate = Context.Entry(itemToUpdate);
            entryToUpdate.CurrentValues.SetValues(order);
            entryToUpdate.State = EntityState.Modified;
            Context.SaveChanges();       

            OnAfterOrderUpdated(order);

            return order;
        }
    }
}
