using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Alumno : Persona
    {
        private int _codigo;

        public Alumno(int codigo)
        {
            _codigo = codigo;
        }

        public int Codigo { get => _codigo; set => _codigo = value; }

        public override string ToString()
        {
            return "El codigo es" + _codigo;
        }

        //public override string GetCredencial()
        // porque hay que pisar este metodo? que queremos que nos devuelva? 
        //    return 
        //}


    }
}
