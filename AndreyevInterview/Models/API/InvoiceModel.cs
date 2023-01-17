using System.Collections.Generic;


namespace AndreyevInterview.Models.API
{
    public class InvoiceModel
    {
        public List<Invoices> Invoices { get; set; }
        //public int Id { get; set; }
        //public string Description { get; set; }
        //public decimal TotalBillableValue { get; set; }
    }

    public class Invoices
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public virtual Contact Contacts { get; set; }
        public string Description { get; set; }
        public decimal TotalValue { get; set; }
        public decimal TotalBillableValue { get; set; }
        public decimal TotalNumberLineItems { get; set; }
    }
}
