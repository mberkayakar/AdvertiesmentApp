namespace Common
{
    public interface IResponse <T> : IResponse
    {
        T Data { get; set; }
        public List<CostumValidationError> ValidationErrors { get; set; }
    }
}
