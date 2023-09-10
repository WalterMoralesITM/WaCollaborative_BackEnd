namespace WaCollaborative.Common.Responses
{
    public class Response<TDto>
    {
        public bool WasSuccess { get; set; }

        public string? Message { get; set; }

        public TDto? Result { get; set; }
    }
}