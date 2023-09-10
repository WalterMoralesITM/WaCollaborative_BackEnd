using WaCollaborative.Common.Responses;

namespace WaCollaborative.Application.Services
{
    public interface IBaseService<TDTO, TDTOF>
        where TDTO : class
    {
        Task<IEnumerable<TDTO>> GetAsync();

        Task<TDTO> GetAsync(int id);

        Task<Response<TDTO>> AddAsync(TDTO dto);

        Task<Response<TDTO>> UpdateAsync(TDTO dto);

        Task DeleteAsync(int id);
    }
}