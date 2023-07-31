using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SegurosAPI.Models
{
    [Index(nameof(usuarioID), Name = "usuarioID_UQ", IsUnique = true)]
    public class Usuario
    {
        [Key] public int usuarioID { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public string contraseña { get; set; }
        public ICollection<Pagos>? Pagos { get; set; }
    }
}
