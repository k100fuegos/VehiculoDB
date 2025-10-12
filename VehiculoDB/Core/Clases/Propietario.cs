using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculoDB.Core.Clases
{
    internal class Propietario
    {

        private int idPropietario;
        private string nombre;
        private string apellido;
        private string DUI;
        private string telefono;
        private string direccion;

        public int IdPropietario { get => idPropietario; set => idPropietario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string DUI1 { get => DUI; set => DUI = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
