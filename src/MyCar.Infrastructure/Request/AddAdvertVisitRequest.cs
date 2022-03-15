using System;

namespace MyCar.Infrastructure.Request
{
    public class AddAdvertVisitRequest
    {
        public int? AdvertId { get; set; }
        public string IpAdress { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
