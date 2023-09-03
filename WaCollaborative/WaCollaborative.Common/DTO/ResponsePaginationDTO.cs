namespace WaCollaborative.Common.DTO
{
    /// <summary>
    /// The class ResponsePaginationDTO
    /// </summary>

    public class ResponsePaginationDTO<T>
    {

        #region Attributes

        public int Code { get; set; }
        public string Message { get; set; }
        public PaginationDTO Pagination { get; set; }
        public T Response { get; set; }

        #endregion Attributes

    }
}