using _03_RestWithAspNetCore_Person.Data.Converter.Contract;
using _03_RestWithAspNetCore_Person.Data.VO;
using _03_RestWithAspNetCore_Person.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_RestWithAspNetCore_Person.Data.Converter.Implementations
{
    public class BookConverter : IParse<BookVO, Book>, IParse<Book, BookVO>
    {
        public BookVO Parse(Book origem)
        {
            if (origem == null) return null;
            return new BookVO
            {
                Autor = origem.Autor,
                Title = origem.Title,
                Year = origem.Year,
                ID = origem.ID,
                Data = new DateTime()
                
            };
        }

        public List<BookVO> Parse(List<Book> origem)
        {
            if (origem == null) return null;
            return origem.Select(o => Parse(o)).ToList();
        }

        public Book Parse(BookVO origem)
        {
            if (origem == null) return null;
            return new Book
            {
                Autor = origem.Autor,
                Title = origem.Title,
                Year = origem.Year,
                ID = origem.ID
               
                
            };
        }

        public List<Book> Parse(List<BookVO> origem)
        {
            if (origem == null) return null;
            return origem.Select(o => Parse(o)).ToList();
        }
    }
}
