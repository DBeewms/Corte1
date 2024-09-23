using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corte1.Clases;

namespace Corte1.Clases
{
    internal class Operacion
    {
        public static int CalcularEdad(Persona persona)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - persona.FechaNac.Year;

            if (hoy < persona.FechaNac.AddYears(edad))
            {
                edad--;
            }

            return edad;
        }

        public static string VerificarMayorEdad(Persona persona)
        {
            int edad = CalcularEdad(persona);
            return edad >= 18 ? "Mayor de edad" : "Menor de edad";
        }
    }
}
