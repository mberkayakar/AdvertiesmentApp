using static Common.ResponseEnumType;

namespace Common;

public interface IResponse
{
    string Message {get ; set;} 
    ResponseType ResponseType {get; set;}
}
