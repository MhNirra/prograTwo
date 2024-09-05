using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum cargos_t
{
    RECEPCIONISTA, LIMPIEZA, GERENTE

}


namespace Hotel
{
    internal class Personal
    {

        private cargos_t cargos;
        private int identificar;
        private string nombreTrabajador;
        private string apellidoTrabajador;
        private DateTime contratacion;
        private double salario;

        public Personal() { this.salario = 100; }
        public cargos_t Cargos {

            get { return cargos; }
            set { cargos = value; }

        }
        public int Identificar {
            get { return identificar; }
            set { identificar = value; }
        }
        public string NombreTrabajador {
            get { return nombreTrabajador; }
            set { nombreTrabajador = value; }
        }
        public string ApellidoTrabajador {
            get { return apellidoTrabajador; }
            set { apellidoTrabajador = value; }
        }
        public DateTime Contratacion {
            get { return contratacion; }
            set { contratacion = value; }
        }

        public double getSalario() { return salario; }

        public void setSalario(double salario) { this.salario = salario; }

        public void SalarioEmpleado(double incrementoPorcentaje)
        {

            if (incrementoPorcentaje < 0)
            {
                throw new ArgumentException("El porcentaje no puede ser negativo");
            }

            salario += salario * (incrementoPorcentaje / 100);
            
        }

        public string ObtenerInformacionCompleta()
        {

            return $"Numero de identificacion: {Identificar}, " +
                $"Nombre: {NombreTrabajador} {ApellidoTrabajador}, " +
                //$"Fecha contratado: {Contratacion.ToShortDateString()}, " +
                $"Cargo: {Cargos}, " +
                $"Salario: {salario:C}";
        }

    }
}
