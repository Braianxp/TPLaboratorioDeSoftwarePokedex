using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Infraestructura.ModelosMongoDB
{
    public class PokemonModelo
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]

        public string Id { get; set; }

        [BsonElement("nombre")]

        public string Nombre { get; set; }

        [BsonElement("orden")]

        public int Orden { get; set; }

        [BsonElement("tipo")]

        public String Tipo { get; set; }

        [BsonElement("evolucion")]

        public String Evolucion { get; set; }

        [BsonElement("habilidad")]

        public String Habilidad { get; set; }
    }
}
