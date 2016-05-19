using System;

namespace UnitOfWorkPattern
{
    public class DbContext : IDbContext
    {
        public bool Save<T>(T item)
        {
            if (item == null) { return false; }

            Console.WriteLine("Element Saved!!");
            return true;
        }
    }
}