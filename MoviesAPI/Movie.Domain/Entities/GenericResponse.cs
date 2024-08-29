namespace Movie.Domain.Entities
{
    public class GenericResponse<T>
    {
        public GenericResponse(T data, string message = null)
        {
            Success = (int)EProgrammingState.Success;
            Message = message;
            Data = data;
        }

        public GenericResponse(string message = null)
        {
            Success = (int)EProgrammingState.Error;
            Message = message;
        }

        public GenericResponse(int programmingState, string message = null)
        {
            Success = programmingState;
            Message = message;
        }

        public int Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }

    public enum EProgrammingState
    {
        Error = 0,
        Success = 1,
        Info = 2,
        Warning = 3
    }

}
