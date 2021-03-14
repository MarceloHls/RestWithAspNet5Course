using _03_RestWithAspNetCore_Person.Model;
using System.Collections.Generic;
using _03_RestWithAspNetCore_Person.Repository;
using _03_RestWithAspNetCore_Person.Data.Converter.Implementations;
using _03_RestWithAspNetCore_Person.Data.VO;

namespace _03_RestWithAspNetCore_Person.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness


    {
        public readonly IRepository<Person> _repository;
        public readonly PersonConverter _converter;
        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            var personVo = _converter.Parse(personEntity);
            return personVo;
        }

        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        public List<PersonVO> FindAll()
        {
            var listPersonEntity = _repository.FindAll();
            var listPersonVo = _converter.Parse(listPersonEntity);
            return listPersonVo;
        }

        public PersonVO FindById(long ID)
        {
            var personEntity = _repository.FindById(ID);
            var personVo = _converter.Parse(personEntity);
            return personVo;
        }

       

        public PersonVO Update(PersonVO person)
        {

            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            var personVo = _converter.Parse(personEntity);
            return personVo;
        }

    }
}
