using _03_RestWithAspNetCore_Person.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Repository
{
   public interface IBookRepository
    {
        Book Create(Book book);
        Book Update(Book book);

        List<Book> FindAll();
        Book FindById(long ID);
        void Delete(long Id);
    }
}
