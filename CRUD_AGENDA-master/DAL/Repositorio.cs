using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repositorio
    {
        private IMongoCollection<Agenda> _agenda;

        public List<Agenda> ListaAgenda
        {
            get {
                var filter = Builders<Agenda>.Filter.Empty;
                return _agenda.Find<Agenda>(filter).ToList<Agenda>(); }
        }

        public void Create(Agenda agenda)
        {
            _agenda.InsertOne(agenda);
        }

        public void Delete(Agenda agenda)
        {
            var filter = Builders<Agenda>.Filter.Eq("Id", agenda.Id);
            _agenda.DeleteOne(filter);

        }

        public void Udpate (Agenda agenda)
        {
            var filter = Builders<Agenda>.Filter.Eq("Id", agenda.Id);
            var update = Builders<Agenda>.Update.Set("Nome", agenda.Nome).Set("Telefone", agenda.Telefone).Set("Endereco", agenda.Endereco);
        }

        public Repositorio()
        {
            var MongoClient = new MongoClient("mongodb+srv://henrique216914:Fdchenry101@cluster0.mjh74e2.mongodb.net/?retryWrites=true&w=majority");
            var mongoDatabase = MongoClient.GetDatabase("AppDeskTop");
            _agenda = mongoDatabase.GetCollection<Agenda>("Agenda");

        }
    }
   
}

