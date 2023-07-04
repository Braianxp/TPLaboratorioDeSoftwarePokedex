using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _03_Infraestructura.ModelosMongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Infraestructura
{
    public class PokemonRepositorioMongoDB : PokemonRepositorio
    {

        const string connectionUri = "mongodb+srv://braian:braian1234@cluster0.owmrjjq.mongodb.net/?retryWrites=true&w=majority";
        
        public void Registrar(Pokemon pokemon)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to Stable API version 1
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            var client = new MongoClient(settings);
            
            try
            { 
                var database = client.GetDatabase("Pokedex");

                var pokemonDB = database.GetCollection<PokemonModelo>("Pokemon");

                var pokemonModelo = new PokemonModelo()
                {
                    Id = pokemon.Id().ToString(),
                    Nombre = pokemon.Nombre(),
                    Orden = pokemon.Orden(),
                    Tipo = pokemon.Tipo(),
                    Evolucion = pokemon.Evolucion(),
                    Habilidad = pokemon.Habilidad()
                };

                pokemonDB.InsertOne(pokemonModelo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            
        }
        public void EliminarPokemon(int orden)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to Stable API version 1
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            var client = new MongoClient(settings);

            try
            {
                var database = client.GetDatabase("Pokedex");

                var pokemonDB = database.GetCollection<PokemonModelo>("Pokemon");

                pokemonDB.FindOneAndDelete(d => d.Orden ==orden);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        public void Modificar(Pokemon pokemon)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to Stable API version 1
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            var client = new MongoClient(settings);

            try
            {
                var database = client.GetDatabase("Pokedex");

                var pokemonDB = database.GetCollection<PokemonModelo>("Pokemon");

                var pokemonModelo = new PokemonModelo()
                {
                    Id = pokemon.Id().ToString(),
                    Nombre = pokemon.Nombre(),
                    Orden = pokemon.Orden(),
                    Tipo = pokemon.Tipo(),
                    Evolucion = pokemon.Evolucion(),
                    Habilidad = pokemon.Habilidad()
                };

                pokemonDB.ReplaceOne(d => d.Orden == pokemonModelo.Orden, pokemonModelo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public List<Pokemon> ObtenerPokemones()
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to Stable API version 1
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            var client = new MongoClient(settings);

            List<Pokemon> pokemones = new List<Pokemon>();

            try
            {
                var database = client.GetDatabase("Pokedex");

                var pokemonDB = database.GetCollection<PokemonModelo>("Pokemon");

                List<PokemonModelo> pokemonesModelo = pokemonDB.Find(d => true).ToList();

                

                foreach (var pokemonModelo in pokemonesModelo)
                {
                    Pokemon pokemon = new Pokemon(
                    Guid.Parse(pokemonModelo.Id),
                    pokemonModelo.Nombre,
                    pokemonModelo.Orden,
                    pokemonModelo.Tipo,
                    pokemonModelo.Evolucion,
                    pokemonModelo.Habilidad
                    );

                    pokemones.Add( pokemon );
                }

                
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex);
            }

            return pokemones;
        }

        public Pokemon ObtenerPokemonesOrden(int orden)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to Stable API version 1
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            var client = new MongoClient(settings);

            Pokemon pokemon = null;

            try
            {
                var database = client.GetDatabase("Pokedex");

                var pokemonDB = database.GetCollection<PokemonModelo>("Pokemon");

                List<PokemonModelo> pokemonesModelo = pokemonDB.Find(d => d.Orden == orden).ToList();

                foreach (var pokemonModelo in pokemonesModelo)
                {
                    pokemon = new Pokemon(
                    Guid.Parse(pokemonModelo.Id),
                    pokemonModelo.Nombre,
                    pokemonModelo.Orden,
                    pokemonModelo.Tipo,
                    pokemonModelo.Evolucion,
                    pokemonModelo.Habilidad
                    );
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            return pokemon;
        }

        
    }
}
