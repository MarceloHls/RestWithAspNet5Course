using _03_RestWithAspNetCore_Person.Data.Converter.Contract;
using _03_RestWithAspNetCore_Person.Data.VO;
using _03_RestWithAspNetCore_Person.Model;
using System.Collections.Generic;
using System.Linq;

namespace _03_RestWithAspNetCore_Person.Data.Converter.Implementations
{
    public class PersonConverter : IParse<PersonVO, Person>, IParse<Person, PersonVO>
    {
        public Person Parse(PersonVO origem)
        {
            if (origem == null) return null;
            return new Person
            {
                FirstName = origem.FirstName,
                LastName = origem.LastName,
                Gender = origem.Gender,
                ID = origem.ID
            };
        }

        public List<Person> Parse(List<PersonVO> origem)
        {
            if (origem == null) return null;
            return origem.Select(o => Parse(o)).ToList();
        }

        public PersonVO Parse(Person origem)
        {
            if (origem == null) return null;
            return new PersonVO
            {
                FirstName = origem.FirstName,
                LastName = origem.LastName,
                Gender = origem.Gender,
                ID = origem.ID
            };
        }

        public List<PersonVO> Parse(List<Person> origem)
        {
            if (origem == null) return null;
            return origem.Select(o => Parse(o)).ToList();
        }
    }
}
