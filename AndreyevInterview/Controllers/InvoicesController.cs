#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AndreyevInterview.Models.API;
using AndreyevInterview.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
#endregion

namespace AndreyevInterview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvoicesController : ControllerBase
    {
        #region Constractor
        private readonly AIDbContext _context;
        private readonly IInvoiceServices _invoiceServices;

        public InvoicesController(AIDbContext context, IInvoiceServices invoiceServices)
        {
            _context = context;
            _invoiceServices = invoiceServices;
        }
        #endregion

        #region All Get API's
        [HttpGet]

        public InvoiceModel GetInvoices()
        {
            List<Invoices> Invoices = new List<Invoices>();
            var invoices = _context.Invoices.ToList();

            foreach (Invoice _invoice in invoices)
            {
                var lineItems = _context.LineItems.AsEnumerable().Where(x => x.InvoiceId == _invoice.Id);
                Invoices invoice = new Invoices
                {
                    Id = _invoice.Id,
                    Description = _invoice.Description,
                    ContactId = _invoice.ContactId,
                    TotalBillableValue = lineItems.Count() > 0 ? lineItems.Where(x => x.isBillable).Sum(x => x.Cost) : 0,
                    TotalNumberLineItems = lineItems.Count(),
                    TotalValue = lineItems.Count() > 0 ? lineItems.Sum(x => x.Cost) : 0
                };

                Invoices.Add(invoice);
            }

            return new InvoiceModel
            {
                Invoices = Invoices
            };

            //return _context.Invoices.ToList();
        }

        [HttpGet("{id}")]
        public LineItemModel GetInvoiceLineItems(int id)
        {
            var billableInvoices = _context.LineItems.AsEnumerable().Where(x => x.InvoiceId == id && x.isBillable)
                  .GroupBy(r => r.InvoiceId)
                  .Select(a => new
                  {
                      TotalBillableValue = a.Sum(r => r.Cost)
                  }).FirstOrDefault();

            var totalInvoices = _context.LineItems.AsEnumerable().Where(x => x.InvoiceId == id)
                  .GroupBy(r => r.InvoiceId)
                  .Select(a => new
                  {
                      GrandTotal = a.Sum(r => r.Cost)
                  }).FirstOrDefault();

            LineItemModel lineItemModel = new LineItemModel
            {
                LineItem = _context.LineItems.Where(x => x.InvoiceId == id).ToList(),
                GrandTotal = totalInvoices == null ? 0 : totalInvoices.GrandTotal,
                TotalBillableValue = billableInvoices == null ? 0 : billableInvoices.TotalBillableValue
            };

            return lineItemModel;
        }
        #endregion

        [HttpPut]
        public Invoice CreateInvoice(InvoiceInput input)
        {
            var invoice = new Invoice();
            invoice.Description = input.Description;
            invoice.ContactId = 1;
            //invoice.ContactId = input.ContactId;
            _context.Add(invoice);
            _context.SaveChanges();
            return invoice;
        }

        [HttpPost("{id}")]
        public async Task<LineItem> AddLineItemToInvoice(int id, LineItemInput input)
        {
            var lineItem = new LineItem();
            lineItem.InvoiceId = id;
            lineItem.Description = input.Description;
            lineItem.Quantity = input.Quantity;
            lineItem.Cost = input.Cost;
            lineItem.isBillable = input.isBillable;

            if (input.Id == 0)
            {
                await _invoiceServices.AddLineItem(lineItem);
            }
            else
            {
                await _invoiceServices.UpdateLineItem(lineItem);
            }

            //_context.Add(lineItem);
            //_context.SaveChanges();
            return lineItem;
        }

        [HttpPut("Update")]
        public async Task<bool> UpdateBillable(LineItemBillable lineItem)
        {
            return await _invoiceServices.UpdateLineItem(new LineItem
            {
                InvoiceId = lineItem.InvoiceId,
                isBillable = lineItem.isBillable,
                Id = lineItem.LineItemId
            });
        }
    }
}