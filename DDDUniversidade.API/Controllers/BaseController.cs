using System.Net;
using DDDUniversidade.API.Extensions;
using DDDUniversidade.Domain.Models;
using DDDUniversidade.Infra.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.Extensions.Logging;

namespace DDDUniversidade.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<TModel>(IBaseRepository<TModel> repository, ILogger logger) : Controller where TModel : BaseModel
    {
        protected readonly IBaseRepository<TModel> _repository = repository;
        protected readonly ILogger _logger = logger;

        [EnableQuery]
        [HttpGet]
        public virtual IActionResult Get()
        {
            return TryExecute(() =>
            {
                return Ok(_repository.Get());
            });
        }

        [HttpGet("{id}")]
        public virtual IActionResult GetById(int id)
        {
            return TryExecute(() =>
            {
                return Ok(_repository.Get(id).FirstOrDefault());
            });
        }

        [HttpPost]
        public virtual IActionResult Post([FromBody] TModel model)
        {
            return TryExecute(() =>
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                _repository.Insert(model);
                return Ok(model);
            });
        }

        [HttpPut("{id}")]
        public virtual IActionResult Put(int id, [FromBody] TModel model)
        {
            return TryExecute(() =>
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                model.Id = id;
                _repository.Update(model);
                return Ok(model);
            });
        }

        [HttpDelete("{id}")]
        public virtual IActionResult Delete(int id)
        {
            return TryExecute(() =>
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                _repository.Delete(id);
                return Ok(id);
            });
        }

        [NonAction]
        protected virtual IActionResult TryExecute(Func<IActionResult> execute)
        {
            try
            {
                return execute();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message, ex.InnerException);
                return BadRequest(ex);
            }
        }
    }
}
