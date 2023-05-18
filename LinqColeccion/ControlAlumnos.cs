using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColeccion
{
    internal class ControlAlumnos
    {
        List<Carrera> carreras = new List<Carrera>();
        List<Alumno> alumnos = new List<Alumno>();

        public ControlAlumnos() 
        {
            carreras.Add( new Carrera { IdCarrera = 1, NombreCarrera = "Ingeniería de Software"} );
            carreras.Add(new Carrera { IdCarrera = 2, NombreCarrera = "Redes y Servicios de Computo"} );

            alumnos.Add(new Alumno
            {
                IdAlumno = 1,
                Nombre = "Elian Ernesto Sorcia Patiño",
                Matricula = "S19013990",
                Promedio = 9.9,
                IdCarrera = 1
            });
            alumnos.Add(new Alumno
            {
                IdAlumno = 2,
                Nombre = "Diana Pilar Miranda Estrella",
                Matricula = "S19014038",
                Promedio = 10.0,
                IdCarrera = 1
            });
            alumnos.Add(new Alumno
            {
                IdAlumno = 1,
                Nombre = "Manuel Ladrón de Guevara Tello",
                Matricula = "S19030174",
                Promedio = 2.3,
                IdCarrera = 2
            });
        }

        public void obtenerALumnosPorCarrera(int idCarrera)
        {
           
            IEnumerable<Alumno> resultado = from alumno in alumnos
                                            join carrera in carreras on alumno.IdCarrera
                                            equals carrera.IdCarrera
                                            where alumno.IdCarrera == idCarrera 
                                            select alumno ; 

            foreach(Alumno alumno in resultado)
            {
                alumno.getDatosAlumno(carreras);
                
                

                
            }
        }


    }
}
