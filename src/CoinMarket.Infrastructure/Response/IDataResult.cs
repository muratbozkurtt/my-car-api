namespace CoinMarker.Infrastructure.Response
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
