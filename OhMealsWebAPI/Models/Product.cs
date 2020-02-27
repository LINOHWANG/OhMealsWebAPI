using System;
using System.Collections.Generic;

namespace OhMealsWebAPI.Models
{
    public partial class Product
    {
        public int? PosProdId { get; set; }
        public string SiteCode { get; set; }
        public string ProductName { get; set; }
        public string SecondName { get; set; }
        public int? ProductTypeId { get; set; }
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
        public bool? IsSoldOut { get; set; }
        public DateTime? SyncDate { get; set; }
        public int? SpiceLevel { get; set; }
    }
}
