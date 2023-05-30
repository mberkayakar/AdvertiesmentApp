using static Common.ResponseEnumType;
namespace Common
{
    public class Response<T> : Response , IResponse<T>
    {
        public T Data { get; set; } 
        public List <CostumValidationError> ValidationErrors { get; set; }  
        public Response(ResponseType _responseType, string Message ) : base(_responseType,Message)
        {

        }
        public Response(ResponseType _responseType, T data) : base(_responseType)
        {
            Data = data;
        }
        public Response(ResponseType _responseType, T data, List<CostumValidationError> _costumValidationErrors) : base(_responseType)
        {
            Data = data;
            ValidationErrors = _costumValidationErrors;
        }
    }
}
