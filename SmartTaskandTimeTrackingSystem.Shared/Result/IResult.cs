namespace SmartTaskandTimeTrackingSystem.Shared.Result
{
    public interface IResult
    {
        public bool IsSuccess { get; }
        public string Message { get;  }
    }
}
