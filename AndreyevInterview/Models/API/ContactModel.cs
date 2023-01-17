using System.Collections.Generic;

namespace AndreyevInterview.Models.API
{
    public class ContactModel
    {
        public List<Invoices> Invoices { get; set; }

    }
    public class Contacts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal NumInvoices { get; set; }
        public decimal TotalBillable { get; set; }
        public decimal TotalPaid { get; set; }

    }
}
