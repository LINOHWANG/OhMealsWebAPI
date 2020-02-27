using System;
using System.Collections.Generic;

namespace OhMealsWebAPI.Models
{
    public partial class Site
    {
        public string SiteCode { get; set; }
        public string SiteName { get; set; }
        public string SiteAddress { get; set; }
        public string SitePhoneNumber { get; set; }
        public string SiteGstnumber { get; set; }
        public DateTime? SiteCreatedDttm { get; set; }
        public bool? SiteLive { get; set; }
        public string SiteBizHourStart { get; set; }
        public string SiteBizHourFinish { get; set; }
        public string SiteBizHourLastCallHour { get; set; }
        public string SiteBizBreakStart { get; set; }
        public string SiteBizBreakFinish { get; set; }
        public string MainSiteCode { get; set; }
    }
}
