using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bedel : Empleado
    {

        private string _apodo;

        public string Apodo { get => _apodo; set => _apodo = value; }
    }
}
