﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColeccion
{
    internal class Alumno
    {
        public int IdAlumno
        {
            get; set;
        }
        public string Nombre
        {
            get; set;
        }
        public string Matricula
        {
            get; set;
        }
        public double Promedio
        {
            get; set;
        }
        public int IdCarrera
        {
            get; set;
        }
        

        public void getDatosAlumno(List<Carrera> carreras)
        {
            Carrera carrera= carreras.FirstOrDefault(c=>c.IdCarrera==IdCarrera);
            if (carrera != null)
            {
                Console.WriteLine("Alumno {0} con matricula {1} y promedio {2} en la carrera {4} con ID {3}"
                    , Nombre, Matricula, Promedio, IdCarrera, carrera.NombreCarrera);
            }else
            {
                Console.WriteLine("Alumno {0} con matricula {1} y promedio {2} en la carrera con ID {3} con nombre no encontrado",
                     Nombre, Matricula, Promedio, IdCarrera);
            }

        }


    }
}
