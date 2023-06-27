﻿using _00_Presentacion;
using _01_Aplicacion;
using _01_Aplicacion.DTO;
using _02_Dominio.Repositorio;
using _03_Infraestructura;
using System.Linq.Expressions;

/*PokemonDTO pokemon1 = new PokemonDTO(
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
);*/

PokemonRepositorio repositorio = new PokemonRepositorioEnMemoria();
CrearPokemon creadorDePokemons = new CrearPokemon(repositorio);
ObtenerPokemones obtenerPokemones = new ObtenerPokemones(repositorio);

UI ui = new UiAscii();
char opcion;

do 
{
  opcion  = ui.Menu();
  switch (opcion)
  {
    case '1':
        ui.RegistrarPokemon();
        break;

    default:
        ui.Menu();
        break;

   }

} while(opcion != '0');

/*creadorDePokemons.ejecutar(pokemon1);
creadorDePokemons.ejecutar(pokemon2);
creadorDePokemons.ejecutar(pokemon3);

List<PokemonDTO> pokemones = obtenerPokemones.Ejecutar();
foreach(PokemonDTO pokemon in pokemones)
{
    Console.WriteLine(pokemon.Describirse());
}*/