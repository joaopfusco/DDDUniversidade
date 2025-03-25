using DDDUniversidade.Domain.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DDDUniversidade.Infra.Interfaces
{
    public interface IBaseRepository<TModel> where TModel : BaseModel
    {
        IQueryable<TModel> Get(Expression<Func<TModel, bool>>? predicate = null);

        IQueryable<TModel> Get(int id);

        int Insert(TModel model);

        int Update(TModel model);

        int Delete(int id);
    }
}
