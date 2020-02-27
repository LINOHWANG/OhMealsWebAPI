using System;
using System.Collections.Generic;

namespace OhMealsWebAPI.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string SiteCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Zip { get; set; }
        public string DateMarried { get; set; }
        public string DateOfBirth { get; set; }
        public string Memo { get; set; }
        public int? WebId { get; set; }
        public string Email { get; set; }
    }
}
