using System;
using System.Collections.Generic;

namespace OhMealsWebAPI.Models
{
    public partial class MainSite
    {
        public string MainSiteCode { get; set; }
        public string MainSiteName { get; set; }
        public string MainSiteAddress { get; set; }
        public string MainSitePhoneNumber { get; set; }
        public string MainSiteGstnumber { get; set; }
        public DateTime? MainSiteCreatedDttm { get; set; }
        public bool? MainSiteLive { get; set; }
    }
}
