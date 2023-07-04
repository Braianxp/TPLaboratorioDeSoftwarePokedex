# TPLaboratorioDeSoftwarePokedex

## Resumen
Programa que ejecuta un CRUD en C# aplicando los principios SOLID.
La persistencia de los datos se puede cambiar de una Base de datos relacional en Postgresql o No relacional en MongoDB

## Metodos en este proyecto
* Crear un pokemon
* Modificar pokemon
* Eliminar pokemon
* Consultar pokemon
* Consultar todos los pokemones
* Crear un entrenador
* Modificar entrenador
* Eliminar entrenador
* Consultar entrenador
* Consultar todos los entrenadores

## Pasos de Despliegue
* Crear la base de datos relacional ejecutando el script que se encuentra en el proyecto 03-Infraestructura en la carpeta SQLScript
* Crear la base de datos no relacional con las tablas (Pokemon) (Entrenador) (Entrenador_Pokemon)
* Configurar la conexion a la base de datos relacional en las Clases EntrenadorRepositorioPostgreSQL y PokemonRepositorioPostgreSQL en el proyecto 03-Infraestructura
* Configurar la conexion a la base de datos no relacional en las Clases EntrenadorRepositorioMongoDB y PokemonRepositorioMongoDB en el proyecto 03-Infraestructura
* Pasar por parametro a todos los objetos de la Clase program en 00-Presentacion el repositorio que se desea utilizar para la persistencia de datos
* Ejecutar el proyecto
