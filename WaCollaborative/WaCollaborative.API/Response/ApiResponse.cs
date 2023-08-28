namespace WaCollaborative.API.Response
{

    /// <summary>
    /// The class ApiResponse
    /// </summary>

    public class ApiResponse<T> : ApiResponseBase<T>
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public ApiResponse()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="isSuccessful"></param>
        /// <param name="isError"></param>
        /// <param name="errorMessage"></param>
        /// <param name="messages"></param>
        /// <param name="result"></param>
        public ApiResponse(bool isSuccessful, bool isError, string errorMessage, IEnumerable<string> messages, T result)
        {
            IsSuccessful = isSuccessful;
            IsError = isError;
            ErrorMessage = errorMessage;
            Messages = messages;
            Result = result;
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Method CreateSuccessful
        /// </summary>
        /// <param name="result"></param>
        /// <returns>ApiResponse<T></returns>
        public static ApiResponse<T> CreateSuccessful(T result) => new ApiResponse<T>(isSuccessful: true, isError: false, null, null, result);

        /// <summary>
        /// Method CreateSuccessful
        /// </summary>
        /// <param name="result"></param>
        /// <returns>ApiResponse<T></returns>
        public static ApiResponse<T> CreateUnsuccessful(IEnumerable<string> messages) => new ApiResponse<T>(isSuccessful: false, isError: false, null, messages, default);

        /// <summary>
        /// Method CreateError
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <returns>ApiResponse<T></returns>
        public static ApiResponse<T> CreateError(string errorMessage) => new ApiResponse<T>(isSuccessful: false, isError: true, errorMessage, null, default);

        #endregion Methods

    }
}