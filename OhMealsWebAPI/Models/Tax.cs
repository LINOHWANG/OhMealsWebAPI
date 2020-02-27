using System;
using System.Collections.Generic;

namespace OhMealsWebAPI.Models
{
    public partial class Tax
    {
        public string PosCode { get; set; }
        public string SiteCode { get; set; }
        public double? Tax1 { get; set; }
        public double? Tax2 { get; set; }
        public double? Tax3 { get; set; }
    }
}
