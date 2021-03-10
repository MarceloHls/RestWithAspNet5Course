using _03_RestWithAspNetCore_Person.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using _03_RestWithAspNetCore_Person.Model.Context;

namespace _03_RestWithAspNetCore_Person.Repository.Implementations
{
    public class PersonRepositoryImplementation : IPersonRepository


    {
        public MySQLContext _context;
        public PersonRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

            return person;
        }

        public void Delete(long Id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.ID.Equals(Id));
            if (result != null)
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long ID)
        {
            return _context.Persons.SingleOrDefault(p => p.ID.Equals(ID));
        }

       

        public Person Update(Person person)
        {
         
            var result = _context.Persons.SingleOrDefault(p => p.ID.Equals(person.ID));
            if(result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }else { return null; }
                       
            return person;
        }

    }
}
