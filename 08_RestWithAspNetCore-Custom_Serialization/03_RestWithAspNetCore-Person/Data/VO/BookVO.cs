using _03_RestWithAspNetCore_Person.Model.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Data.VO
{
       public class BookVO
    {
        [JsonPropertyName("Codigo")]
        public long ID { get; set; }

        [JsonPropertyName("Titulo")]
        public string Title { get; set; }

        [JsonPropertyName("Autor")]
        public string Autor { get; set; }

        [JsonPropertyName("Ano")]
        public string Year { get; set; }

        [JsonPropertyName("Data")]
        public DateTime Data { get; set; }

    }
}
