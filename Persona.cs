using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{


    class Persona
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;


        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento)
        {
            _nombre = nombre;
            _apellido = apellido;
            _fechaNacimiento = fechaNacimiento;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }

        public int Edad(DateTime hoy)
        {
            int edad = 0;

            //Calcular con la fecha de hoy y la fecha de nacimiento la edad

            return edad;
        }
    
    
        public string GetNombreCompleto()
        {
            return _nombre + _apellido;
        }
    
        public string GetCredencial()
        {
            return _nombre + _apellido + _fechaNacimiento;
        }
    
    
    
    }
}
