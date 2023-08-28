namespace WaCollaborative.API.Response
{

    #region Import

    using WaCollaborative.Application.Common.CustomEntities;

    #endregion Import

    /// <summary>
    /// The class ApiResponseBase
    /// </summary>

    public class ApiResponseBase<T>
    {

        #region Attributes

        public string ErrorMessage { get; set; }

        public bool IsError { get; set; }

        public bool IsSuccessful { get; set; }

        public IEnumerable<string> Messages { get; set; }

        public PageCustom PageCustom { get; set; }

        public T Result { get; set; }

        #endregion Attributes

    }
}