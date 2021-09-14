using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Empleado : Persona
    {
        private DateTime _fechaIngreso;
        private int _legajo;
        private List<Salario> _salarios;

        public Empleado(List<Salario> salarios)
        {
            _salarios = salarios;
        }

        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }

        public DateTime FechaNacimiento()
        {
            

            return()
        }
    
        public void AgregarSalario(Salario s)
        {
            foreach (Salario salario in _salarios)
            {
                if (salario == null)
                {
                    _salarios.Add(s);
            }
        }
    
    
    
    }
}
