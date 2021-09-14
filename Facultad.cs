using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class Facultad
    {
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;

        public Facultad(List<Alumno> alumnos)
        {
            _alumnos = alumnos;
        }

        public Facultad(List<Empleado> empleados)
        {
            _empleados = empleados;
        }

        public int CantidadSedes { get => _cantidadSedes; set => _cantidadSedes = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public void AgregarAlumno(Alumno a)
        {
            foreach (Alumno alumno in _alumnos)
            {
                if (alumno == null)
                {
                    _alumnos.Add(a);
                }
            }

        }

        public void AgregarEmpleado(Empleado e)
        {
            foreach (Empleado empleado in _empleados)
            {
                if (empleado == null)
                {
                    _empleados.Add(e);
                }
            }

        }

        public void EliminarAlumno(int codigoAlumno)
        {
            foreach (Alumno alumno in _alumnos)
            {
                if (codigoAlumno == alumno.Codigo)
                {
                    _alumnos.Remove(alumno);
                }

            }
        }

    