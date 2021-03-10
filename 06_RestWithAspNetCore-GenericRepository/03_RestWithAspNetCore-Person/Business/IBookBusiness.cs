using _03_RestWithAspNetCore_Person.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Business
{
   public interface IBookBusiness
    {
        Book Create(Book book);
        Book Update(Book book);

        List<Book> FindAll();
        Book FindById(long ID);
        void Delete(long Id);
    }
}
