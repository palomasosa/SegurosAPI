using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SegurosAPI.Models
{
    [Index(nameof(clienteID), Name = "clienteID_UQ", IsUnique = true)]
    public class Cliente
    {
        [Key] public int clienteID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string? mail { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string? ciudad { get; set; }
        public ICollection<Pagos>? Pagos { get; set; }
        public ICollection<Vehiculo>? Vehiculos { get; set; }
    }
}
