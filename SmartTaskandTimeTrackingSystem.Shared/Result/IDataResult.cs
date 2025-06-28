namespace SmartTaskandTimeTrackingSystem.Shared.Result
{
    public interface IDataResult<T> : IResult
    {
        T? Data { get; }

    }
}
