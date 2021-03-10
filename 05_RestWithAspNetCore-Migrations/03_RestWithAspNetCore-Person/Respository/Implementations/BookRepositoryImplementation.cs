using _03_RestWithAspNetCore_Person.Model;
using _03_RestWithAspNetCore_Person.Model.Context;
using _03_RestWithAspNetCore_Person.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Respository.Implementations
{
    public class BookRepositoryImplementation : IBookRepository

    {
        public MySQLContext _context;

        public BookRepositoryImplementation (MySQLContext context)
        {
            _context = context;
        }

        public Book Create(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();
            return book;
        }

        public void Delete(long Id)
        {
            var result = FindById(Id);
            if (result != null)
            {
                _context.Remove(result);
                _context.SaveChanges();
            }
        }

        public List<Book> FindAll()
        {
            return _context.Books.ToList();
        }

        public Book FindById(long ID)
        {
          return _context.Books.SingleOrDefault(p => p.ID.Equals(ID));
        }

        public Book Update(Book book)
        {
            var result = FindById(book.ID);
            if(result != null)
            {
                _context.Entry(result).CurrentValues.SetValues(book);
                _context.SaveChanges();
            }
            else { return null; }
            return book;
        }
    }
}
