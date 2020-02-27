using System;
using System.Collections.Generic;

namespace OhMealsWebAPI.Models
{
    public partial class Ootransaction
    {
        public int Id { get; set; }
        public string SiteCode { get; set; }
        public string TransactionId { get; set; }
        public int? CustomerId { get; set; }
        public string Phone { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Buzzer { get; set; }
        public string Memo { get; set; }
        public bool? IsDelivery { get; set; }
        public string OrderDate { get; set; }
        public string OrderTime { get; set; }
        public string PickUpDate { get; set; }
        public string PickUpTime { get; set; }
        public bool? IsPaid { get; set; }
        public double? Amount { get; set; }
        public double? Tax1 { get; set; }
        public double? Tax2 { get; set; }
        public double? Tax3 { get; set; }
        public double? TotalDue { get; set; }
        public double? TotalPaid { get; set; }
        public int? IsPosupdated { get; set; }
        public string PayType { get; set; }
    }
}
