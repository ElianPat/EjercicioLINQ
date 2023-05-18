// See https://aka.ms/new-console-template for more information

using LinqColeccion;
using System.Linq;
using System.Xml.Linq;
/*
int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("A continuación te mostramos los numeros que existen en el arreglo");

//Sin LINQ
/*List<int> numerosPares = new List<int>();
foreach (int numero in numeros)
{
    if(numero % 2 == 0)
    {
        numerosPares.Add(numero);
    }
}


//Con LINQ
IEnumerable<int> numerosPares = from numero in numeros where numero % 2 == 0 select numero;


//impresion numeros pares
foreach (int numero in numerosPares)
{
    Console.WriteLine(numero);
}*/

ControlAlumnos controlAlumnos = new ControlAlumnos();
controlAlumnos.obtenerALumnosPorCarrera(1);