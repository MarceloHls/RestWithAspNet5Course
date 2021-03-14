using _03_RestWithAspNetCore_Person.Data.VO;
using System.Collections.Generic;

namespace _03_RestWithAspNetCore_Person.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO Update(PersonVO person);

        List<PersonVO> FindAll();
        PersonVO FindById(long ID);
        void Delete(long Id);
    }
}
