using _03_RestWithAspNetCore_Person.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using _03_RestWithAspNetCore_Person.Model.Context;
using _03_RestWithAspNetCore_Person.Repository;

namespace _03_RestWithAspNetCore_Person.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness


    {
        public readonly IRepository<Person> _repository;
        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long ID)
        {
            return _repository.FindById(ID);
}

       

        public Person Update(Person person)
        {
         
            return _repository.Update(person);
        }

    }
}
