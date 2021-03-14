using _03_RestWithAspNetCore_Person.Model;
using _03_RestWithAspNetCore_Person.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Repository
{
   public interface IRepository<T> where T:BaseEntity
    {
        T Create(T item);
        T Update(T item);
        List<T> FindAll();
        T FindById(long ID);
        void Delete(long Id);
    }
}
