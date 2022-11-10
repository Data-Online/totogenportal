using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Totogen.Data;

namespace Totogen
{
    public partial class ExportTotogenDbController : ExportController
    {
        private readonly TotogenDbContext context;
        private readonly TotogenDbService service;
        public ExportTotogenDbController(TotogenDbContext context, TotogenDbService service)
        {
            this.service = service;
            this.context = context;
        }

        [HttpGet("/export/TotogenDb/customers/csv")]
        [HttpGet("/export/TotogenDb/customers/csv(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportCustomersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(await service.GetCustomers(), Request.Query), fileName);
        }

        [HttpGet("/export/TotogenDb/customers/excel")]
        [HttpGet("/export/TotogenDb/customers/excel(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportCustomersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(await service.GetCustomers(), Request.Query), fileName);
        }
        [HttpGet("/export/TotogenDb/feearrangements/csv")]
        [HttpGet("/export/TotogenDb/feearrangements/csv(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportFeeArrangementsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(await service.GetFeeArrangements(), Request.Query), fileName);
        }

        [HttpGet("/export/TotogenDb/feearrangements/excel")]
        [HttpGet("/export/TotogenDb/feearrangements/excel(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportFeeArrangementsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(await service.GetFeeArrangements(), Request.Query), fileName);
        }
        [HttpGet("/export/TotogenDb/feestatuses/csv")]
        [HttpGet("/export/TotogenDb/feestatuses/csv(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportFeeStatusesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(await service.GetFeeStatuses(), Request.Query), fileName);
        }

        [HttpGet("/export/TotogenDb/feestatuses/excel")]
        [HttpGet("/export/TotogenDb/feestatuses/excel(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportFeeStatusesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(await service.GetFeeStatuses(), Request.Query), fileName);
        }
        [HttpGet("/export/TotogenDb/orders/csv")]
        [HttpGet("/export/TotogenDb/orders/csv(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportOrdersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(await service.GetOrders(), Request.Query), fileName);
        }

        [HttpGet("/export/TotogenDb/orders/excel")]
        [HttpGet("/export/TotogenDb/orders/excel(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportOrdersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(await service.GetOrders(), Request.Query), fileName);
        }
    }
}
