using System;

namespace AndreyevInterview.Models.API
{
    public class InvoiceInput
    {
        public int ContactId { get; set; }
        public string Description { get; set; }
        public string LegalRep { get; set; }
    }
}
