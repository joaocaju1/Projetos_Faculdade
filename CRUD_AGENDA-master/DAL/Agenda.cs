using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DAL

{
    public class Agenda
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Nome { get; set; } = String.Empty;
        public string Endereco { get; set; } = String.Empty ;
        public string Telefone { get; set; } = String .Empty ;
    }

 

}
