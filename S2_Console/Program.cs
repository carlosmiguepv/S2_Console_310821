using System;
using System.Collections.Generic;
using System.Linq;
using S2_Console.Entidades;

namespace S2_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string nombreCurso = "Desarrollo de Aplicaciones Web 2021-2";
            int edad = 20;
            double monto = 200.01;

            var nuevaEdad = "Veintiuno";
            var peso = 70.50;

            var listadoPersona = new List<Persona>();

            var persona = new Persona();
            persona.dni = "72471827";
            persona.nombreCompleto = "Carlos Pajuelo";
            persona.telefono = 98765431;

            var persona2 = new Persona("1234567", "luis perez", 45678913);

            var persona3 = new Persona()
            {
                dni = "147896325",
                nombreCompleto = "jorge castillo",
                telefono = 1385435,
            };

            listadoPersona.Add(persona);
            listadoPersona.Add(persona2);
            listadoPersona.Add(persona3);

            foreach (var item in listadoPersona)
            {
                Console.WriteLine(item.dni + " " + item.nombreCompleto + " " + item.telefono);
            }

            var busqueda = listadoPersona.Where(x => x.dni == "147896325").FirstOrDefault();

            Console.WriteLine("La búsqueda encontró a: " + busqueda.nombreCompleto);
        }
    }
}
