using _01_Aplicacion;
using _01_Aplicacion.DTO;
using _02_Dominio.Repositorio;
using _03_Infraestructura;

PokemonDTO pokemon1 = new PokemonDTO(
Guid.NewGuid(),
"Squirtle",
0007,
"Agua",
"Wartortle",
"Torrente"
);

PokemonRepositorio repositorio = new PokemonRepositorioEnMemoria();
CrearPokemon creadorDePokemons = new CrearPokemon(repositorio);

creadorDePokemons.ejecutar(pokemon1);
