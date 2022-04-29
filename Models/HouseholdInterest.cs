using System;

namespace interest_web_api.Models
{
    public class HouseholdInterest
    {
        public long Id { get; set; }
        public string? Period { get; set; }
        public double Total { get; set; }
        public double ForConsumption { get; set; }
        public double ForHousePurchase { get; set; }
        public double ForOtherPurposes { get; set; }
    }
}
