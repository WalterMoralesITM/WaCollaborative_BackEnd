namespace WaCollaborative.Application.Common.CustomEntities
{

    /// <summary>
    /// The class PageCustom
    /// </summary>

    public class PageCustom
    {

        #region Attributes

        public int TotalCount { get; set; }

        public int PageSize { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        #endregion Attributes

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public PageCustom()
        {
        }

        #endregion Constructor

    }
}