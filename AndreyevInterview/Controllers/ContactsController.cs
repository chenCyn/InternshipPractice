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

        //get contacts to display list of contacts
        //get 1 contact to display all info
        //put to create new contact with unique contact id
        //put to edit and update contact infos
        //post to initially create all info of contact

        #region Get APIs
        //get contacts to display list of contacts
        //get 1 contact to display all info
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
                    //LastName = _contact.LastName,
                    //MiddleName = _contact.MiddleName,
                    //FirstName = _contact.FirstName,
                    Email = _contact.Email,
                    PhoneNum = _contact.PhoneNum,
                    //Address = _contact.Address,
                    //TotalBillable= invoices.Count()>0? invoices.Sum(x=>x.TotalBillableValue Sum(x => x.),
                    //TotalPaid= invoices.Sum(x => x.),
                    //EmerName
                    //EmerPhoneNum
                    //PaymentInfo
                    //IDNum
                    //DOB = _contact.DOB,
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
            var invoices = _context.Invoices.Where(x => x.ContactId == _contact.Id);
            if (_contact == null)
            {
                return NotFound("Contact Id does not exist.");
            }
            var result = new Contacts
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
                AdditionalNote = _contact.AdditionalNote,
                InvoiceIds = _contact.Invoices.Select(i => i.Id).ToList()
            };
            return Ok(result);
        }
        #endregion

        #region Put API
        //put to create new contact with unique contact id, given input of legal representative
        //put to edit and update contact infos
        [HttpPut]
        public Contact CreateContact(ContactInput input)
        {
            var contact = new Contact();
            contact.LastName = input.LastName;
            contact.MiddleName = input.MiddleName;
            contact.FirstName = input.FirstName;
            contact.Email = input.Email;
            contact.PhoneNum = input.PhoneNum;
            contact.Address = input.Address;
            contact.EmerName = input.EmerName;
            contact.EmerPhoneNum = input.EmerPhoneNum;
            contact.DOB = input.DOB;
            contact.LegalRep = input.LegalRep;
            contact.AdditionalNote = input.AdditionalNote;
            _context.Add(contact);
            _context.SaveChanges();
            return contact;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateContact(int id, ContactInput input)
        {
            var existingContact = await _context.Contacts.FindAsync(id);
            if (existingContact == null)
            {
                return NotFound("Contact not found");
            }
            existingContact.Email = input.Email;
            existingContact.PhoneNum = input.PhoneNum;
            existingContact.Address = input.Address;
            existingContact.LegalRep = input.LegalRep;
            existingContact.AdditionalNote = input.AdditionalNote;
            _context.SaveChanges();
            return NoContent();
        }
        //[HttpPut("{id}/Update")]
        //public async Task<IActionResult> PutContact(int id, [FromBody] Contact contact)
        //{
        //    //validate contact with this id exists
        //    //var customer = await _context.Contacts.FindAsync(customerId);
        //    //if (customer == null)
        //    //{
        //    //    return NotFound("Customer not found");
        //    //}
        //    var existingContact = await _context.Contacts.FindAsync(id);
        //    if (existingContact == null)
        //    {
        //        return NotFound("Contact not found");
        //    }
        //    existingContact.LastName = contact.LastName;
        //    existingContact.MiddleName = contact.MiddleName;
        //    existingContact.FirstName = contact.FirstName; 
        //    existingContact.Email = contact.Email;
        //    existingContact.PhoneNum = contact.PhoneNum;               
        //    existingContact.Address = contact.Address;
        //    existingContact.EmerName = contact.EmerName;
        //    existingContact.EmerPhoneNum = contact.EmerPhoneNum; 
        //    existingContact.DOB = contact.DOB;
        //    existingContact.LegalRep = contact.LegalRep;
        //    existingContact.AdditionalNote = contact.AdditionalNote;
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}
        #endregion

        //post to initially create all info of contact
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


    }
}