using _03_RestWithAspNetCore_Person.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Data.VO
{
       public class BookVO
    {
        public long ID { get; set; }
        public string Title { get; set; }               
        public string Autor { get; set; }              
        public string Year { get; set; }

        public DateTime Data { get; set; }

    }
}
