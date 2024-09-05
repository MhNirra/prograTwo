using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum tipo_h
{
    INDIVIDUAL, DOBLE, SUITE
}

enum estado_h
{
    DISPONIBLE, OCUPADA, MANTENIMIENTO
}
namespace Hotel
{
    internal class Habitacion
    {

        private int numeroHabitacion;
        private tipo_h tipoHabitacion;
        private estado_h estadoHabitacion;
        private int precio;

        public Habitacion() { this.precio = 100; }

        public int NumeroHabitacion {

            get { return numeroHabitacion; }
            set { numeroHabitacion = value; }
        }
        public tipo_h TipoHabitacion {
            get { return tipoHabitacion; }
            set { tipoHabitacion = value; }

        }
        public estado_h EstadoHabitacion {
            get { return estadoHabitacion; }
            set { estadoHabitacion = value; }
        }
        public int getPrecio() { return precio; }
        public void setPrecio(int precio) { this.precio = precio; }

        public void CambiarEstado(estado_h nuevoEstado)
        {
            EstadoHabitacion = nuevoEstado;
        }

        public string ObtenerInformacionCompleta()
        {
            return $"Habitacion Nº {NumeroHabitacion}, Tipo: {TipoHabitacion}, " +
                $"Estado: {EstadoHabitacion}, Precio por noche: {getPrecio():C}";
        }


    }
}
