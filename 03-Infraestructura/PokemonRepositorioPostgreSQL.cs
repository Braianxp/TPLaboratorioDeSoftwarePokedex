using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _02_Dominio.ValueObject;
using Microsoft.VisualBasic;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _03_Infraestructura
{
    public class PokemonRepositorioPostgreSQL : PokemonRepositorio
    {

        private NpgsqlConnection conex = new NpgsqlConnection();

        static String servidor = "localhost";
        static String bd = "Pokedex";
        static String usuario = "postgres";
        static String password = "1234";
        static String puerto = "5432";

        private String cadenaConexion = "Server = " + servidor + ":" + puerto + ";" + "user id=" + usuario + ";" + "password="+ password + ";" + "database=" + bd + ";";

        public void Registrar(Pokemon pokemon)
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                NpgsqlCommand command = conex.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO Pokemon(id,nombre,orden,tipo,evolucion,habilidad) VALUES (@id,@nombre,@orden,@tipo,@evolucion,@habilidad)";
                command.Parameters.AddWithValue("@id", pokemon.Id());
                command.Parameters.AddWithValue("@nombre", pokemon.Nombre());
                command.Parameters.AddWithValue("@orden", pokemon.Orden());
                command.Parameters.AddWithValue("@tipo", pokemon.Tipo());
                command.Parameters.AddWithValue("@evolucion", pokemon.Evolucion());
                command.Parameters.AddWithValue("@habilidad", pokemon.Habilidad());
                command.ExecuteScalar();
                conex.Close();
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("No se pudo conectar a la base de datos el error es: "+ e.Message);
            }
        }
        public void EliminarPokemon(int orden)
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                NpgsqlCommand command = conex.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE FROM pokemon WHERE orden = @orden";
                command.Parameters.AddWithValue("@orden", orden);
                command.ExecuteScalar();
                conex.Close();
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("No se pudo conectar a la base de datos el error es: " + e.Message);
            }
        }

        public void Modificar(Pokemon pokemon)
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                NpgsqlCommand command = conex.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE pokemon SET nombre = @nombre, orden = @orden, tipo = @tipo, evolucion = @evolucion, habilidad = @habilidad WHERE id = @id";
                command.Parameters.AddWithValue("@id", pokemon.Id());
                command.Parameters.AddWithValue("@nombre", pokemon.Nombre());
                command.Parameters.AddWithValue("@orden", pokemon.Orden());
                command.Parameters.AddWithValue("@tipo", pokemon.Tipo());
                command.Parameters.AddWithValue("@evolucion", pokemon.Evolucion());
                command.Parameters.AddWithValue("@habilidad", pokemon.Habilidad());
                command.ExecuteNonQuery();
                conex.Close();
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("No se pudo conectar a la base de datos el error es: " + e.Message);
            }
        }

        public List<Pokemon> ObtenerPokemones()
        {

            List<Pokemon> pokemones = new List<Pokemon>();

            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                NpgsqlCommand command = conex.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM pokemon ORDER BY orden ASC";
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Pokemon pokemon = new Pokemon((Guid)reader["id"], (string)reader["nombre"], (int)reader["orden"], (string)reader["tipo"], (string)reader["evolucion"], (string)reader["habilidad"]);
                    pokemones.Add(pokemon);

                }
                conex.Close();
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("No se pudo conectar a la base de datos el error es: " + e.Message);
            }

            return pokemones;
        }

        public Pokemon ObtenerPokemonesOrden(int orden)
        {
            Pokemon pokemon = null;

            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                NpgsqlCommand command = conex.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM pokemon WHERE orden = @orden";
                command.Parameters.AddWithValue("@orden", orden);
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    pokemon = new Pokemon((Guid)reader["id"], (string)reader["nombre"], (int)reader["orden"], (string)reader["tipo"], (string)reader["evolucion"], (string)reader["habilidad"]);
                }

                conex.Close();
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("No se pudo conectar a la base de datos el error es: " + e.Message);
            }

            return pokemon;
        }

        
    }
}
