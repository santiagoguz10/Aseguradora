using System.ComponentModel.DataAnnotations;

namespace Aseguradora.Model
{
    public class Poliza
    {
        [Key]
        public int Id { get; set; }
        public int NumeroPoliza { get; set; }
        public string NombreCliente { get; set; }
        public int IdentificacionCliente { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaPoliza  { get; set; }
        public string CoberturasPoliza { get; set; }
        public int ValorMaximoPoliza { get; set; }
        public string NombrePlanPoliza { get; set; }
        public string CiudadCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string PlacaVehiculo{ get; set; }
        public int ModeloVehiculo { get; set; }
        public bool Inspeccion { get; set; }
    }
}
