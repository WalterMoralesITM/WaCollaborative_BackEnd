using Microsoft.AspNetCore.Mvc;
using WaCollaborative.Application.Services;

namespace WaCollaborative.API.Controllers
{
    public class BaseController<TDTO, TEntity> : Controller where TDTO : class where TEntity : class
    {
        private IBaseService<TDTO, TDTO> _service;

        public BaseController(IBaseService<TDTO, TDTO> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _service.GetAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var row = await _service.GetAsync(id);
            if (row == null)
            {
                return NotFound();
            }
            return Ok(row);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(TDTO model)
        {
            var result = await _service.AddAsync(model);
            if (result.WasSuccess)
            {
                return Ok(result.Result);
            }
            return BadRequest(result.Message);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(TDTO model)
        {
            var result = await _service.UpdateAsync(model);
            if (result.WasSuccess)
            {
                return Ok(result.Result);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var row = await _service.GetAsync(id);
            if (row == null)
            {
                return NotFound();
            }
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}