using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndreyevInterview.Models.API;
using AndreyevInterview.Services;
using System.Net;
using System;
using Microsoft.EntityFrameworkCore;

namespace AndreyevInterview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {

        private readonly AIDbContext _context;
        public ContactsController(AIDbContext context)
        {
            _context = context;
        }

        #region All Get API's
        //get all contacts
        //get 1 contact
        //get 
        [HttpGet]
        public ContactModel GetContacts()
        {
            List<Contacts> Contacts = new List<Contacts>();
            var contacts = _context.Contacts.ToList();

            foreach (Contact _contact in contacts)
            {
                var invoices = _context.Invoices.AsEnumerable().Where(x => x.ContactId == _contact.Id);
                Contacts contact = new Contacts
                {
                    Id = _contact.Id,
                    Name = _contact.FirstName + " " + _contact.LastName,
                    NumInvoices = invoices.Count(),
                    LastName = _contact.LastName,
                    MiddleName = _contact.MiddleName,
                    FirstName = _contact.FirstName,
                    Email = _contact.Email,
                    PhoneNum = _contact.PhoneNum,
                    Address = _contact.Address,
                    //TotalBillable= invoices.Count()>0? invoices.Sum(x=>x.TotalBillableValue Sum(x => x.),
                    //TotalPaid= invoices.Sum(x => x.),
                    //EmerName
                    //EmerPhoneNum
                    //PaymentInfo
                    //IDNum
                    DOB = _contact.DOB,
                    LegalRep = _contact.LegalRep,
                    AdditionalNote = _contact.AdditionalNote
                };

                Contacts.Add(contact);
            }

            return new ContactModel
            {
                Contacts = Contacts
            };

            //return _context.Contacts.ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Contacts>> ShowContactInfo(int id)
        {
            var _contact = await _context.Contacts
               .Include(c => c.Invoices)
               .SingleOrDefaultAsync(m => m.Id == id);
            var invoices = _context.Invoices.AsEnumerable().Where(x => x.ContactId == _contact.Id);
            if (_contact == null)
            {
                return NotFound("Contact Id does not exist.");
            }
            //Contacts contact = new Contacts
            //{
            //    Id = _contact.Id,
            //    Name = _contact.FirstName + " " + _contact.LastName,
            //    NumInvoices = invoices.Count(),
            //    LastName = _contact.LastName,
            //    MiddleName = _contact.MiddleName,
            //    FirstName = _contact.FirstName,
            //    Email = _contact.Email,
            //    PhoneNum = _contact.PhoneNum,
            //    Address = _contact.Address,
            //    //TotalBillable= invoices.Count()>0? invoices.Sum(x=>x.TotalBillableValue Sum(x => x.),
            //    //TotalPaid= invoices.Sum(x => x.),
            //    //EmerName
            //    //EmerPhoneNum
            //    //PaymentInfo
            //    //IDNum
            //    DOB = _contact.DOB,
            //    LegalRep = _contact.LegalRep,
            //    AdditionalNote = _contact.AdditionalNote
            //};
            //return contact;
            return Ok(_contact);
        }
        
        //public LineItemModel GetInvoiceLineItems(int id)
        //{
        //    var billableInvoices = _context.LineItems.AsEnumerable().Where(x => x.InvoiceId == id && x.isBillable)
        //          .GroupBy(r => r.InvoiceId)
        //          .Select(a => new
        //          {
        //              TotalBillableValue = a.Sum(r => r.Cost)
        //          }).FirstOrDefault();

        //    var totalInvoices = _context.LineItems.AsEnumerable().Where(x => x.InvoiceId == id)
        //          .GroupBy(r => r.InvoiceId)
        //          .Select(a => new
        //          {
        //              GrandTotal = a.Sum(r => r.Cost)
        //          }).FirstOrDefault();

        //    LineItemModel lineItemModel = new LineItemModel
        //    {
        //        LineItem = _context.LineItems.Where(x => x.InvoiceId == id).ToList(),
        //        GrandTotal = totalInvoices == null ? 0 : totalInvoices.GrandTotal,
        //        TotalBillableValue = billableInvoices == null ? 0 : billableInvoices.TotalBillableValue
        //    };

        //    return lineItemModel;
        //}
        #endregion

        //[HttpPut]
        //public Invoice CreateInvoice(InvoiceInput input)
        //{
        //    var invoice = new Invoice();
        //    invoice.Description = input.Description;
        //    _context.Add(invoice);
        //    _context.SaveChanges();
        //    return invoice;
        //}

        //[HttpPost("{id}")]
        //public async Task<LineItem> AddLineItemToInvoice(int id, LineItemInput input)
        //{
        //    var lineItem = new LineItem();
        //    lineItem.InvoiceId = id;
        //    lineItem.Description = input.Description;
        //    lineItem.Quantity = input.Quantity;
        //    lineItem.Cost = input.Cost;
        //    lineItem.isBillable = input.isBillable;

        //    if (input.Id == 0)
        //    {
        //        await _invoiceServices.AddLineItem(lineItem);
        //    }
        //    else
        //    {
        //        await _invoiceServices.UpdateLineItem(lineItem);
        //    }

        //    //_context.Add(lineItem);
        //    //_context.SaveChanges();
        //    return lineItem;
        //}

        //[HttpPut("Update")]
        //public async Task<bool> UpdateBillable(LineItemBillable lineItem)
        //{
        //    return await _invoiceServices.UpdateLineItem(new LineItem
        //    {
        //        InvoiceId = lineItem.InvoiceId,
        //        isBillable = lineItem.isBillable,
        //        Id = lineItem.LineItemId
        //    });
        //}
        //#endregion
    }
}