using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Model
{

    [Table("person")]
    public class Person
    {
        [Column("id")]
        public long ID { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("gender")]
        public string Gender { get; set; }

    }
}
