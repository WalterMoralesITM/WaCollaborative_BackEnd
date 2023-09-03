namespace WaCollaborative.Common.DTO
{

    /// <summary>
    /// The class PaginationDTO
    /// </summary>

    public class PaginationDTO
    {

        #region Attributes

        public int Page { get; set; }
        public int RecordPage { get; set; }
        public int CountRecord { get; set; }
        public string Ordering { get; set; }

        #endregion Attributes

    }
}