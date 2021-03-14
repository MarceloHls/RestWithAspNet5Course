using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Model.Base
{
    public class BaseEntity
    {

        [Column("id")]
        public long ID { get; set; }
    }
}
