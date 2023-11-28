using System.IO;
using System.Collections.Generic;

// Creamos una variable implícita que contenga los valores
// regresados por nuestra función creada y pasandole el directorio "stores"
var archivosVentas = EncontrarArchivo("stores");

// Recorremos los resultados obtenidos
foreach (var elemento in archivosVentas)
{
    //Imprimimos los resultados por consola
    Console.WriteLine(elemento);
}

// Creamos una función que devolvera un enumerable de tipo string
// que reciba por parámetro el nombre del folder a buscar
IEnumerable<string> EncontrarArchivo (string NombreDirectorio)
{
    // Creamos una lista donde se alamcenaran los archivos que contenga el directorio.
    // que coincidan con la extensión que buscamos
    List<string> archivosVentas = new List<string>();

    // Hacemos una declaración implícita de una variable que
    // almacenará el resultado de la numeración de todos los directorios con cualquier
    // extensión de nuestro folder que pasemos como parámetro 
    var archivoEncontrado = Directory.EnumerateFiles(NombreDirectorio,"*",SearchOption.AllDirectories); 

    // Recorremos el contenido de nuestra variable
    foreach (var elemento in archivoEncontrado)
    {
        // Verificamos si el archivo en turno tiene extensión .json
        if (elemento.EndsWith("sales.json"))
        {
            //Si el elemento coincide lo añadimos a la lista
            archivosVentas.Add(elemento);
        }
    }

    // Devolvemos la lista de elementos
    return archivosVentas;
}