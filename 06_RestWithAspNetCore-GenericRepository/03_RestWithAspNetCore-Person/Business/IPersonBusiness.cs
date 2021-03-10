using _03_RestWithAspNetCore_Person.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Business
{
   public interface IPersonBusiness
    {
        Person Create(Person person);
        Person Update(Person person);

        List<Person> FindAll();
        Person FindById(long ID);
        void Delete(long Id);
    }
}
