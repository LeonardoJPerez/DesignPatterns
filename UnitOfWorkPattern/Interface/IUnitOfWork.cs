using RepositoryPattern;
using RepositoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkPattern
{
    public interface IUnitOfWork<TModel>: IDisposable
    {
        IDbContext Context { get; }

        IRepository<TModel> Repository { get; }

        int Commit();
    }
}
