using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaHerencia
{
    public class EmpleadoPorComision: Object
    {
        private string primerNombre;
        private string apellidoPaterno;
        private string numeroSeguroSocial;
        private decimal trifaComision;
        private decimal VentasBrutas;

        public EmpleadoPorComision(string nombre, string apellido,
            string nss, decimal tarifa, decimal venta)
        {
            primerNombre = nombre;
            apellidoPaterno = apellido;
            numeroSeguroSocial = nss;
            trifaComision = tarifa;
            VentasBrutas = venta;
        } 
        public string nombre
        {
            get               
            {
                return primerNombre;
            }
        }
        public string apellido
        {
            get 
            {
                return apellidoPaterno;
            }
        }
        public string nss
        {
            get { return numeroSeguroSocial; }
        }
        public decimal tarifa
        {
            get
            {
                return trifaComision;
            }
            set
            {
                trifaComision = (value > 0 && value < 1) ? value : 0;
            }
        }
        public decimal ventasBrutas
        {
            get 
            {
                return ventasBrutas;
            }
            set
            {
                ventasBrutas = (value < 0) ? 0 : value;
            }
        }

        public virtual decimal ingreso() 
        {
            return trifaComision * ventasBrutas;
        }
        public override string ToString()
        {
            return String.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
                "empleado por comisión", primerNombre, apellidoPaterno,
                "número de seguro social", nss,
                "ventas brutas", ventasBrutas, "tarifa de comisión", trifaComision);
                
        }
    }
}
