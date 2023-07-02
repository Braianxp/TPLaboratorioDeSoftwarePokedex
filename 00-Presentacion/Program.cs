﻿using _01_Aplicacion;
using _01_Aplicacion.DTO;
using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _03_Infraestructura;

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



PokemonRepositorio repositorio = new PokemonRepositorioEnMemoria();
CrearPokemon creadorDePokemons = new CrearPokemon(repositorio);
ObtenerPokemones obtenerPokemones = new ObtenerPokemones(repositorio);
BuscarPokemon buscarPokemon = new BuscarPokemon(repositorio);
ModificarPokemon modificarpokemon = new ModificarPokemon(repositorio);
EliminarPokemon eliminarpokemon = new EliminarPokemon(repositorio);

creadorDePokemons.ejecutar(pokemon1);
creadorDePokemons.ejecutar(pokemon2);
creadorDePokemons.ejecutar(pokemon3);

List<PokemonDTO> pokemones = obtenerPokemones.Ejecutar();
foreach(PokemonDTO pokemon in pokemones)
{
    Console.WriteLine(pokemon.Describirse());
}


PokemonDTO pokemonDTO = buscarPokemon.Ejecutar(1);

PokemonDTO pokemon4 = new PokemonDTO(
pokemonDTO.Id(),
"Pikachu",
0025,
"Electrico",
"Raychu",
"Impact trueno"
);

modificarpokemon.Ejecutar(pokemon4);
Console.WriteLine("-");
pokemones = obtenerPokemones.Ejecutar();
foreach (PokemonDTO pokemon in pokemones)
{
    Console.WriteLine(pokemon.Describirse());
}


eliminarpokemon.Ejecutar(5);
Console.WriteLine("-");
pokemones = obtenerPokemones.Ejecutar();
foreach (PokemonDTO pokemon in pokemones)
{
    Console.WriteLine(pokemon.Describirse());
}