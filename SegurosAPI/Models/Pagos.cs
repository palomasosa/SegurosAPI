using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SegurosAPI.Models
{
    [Index(nameof(pagoID), Name = "pagoID_UQ", IsUnique = true)]
    public class Pagos
    {
        [Key] public int pagoID { get; set; }
        public DateTime fecha { get; set; }
        public decimal monto { get; set; }
        //CLAVES FORÁNEAS
        public Poliza Poliza { get; set; }
        public int polizaID { get; set; }
        public Cliente Cliente { get; set; }
        public int clienteID { get; set; }
        public Usuario Usuario { get; set; }
        public int usuarioID { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public int metodoID { get; set; }
    }
}
