using _03_RestWithAspNetCore_Person.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {

        [Column("title")]
        public string Title { get; set; }

        [Column("autor")]
        public string Autor { get; set; }

        [Column("year")]
        public string Year { get; set; }


    }
}
