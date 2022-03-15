namespace MyCar.Infrastructure.Response
{
    public interface IResult
    {
        public bool IsSuccess { get; set; }

        public string MessageCode { get; set; }

        public string[] Messages { get; set; }
    }
}
