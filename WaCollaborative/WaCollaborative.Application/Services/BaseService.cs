using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WaCollaborative.Common.Responses;
using WaCollaborative.Common.Utils;
using WaCollaborative.Infrastructure.Repositories;

namespace WaCollaborative.Application.Services
{
    public class BaseService<TDTO, TEntity> : IBaseService<TDTO, TDTO>
        where TDTO : class
        where TEntity : class
    {
        public IMapper _mapper;
        private IBaseRepository<TEntity> _repository { get; set; }

        public BaseService(IBaseRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<TDTO>> GetAsync()
        {
            IEnumerable<TEntity> resultEntity = await _repository.GetAsync();
            return _mapper.Map<IEnumerable<TDTO>>(resultEntity);
        }

        public async Task<TDTO> GetAsync(int id)
        {
            TEntity resultEntity = await _repository.GetAsync(id);
            return _mapper.Map<TDTO>(resultEntity);
        }

        public async Task<Response<TDTO>> AddAsync(TDTO dto)
        {
            TEntity entity = _mapper.Map<TEntity>(dto);
            try
            {
                TEntity resultEntity = await _repository.AddAsync(entity);
                TDTO resultDto = _mapper.Map<TDTO>(resultEntity);

                return new Response<TDTO>
                {
                    WasSuccess = true,
                    Result = resultDto
                };
            }
            catch (DbUpdateException dbUpdateException)
            {
                return ExceptionResponses<TDTO>.DbUpdateExceptionResponse(dbUpdateException);
            }
            catch (Exception exception)
            {
                return ExceptionResponses<TDTO>.ExceptionResponse(exception);
            }
        }

        public async Task<Response<TDTO>> UpdateAsync(TDTO dto)
        {
            TEntity entity = _mapper.Map<TEntity>(dto);
            try
            {
                TEntity resultEntity = await _repository.UpdateAsync(entity);
                TDTO resultDto = _mapper.Map<TDTO>(resultEntity);

                return new Response<TDTO>
                {
                    WasSuccess = true,
                    Result = resultDto
                };
            }
            catch (DbUpdateException dbUpdateException)
            {
                return ExceptionResponses<TDTO>.DbUpdateExceptionResponse(dbUpdateException);
            }
            catch (Exception exception)
            {
                return ExceptionResponses<TDTO>.ExceptionResponse(exception);
            }
        }
    }
}