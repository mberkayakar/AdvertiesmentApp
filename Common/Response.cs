using System.Threading.Tasks.Sources;
using static Common.ResponseEnumType;

namespace Common;

public class Response : IResponse
{
    public Response(ResponseType _responseType)
    {
        ResponseType = _responseType;
    }
    public Response(ResponseType _responseType, string _message )
    {
        ResponseType = _responseType;
        Message = _message;
    }


    public string Message { get; set; }
    public ResponseType ResponseType {get ; set;}
}


