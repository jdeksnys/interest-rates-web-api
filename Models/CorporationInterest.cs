using System;

namespace interest_web_api.Models
{
    public class CorporationInterest
    {
        public long Id { get; set; }
        public string? Period { get; set; }
        public double Total { get; set; }
        public double UpToMillion { get; set; }
        public double OverMillion { get; set; }
    }
}