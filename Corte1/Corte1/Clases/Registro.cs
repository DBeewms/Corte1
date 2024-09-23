using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corte1.Clases;

namespace Corte1.Clases
{
    internal class Registro
    {
        private Persona[] personas;
        private int contador;

        public Registro()
        {
            personas = new Persona[30];
            contador = 0;
        }

        public bool AgregarPersona(Persona persona)
        {
            if (contador < 30)
            {
                personas[contador] = persona;
                contador++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Persona[] MostrarPersonas()
        {

            Persona[] personasRegistradas = new Persona[contador];
            for (int i = 0; i < contador; i++)
            {
                personasRegistradas[i] = personas[i];
            }
            return personasRegistradas;
        }


        public int ContadorPersonas()
        {
            return contador;
        }
    }
}
