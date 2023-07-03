using _01_Aplicacion;
using _01_Aplicacion.DTO;
using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _02_Dominio.ValueObject;
using _03_Infraestructura;
using System.Collections.Generic;

PokemonDTO pokemon1 = new PokemonDTO(
Guid.NewGuid(),
"Squirtle",
0007,
"Agua",
"Wartortle",
"Pistola agua"
);

PokemonDTO pokemon2 = new PokemonDTO(
Guid.NewGuid(),
"Bulbasaur",
0001,
"Planta",
"Ivysaur",
"Látigo cepa"
);

PokemonDTO pokemon3 = new PokemonDTO(
Guid.NewGuid(),
"Charmander",
0004,
"Fuego",
"Charmeleon",
"Lanzallamas"
);




PokemonRepositorio repositorioPokemonEnMemoria = new PokemonRepositorioEnMemoria();
PokemonRepositorio repositorioPokemonPostgreSql = new PokemonRepositorioPostgreSQL();
CrearPokemon creadorDePokemons = new CrearPokemon(repositorioPokemonPostgreSql);
ObtenerPokemones obtenerPokemones = new ObtenerPokemones(repositorioPokemonPostgreSql);
BuscarPokemon buscarPokemon = new BuscarPokemon(repositorioPokemonPostgreSql);
ModificarPokemon modificarpokemon = new ModificarPokemon(repositorioPokemonPostgreSql);
EliminarPokemon eliminarpokemon = new EliminarPokemon(repositorioPokemonPostgreSql);

EntrenadorRepositorio repositorioEntrenadorEnMemoria = new EntrenadorRepositorioEnMemoria();
EntrenadorRepositorio repositorioEntrenadorPostgreSql = new EntrenadorRepositorioPostgreSQL();
CrearEntrenador crearEntrenador = new CrearEntrenador(repositorioEntrenadorPostgreSql);
ObtenerEntrenador obtenerEntrenadores = new ObtenerEntrenador(repositorioEntrenadorPostgreSql);


/*creadorDePokemons.ejecutar(pokemon1);
creadorDePokemons.ejecutar(pokemon2);
creadorDePokemons.ejecutar(pokemon3);

Console.WriteLine("-OBTENEMOS TODOS LOS POKEMONES-");
List<PokemonDTO> pokemones = obtenerPokemones.Ejecutar();
foreach(PokemonDTO pokemon in pokemones)
{
    Console.WriteLine(pokemon.Describirse());
}


PokemonDTO pokemonDTO = buscarPokemon.Ejecutar(7);
//Console.WriteLine(pokemonDTO.Describirse());

PokemonDTO pokemon4 = new PokemonDTO(
pokemonDTO.Id(),
"Pikachu",
0025,
"Electrico",
"Raychu",
"Impact trueno"
);

modificarpokemon.Ejecutar(pokemon4);

Console.WriteLine("-MODIFICAMOS 1 POKEMON-");

pokemones = obtenerPokemones.Ejecutar();
foreach (PokemonDTO pokemon in pokemones)
{
    Console.WriteLine(pokemon.Describirse());
}
*/
//eliminarpokemon.Ejecutar(4);
/*
Console.WriteLine("-ELIMINAMOS 1 POKEMON-");
pokemones = obtenerPokemones.Ejecutar();
foreach (PokemonDTO pokemon in pokemones)
{
    Console.WriteLine(pokemon.Describirse());
}
*/

/*
List<PokemonDTO> listaPokemones1 = new List<PokemonDTO>
{
    pokemon1,
    pokemon2
};

List<PokemonDTO> listaPokemones2 = new List<PokemonDTO>
{
    pokemon3,
    pokemon1
};*/

/*EntrenadorDTO entrenador1 = new EntrenadorDTO(
 Guid.NewGuid(),
 "Ash Ketchum",
 "Pueblo Paleta",
 false,
 5,
 listaPokemones1
 );

EntrenadorDTO entrenador2 = new EntrenadorDTO(
 Guid.NewGuid(),
 "Brook",
 "Ciudad Roca",
 true,
 3,
 listaPokemones2
 );

crearEntrenador.ejecutar(entrenador1);
crearEntrenador.ejecutar(entrenador2);
*/
Console.WriteLine("-OBTENEMOS TODOS LOS ENTRENADORES-");
List<EntrenadorDTO> entrenadores = obtenerEntrenadores.Ejecutar();
foreach (EntrenadorDTO entrenador in entrenadores)
{
    Console.WriteLine(entrenador.Describirse());
}

Console.WriteLine("-MODIFICAMOS 1 ENTRENADOR-");
