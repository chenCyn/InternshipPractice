using System;
using System.Collections.Generic;

namespace AndreyevInterview.Models.API
{
    public class ContactInput
    {
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        //public string EmerName { get; set; }
        //public string EmerPhoneNum { get; set; }
        public string PaymentInfo { get; set; }
        public string IDNum { get; set; }
        public DateTime DOB { get; set; }
        public string LegalRep { get; set; }
        public string AdditionalNote { get; set; }

    }
}
