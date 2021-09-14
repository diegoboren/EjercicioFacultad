using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime fecha;

        public Salario(double bruto)
        {
            _bruto = bruto;
        }

        public double GetSalarioNeto()
        {

            return _bruto - _descuentos;
        }

        public double Bruto { get => _bruto; set => _bruto = value; }
        public string CodigoTransferencia { get => _codigoTransferencia; set => _codigoTransferencia = value; }
        public double Descuentos { get => _descuentos; set => _descuentos = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
