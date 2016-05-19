using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepositoryPattern
{
    public interface IRepository<TModel>
    {
        TModel Get(string id);

        IEnumerable<TModel> Get(Expression<Func<TModel, bool>> filterExpression);

        string Save(TModel item);

        bool Delete(string id);
    }
}