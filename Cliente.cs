using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Cliente
    {

        private int rut;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int numeroTelefono;

        public int Rut
        {

            get { return rut; }
            set { rut = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {

            get { return apellido; }
            set { apellido = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public int NumeroTelefono
        {
            get { return numeroTelefono; }
            set { numeroTelefono = value; }
        }
    }
}
