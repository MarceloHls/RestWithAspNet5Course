using _03_RestWithAspNetCore_Person.Data.VO;
using System.Collections.Generic;

namespace _03_RestWithAspNetCore_Person.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO Update(BookVO book);

        List<BookVO> FindAll();
        BookVO FindById(long ID);
        void Delete(long Id);
    }
}
