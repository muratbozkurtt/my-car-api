using System;

namespace CoinMarker.Infrastructure.Entity
{
    public class AdvertVisit
    {
        public int Id { get; set; }
        public int AdvertId { get; set; }
        public string IpAddress { get; set; }
        public DateTime DateTime { get; set; }
    }
}
