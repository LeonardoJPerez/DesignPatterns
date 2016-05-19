using RepositoryPattern;
using RepositoryPattern.Model;
using RepositoryPattern.Repositories;
using System;

namespace UnitOfWorkPattern
{
    public class UnitOfWork : IUnitOfWork<Customer>
    {
        public UnitOfWork(IDbContext context)
        {
            Repository = new CustomerRepository();
            Context = new DbContext();
        }

        public IDbContext Context { get; private set; }

        public IRepository<Customer> Repository { get; private set; }

        public int Commit()
        {
            Console.WriteLine("Changes to entities saved!");
            return 1;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}