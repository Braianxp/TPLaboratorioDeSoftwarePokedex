using _00_Presentacion;
using _01_Aplicacion;
using _01_Aplicacion.DTO;
using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _02_Dominio.ValueObject;
using _03_Infraestructura;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

PokemonRepositorio repositorioPokemonEnMemoria = new PokemonRepositorioEnMemoria();
PokemonRepositorio repositorioPokemonPostgreSql = new PokemonRepositorioPostgreSQL();

CrearPokemon crearPokemon = new CrearPokemon(repositorioPokemonPostgreSql);
ObtenerPokemones obtenerPokemones = new ObtenerPokemones(repositorioPokemonPostgreSql);
BuscarPokemon buscarPokemon = new BuscarPokemon(repositorioPokemonPostgreSql);
ModificarPokemon modificarPokemon = new ModificarPokemon(repositorioPokemonPostgreSql);
EliminarPokemon eliminarPokemon = new EliminarPokemon(repositorioPokemonPostgreSql);

EntrenadorRepositorio repositorioEntrenadorEnMemoria = new EntrenadorRepositorioEnMemoria();
EntrenadorRepositorio repositorioEntrenadorPostgreSql = new EntrenadorRepositorioPostgreSQL();


CrearEntrenador crearEntrenador = new CrearEntrenador(repositorioEntrenadorPostgreSql);
ObtenerEntrenadores obtenerEntrenadores = new ObtenerEntrenadores(repositorioEntrenadorPostgreSql);
BuscarEntrenador buscarEntrenador = new BuscarEntrenador(repositorioEntrenadorPostgreSql);
ModificarEntrenador modificarEntrenador = new ModificarEntrenador(repositorioEntrenadorPostgreSql);
EliminarEntrenador eliminarEntrenador = new EliminarEntrenador(repositorioEntrenadorPostgreSql);

UI uiConsola = new UiConsola();
char opcion;

do
{
    opcion = uiConsola.Menu();
    switch (opcion)
    {
        //pokemon
        case '0':
            uiConsola.RegistrarPokemon(crearPokemon);
            break;

        case '1':
            uiConsola.BuscarPokemon(buscarPokemon);
            break;

        case '2':
            uiConsola.ObtenerPokemones(obtenerPokemones);
            break;
        
        case '3':
            uiConsola.EliminarPokemon(eliminarPokemon);
            break;
       
        case '4':
            uiConsola.ModificarPokemon(modificarPokemon,buscarPokemon);
            break;

        //entrenador
        case '5':
            uiConsola.RegistrarEntrenador(crearEntrenador, obtenerPokemones);
            break;

        case '6':
            uiConsola.BuscarEntrenador(buscarEntrenador);
            break;

        case '7':
            uiConsola.ObtenerEntrenadores(obtenerEntrenadores);
            break;

        case '8':
            uiConsola.EliminarEntrenador(eliminarEntrenador);
            break;

        case '9':
            uiConsola.ModificarEntrenador(modificarEntrenador,buscarEntrenador, obtenerPokemones);
            break;
        
        default:
            uiConsola.Menu();
            break;

    }

} while (opcion != 'X' || opcion != 'x');