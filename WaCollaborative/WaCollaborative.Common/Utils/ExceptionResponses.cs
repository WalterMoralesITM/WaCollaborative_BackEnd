using Microsoft.EntityFrameworkCore;
using WaCollaborative.Common.Responses;

namespace WaCollaborative.Common.Utils
{
    public static class ExceptionResponses<TDTO> where TDTO : class
    {
        public static Response<TDTO> DbUpdateExceptionResponse(DbUpdateException dbUpdateException)
        {
            if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
            {
                return new Response<TDTO>
                {
                    WasSuccess = false,
                    Message = "Ya existe el registro que estas intentando crear."
                };
            }
            else
            {
                return new Response<TDTO>
                {
                    WasSuccess = false,
                    Message = dbUpdateException.InnerException.Message
                };
            }
        }

        public static Response<TDTO> ExceptionResponse(Exception exception)
        {
            return new Response<TDTO>
            {
                WasSuccess = false,
                Message = exception.Message
            };
        }
    }
}