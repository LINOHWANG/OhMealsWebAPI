using System;
using System.Collections.Generic;

namespace OhMealsWebAPI.Models
{
    public partial class Ooitem
    {
        public int Id { get; set; }
        public string SiteCode { get; set; }
        public string TransactionId { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public string SecondName { get; set; }
        public double? UnitPrice { get; set; }
        public bool? IsTax1 { get; set; }
        public bool? IsTax2 { get; set; }
        public bool? IsTax3 { get; set; }
        public bool? IsTaxInverseCalculation { get; set; }
        public string PromoStartDate { get; set; }
        public string PromoEndDate { get; set; }
        public short? PromoDay1 { get; set; }
        public short? PromoDay2 { get; set; }
        public short? PromoDay3 { get; set; }
        public double? PromoPrice1 { get; set; }
        public double? PromoPrice2 { get; set; }
        public double? PromoPrice3 { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public double? Amount { get; set; }
        public double? Tax1Rate { get; set; }
        public double? Tax2Rate { get; set; }
        public double? Tax3Rate { get; set; }
        public double? Tax1 { get; set; }
        public double? Tax2 { get; set; }
        public double? Tax3 { get; set; }
    }
}
