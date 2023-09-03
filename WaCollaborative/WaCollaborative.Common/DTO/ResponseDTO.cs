namespace WaCollaborative.Common.DTO
{
    /// <summary>
    /// The class ResponseDTO
    /// </summary>

    public class ResponseDTO<T>
    {

        #region Atributos

        public int Code { get; set; }
        public string Message { get; set; }
        public T Response { get; set; }

        #endregion Attributes

    }
}