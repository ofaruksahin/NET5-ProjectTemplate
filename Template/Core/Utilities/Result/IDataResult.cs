namespace $safeprojectname$.Utilities.Result
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
