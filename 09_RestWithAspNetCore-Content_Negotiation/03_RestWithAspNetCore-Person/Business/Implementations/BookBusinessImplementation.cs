using _03_RestWithAspNetCore_Person.Data.Converter.Implementations;
using _03_RestWithAspNetCore_Person.Data.VO;
using _03_RestWithAspNetCore_Person.Model;
using _03_RestWithAspNetCore_Person.Repository;
using System.Collections.Generic;

namespace _03_RestWithAspNetCore_Person.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
       private readonly IRepository<Book> _repository;
        public readonly BookConverter _converter;


        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }
        public BookVO Create(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            var bookVo = _converter.Parse(bookEntity);
            return bookVo;
            
        }

        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        public List<BookVO> FindAll()
        {
            var listBookEntity = _repository.FindAll();
            var listBookVo = _converter.Parse(listBookEntity);
            return listBookVo;
        }

        public BookVO FindById(long ID)
        {
            var bookEntity = _repository.FindById(ID);
            var bookVo = _converter.Parse(bookEntity);
            return bookVo;
        }

        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            var bookVo = _converter.Parse(bookEntity);
            return bookVo;
        }
    }
}
