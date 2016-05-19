using RepositoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepositoryPattern.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        public bool Delete(string id)
        {
            Console.WriteLine($"Element {id} deleted!");
            return true;
        }

        public IEnumerable<Customer> Get(Expression<Func<Customer, bool>> filterExpression)
        {
            return new List<Customer>
            {
                new Customer {Id = Guid.NewGuid().ToString("N")},
                new Customer {Id = Guid.NewGuid().ToString("N")},
                new Customer {Id = Guid.NewGuid().ToString("N")},
                new Customer {Id = Guid.NewGuid().ToString("N")},
            };
        }

        public Customer Get(string id)
        {
            return new Customer() { Id = id };
        }

        public string Save(Customer item)
        {
            item.Id = new Guid().ToString("N");
            Console.WriteLine($"Element [Id={item.Id}] saved!");

            return item.Id;
        }
    }
}