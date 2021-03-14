using _03_RestWithAspNetCore_Person.Model.Base;
using _03_RestWithAspNetCore_Person.Model.Context;
using _03_RestWithAspNetCore_Person.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Respository.Genric
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        public MySQLContext _context;

        public DbSet<T> dataset;
        public GenericRepository(MySQLContext context)
        {
            _context = context;
            dataset = context.Set<T>();
        }
        public T Create(T item)
        {
            dataset.Add(item);
            _context.SaveChanges();
            return item;
        }

        public void Delete(long Id)
        {
            var result = FindById(Id);
            if (result != null)
            {
                dataset.Remove(result);
                _context.SaveChanges();
            }
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindById(long ID)
        {
            return dataset.SingleOrDefault(t => t.ID.Equals(ID));
        }

        public T Update(T item)
        {
            var result = FindById(item.ID);
            if (result != null)
            {
                _context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            else { return null; }
            return item;
        }
    }
}
