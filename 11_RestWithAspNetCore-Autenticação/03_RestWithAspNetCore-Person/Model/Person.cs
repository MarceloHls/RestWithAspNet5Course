using _03_RestWithAspNetCore_Person.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace _03_RestWithAspNetCore_Person.Model
{

    [Table("person")]
    public class Person : BaseEntity
    {
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("gender")]
        public string Gender { get; set; }

    }
}
