using Microsoft.EntityFrameworkCore;

namespace SegurosAPI.Models
{
    [Index(nameof(polizaID), Name = "polizaID_UQ", IsUnique = true)]
    public class Poliza
    {
        public int polizaID { get; set; }
        public int nroPoliza { get; set; }
        public decimal valorAsegurado { get; set; }
        public DateTime inicioVigencia { get; set; }
        public DateTime finVigencia { get; set; }
        public decimal valorCuota { get; set; }
        public int empresaID { get; set; }
        public int coberturaID { get; set; }
        public ICollection<Vehiculo>? Vehiculos { get; set; }
        public ICollection<Pagos>? Pagos { get; set; }
    }
}
