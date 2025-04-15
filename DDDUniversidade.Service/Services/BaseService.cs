using DDDUniversidade.Service.Interfaces;
using DDDUniversidade.Domain.Models;
using System.Linq.Expressions;
using DDDUniversidade.Infra.Data;
using DDDUniversidade.Infra.Interfaces;
using DDDUniversidade.Infra.Repositories;

namespace DDDUniversidade.Service.Services
{
    public class BaseService<TModel>(IBaseRepository<TModel> repository) : IBaseService<TModel> where TModel : BaseModel
    {
        protected readonly IBaseRepository<TModel> _repostitory = repository;

        public IQueryable<TModel> Get(Expression<Func<TModel, bool>>? predicate = null)
        {
            return _repostitory.Get(predicate);
        }

        public IQueryable<TModel> Get(int id)
        {
            return _repostitory.Get(id);
        }

        public virtual int Insert(TModel model)
        {
            return _repostitory.Insert(model);
        }   

        public virtual int Update(TModel model)
        {
            return _repostitory.Update(model);
        }

        public virtual int Delete(int id)
        {
            return _repostitory.Delete(id);
        }
    }
}
