using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _02_Dominio.ValueObject;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Infraestructura
{
    public class EntrenadorRepositorioPostgreSQL : EntrenadorRepositorio
    {
        private NpgsqlConnection conex = new NpgsqlConnection();

        static String servidor = "localhost";
        static String bd = "Pokedex";
        static String usuario = "postgres";
        static String password = "1234";
        static String puerto = "5432";

        private String cadenaConexion = "Server = " + servidor + ":" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public void Registrar(Entrenador entrenador)
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                NpgsqlCommand command = conex.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO entrenador(id,nombre,origen,liderdegimnasio,medallas) VALUES (@id,@nombre,@origen,@liderdegimnasio,@medallas)";
                command.Parameters.AddWithValue("@id", entrenador.Id());
                command.Parameters.AddWithValue("@nombre", entrenador.Nombre());
                command.Parameters.AddWithValue("@origen", entrenador.Origen());
                command.Parameters.AddWithValue("@liderdegimnasio", entrenador.Lider());
                command.Parameters.AddWithValue("@medallas", entrenador.Medallas());
                command.ExecuteScalar();
                conex.Close();
                foreach (var pokemon in entrenador.PokemonesAtrapados())
                {
                    conex.ConnectionString = cadenaConexion;
                    conex.Open();
                    NpgsqlCommand commando = conex.CreateCommand();
                    commando.CommandType = System.Data.CommandType.Text;
                    commando.CommandText = "INSERT INTO entrenador_pokemon(id,identrenador,idpokemon) VALUES (@id,@identrenador,@idpokemon)";
                    commando.Parameters.AddWithValue("@id", Guid.NewGuid());
                    commando.Parameters.AddWithValue("@identrenador", entrenador.Id());
                    commando.Parameters.AddWithValue("@idpokemon", pokemon.Id());
                    commando.ExecuteScalar();
                    conex.Close();
                }
                
                
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("No se pudo conectar a la base de datos el error es: " + e.Message);
            }
        }
        public void EliminarEntrenador(string nombre)
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                NpgsqlCommand command = conex.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE FROM Entrenador WHERE nombre = @nombre";
                command.Parameters.AddWithValue("@nombre", nombre);
                command.ExecuteScalar();
                conex.Close();
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("No se pudo conectar a la base de datos el error es: " + e.Message);
            }
        }

        public void ModificarEntrenador(Entrenador entrenador)
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                NpgsqlCommand commandoactualizar = conex.CreateCommand();
                commandoactualizar.CommandType = System.Data.CommandType.Text;
                commandoactualizar.CommandText = "UPDATE entrenador SET nombre = @nombre, origen = @origen, liderdegimnasio = @liderdegimnasio, medallas = @medallas WHERE id = @id";
                commandoactualizar.Parameters.AddWithValue("@id", entrenador.Id());
                commandoactualizar.Parameters.AddWithValue("@nombre", entrenador.Nombre());
                commandoactualizar.Parameters.AddWithValue("@origen", entrenador.Origen());
                commandoactualizar.Parameters.AddWithValue("@liderdegimnasio", entrenador.Lider());
                commandoactualizar.Parameters.AddWithValue("@medallas", entrenador.Medallas());
                commandoactualizar.ExecuteNonQuery();
                conex.Close();

                conex.ConnectionString = cadenaConexion;
                conex.Open();
                NpgsqlCommand commandoeliminar = conex.CreateCommand();
                commandoeliminar.CommandType = System.Data.CommandType.Text;
                commandoeliminar.CommandText = "DELETE FROM entrenador_pokemon WHERE identrenador = @identrenador";
                commandoeliminar.Parameters.AddWithValue("@identrenador", entrenador.Id());
                commandoeliminar.ExecuteScalar();
                conex.Close();

                foreach (var pokemon in entrenador.PokemonesAtrapados())
                {
                    conex.ConnectionString = cadenaConexion;
                    conex.Open();
                    NpgsqlCommand commandoinsertar = conex.CreateCommand();
                    commandoinsertar.CommandType = System.Data.CommandType.Text;
                    commandoinsertar.CommandText = "INSERT INTO entrenador_pokemon(id,identrenador,idpokemon) VALUES (@id,@identrenador,@idpokemon)";
                    commandoinsertar.Parameters.AddWithValue("@id", Guid.NewGuid());
                    commandoinsertar.Parameters.AddWithValue("@identrenador", entrenador.Id());
                    commandoinsertar.Parameters.AddWithValue("@idpokemon", pokemon.Id());
                    commandoinsertar.ExecuteScalar();
                    conex.Close();
                }
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("No se pudo conectar a la base de datos el error es: " + e.Message);
            }
        }

        public List<Entrenador> ObtenerEntrenadores()
        {
            List<Entrenador> entrenadores = new List<Entrenador>();

            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                NpgsqlCommand command = conex.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select e.nombre as nombreentrenador, e.origen, e.liderdegimnasio, e.medallas,ep.idpokemon,ep.identrenador,p.nombre as nombrepokemon,p.orden,p.tipo,p.evolucion,p.habilidad FROM entrenador as e inner join entrenador_pokemon as ep on e.id = ep.identrenador inner join pokemon as p on p.id = idpokemon";
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    bool bander = false;

                    for(int i = 0; i< entrenadores.Count();i++)
                    {
                        if (entrenadores[i].Id() == (Guid)reader["identrenador"])
                        {
                            List<Pokemon> listanuevadepokemones = entrenadores[i].PokemonesAtrapados();
                            Pokemon pokemon = new Pokemon((Guid)reader["idpokemon"], (string)reader["nombrepokemon"], (int)reader["orden"], (string)reader["tipo"], (string)reader["evolucion"], (string)reader["habilidad"]);
                            listanuevadepokemones.Add(pokemon);
                            Entrenador entrenador = new Entrenador((Guid)reader["identrenador"], (string)reader["nombreentrenador"], (string)reader["origen"], (bool)reader["liderdegimnasio"], (int)reader["medallas"], listanuevadepokemones);
                            entrenadores[i] = entrenador;
                            bander = true;
                        }
                    }
                    if (!bander)
                    {
                        List<Pokemon> listanuevadepokemones = new List<Pokemon>();
                        Pokemon pokemon = new Pokemon((Guid)reader["idpokemon"], (string)reader["nombrepokemon"], (int)reader["orden"], (string)reader["tipo"], (string)reader["evolucion"], (string)reader["habilidad"]);
                        listanuevadepokemones.Add(pokemon);
                        Entrenador entrenador = new Entrenador((Guid)reader["identrenador"], (string)reader["nombreentrenador"], (string)reader["origen"], (bool)reader["liderdegimnasio"], (int)reader["medallas"], listanuevadepokemones);
                        entrenadores.Add(entrenador);
                    }
                    

                }
                conex.Close();
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("No se pudo conectar a la base de datos el error es: " + e.Message);
            }
  
            return entrenadores;
        }

        public Entrenador ObtenerEntrenadoresNombre(string nombre)
        {
            Entrenador entrenador = null;
            List<Pokemon> pokemones = new List<Pokemon>();

            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                NpgsqlCommand command = conex.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select e.nombre as nombreentrenador, e.origen, e.liderdegimnasio, e.medallas,ep.idpokemon,ep.identrenador,p.nombre as nombrepokemon,p.orden,p.tipo,p.evolucion,p.habilidad FROM entrenador as e inner join entrenador_pokemon as ep on e.id = ep.identrenador inner join pokemon as p on p.id = idpokemon WHERE e.nombre = @nombreentrenador";
                command.Parameters.AddWithValue("@nombreentrenador", nombre);
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   
                        Pokemon pokemon = new Pokemon((Guid)reader["idpokemon"], (string)reader["nombrepokemon"], (int)reader["orden"], (string)reader["tipo"], (string)reader["evolucion"], (string)reader["habilidad"]);
                        pokemones.Add(pokemon);
                        entrenador = new Entrenador((Guid)reader["identrenador"], (string)reader["nombreentrenador"], (string)reader["origen"], (bool)reader["liderdegimnasio"], (int)reader["medallas"], pokemones);

                }
                conex.Close();
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("No se pudo conectar a la base de datos el error es: " + e.Message);
            }

            return entrenador;
        }

        
    }
}
