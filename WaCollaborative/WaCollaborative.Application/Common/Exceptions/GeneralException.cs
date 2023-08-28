namespace WaCollaborative.Application.Common.Exceptions
{
    /// <summary>
    /// The clase GeneralException
    /// </summary>

    public class GeneralException : Exception
    {

        #region Methods

        /// <summary>
        /// Constructor Default
        /// </summary>
        public GeneralException()
        {}

        /// <summary>
        /// Constructor with Message
        /// </summary>
        public GeneralException(string message) : base(message)
        {}

        #endregion Methods

    }
}