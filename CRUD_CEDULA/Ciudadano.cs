using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CEDULA
{
    internal class Ciudadano
    {
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string LugarNacimiento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public char Sexo { get; set; }
        public string Sangre { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public string URLFoto { get; set; }
        public string CedulaAnterior { get; set; }
        public int ColegioElectoral { get; set; }
        public string UbicacionColegio { get; set; }
        public string DireccionResidencia { get; set; }
        public string Sector { get; set; }
        public string Municipio { get; set; }
        public string RegistroNacimiento { get; set; }
        public int CodigoPostal { get; set; }
        public DateTime FechaRegistro{ get; set; }

    }
}
