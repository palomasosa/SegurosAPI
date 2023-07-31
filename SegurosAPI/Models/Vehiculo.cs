using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SegurosAPI.Models
{
    [Index(nameof(vehiculoID), Name = "vehiculoID_UQ", IsUnique = true)]
    public class Vehiculo
    {
        [Key] public int vehiculoID { get; set; }
        public int? año { get; set; }
        public string patente { get; set; }
        public string? marca { get; set; }
        public Cliente Cliente { get; set; }
        public int clienteID { get; set; }
        public Poliza Poliza { get; set; }
        public int polizaID { get; set; }
    }
}
