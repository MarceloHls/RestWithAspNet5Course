using _03_RestWithAspNetCore_Person.Model;
using _03_RestWithAspNetCore_Person.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
       private readonly IRepository<Book> _repository;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
        }
        public Book Create(Book book)
        {
            return _repository.Create(book);
            
        }

        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindById(long ID)
        {
            return _repository.FindById(ID);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }
    }
}
