namespace MyCar.Infrastructure.Request
{
    public class GetAllAdvertsRequest : PaginationRequest
    {
        public int? CategoryId { get; set; }
        public decimal? Price { get; set; }
        public string Gear { get; set; }
        public string Fuel { get; set; }
        public string SortOrder { get; set; }
    }
}
