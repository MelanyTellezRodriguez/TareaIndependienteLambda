using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaIndependienteLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Filtrando una lista de estudiantes 
            // Se requiere desarrollar un programa en c# que maneje una lista de estudiantes y utilice 
            //expresiones lambda para filtrar y manipular los datos 

            //******************************************************************************************

            //Crear una lista de estudiantes con al menos 5 elementos 

            List<Estudiante> estudiantes = new List<Estudiante>() {

            new Estudiante { Nombre = "Maria Lopez", Edad = 17, Nota = 50 },
            new Estudiante { Nombre = "Ronald Rugama", Edad = 19, Nota = 80 },
            new Estudiante { Nombre = "Roger Rodriguez", Edad = 18, Nota = 60 },
            new Estudiante { Nombre = "carolina Perez", Edad = 20, Nota = 85 },
            new Estudiante { Nombre = "Estefani Baldioseda", Edad = 16, Nota = 83 }
        };


            //************************************************************************************************
            //Filtrar los estudiantes mayores de 18 años

            //En c# la palabra clave "Var" se utiliza para inferencia de tipos implicita, lo que significa que el 
            //compilador deduce el tipo de la variable en tiempo de compilacion basandose en el valor asignado a es
            //variable.

            //"estudiantesMayoresDe18" -> es el nombre de la variable que alamacenara el resultado 
            //de la operacion

            //"estudiantes" -> es una lista la cual contiene las propiedades de Nombre, Edad y Nota.

            //"Where(e => e.Edad > 18)" -> es un metodo de LINQ que filtra la coleccion "estudiante", este 
            //filtro aplica una expresion lambda "e => e.Edad > 18" que significa, "Seleccionar aquellos 
            //estudiantes cuya edad sea mayor a 18".

            var estudiantesMayoresDe18 = estudiantes.Where(e => e.Edad > 18).ToList();

            Console.WriteLine("Estudiantes mayores a 18");

            //foreach se utiliza para iterar sobre una coleccion de elementos foreach es una estructura de 
            //de control de flujo que permite recorrer todos los elementos de una coleccion

            //"estudiante" es una variable que representa el elemento actual en la iteracion.

            //"in estudiantesMayoresDe18" -> especifica la coleccion sobre la cual se esta iterando
            foreach (var estudiante in estudiantesMayoresDe18)
            {
                Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}, Nota: {estudiante.Nota}");
            }



            //*****************************************************************************************************
            //Obtener al estudiante con la nota mas alta 



            //"OrderByDescending(e => e.Nota)" -> Es un metod de LINQ que ordena la coleccion "estudiantes"en orden 
            //descendente segun la propiedad "Nota" de cada estudiante. la expresion lambda "e => e.Nota", 
            //especifica que el criterio de ordenacion es la propiedad "Nota"
            //"First()" -> Es un metodo que devuelve el primer elemento de la coleccion ordenada

            var estudianteNotaMasAlta = estudiantes.OrderByDescending(e => e.Nota).First();
            Console.WriteLine($"El estudiante con la nota mas alta es: {estudianteNotaMasAlta.Nombre}, Nota: {estudianteNotaMasAlta.Nota}");


            //******************************************************************************************************
            //Ordenar la lista de estudiantes por orden ascendente

            //"OrderBy(e => e.Nombre)" -> es un metodo de LINQ que ordena la lista "estudiante" en orden ascendente 
            //segun la propiedad Nombre de cada estudiante. La expresion lambda e.Nombre especifica que el criterio
            //de ordenacion es la propiedad "Nombre"

            //"TOList()" -> Convierte el resultado del metodo OrderBy en una lista
            var estudiantesOrdenAscendenteNombre = estudiantes.OrderBy(e => e.Nombre).ToList();
            Console.WriteLine("Estudiantes ordenados por nombre de forma ascendente:");

            foreach(var estudiante in estudiantesOrdenAscendenteNombre)
            {
                Console.WriteLine($"Nombre: {estudiante.Nombre}");
            }
            //*********************************************************************************************************

            //calcular el promedio de notas de los estudiantes 

            //"Average(e => e.Nota)" -> Es un metod de LINQ que calcula el promedio de una secuencia de valores
            //La expresion lambda e => e.Nota especifica que se debe utilizar la propiedad Notas de cada 
            //estudiante para el calculo del promedio

            var promedioNotas = estudiantes.Average(e => e.Nota);
            Console.WriteLine($"Promedio de notas: {promedioNotas}");

        }
    }
}
