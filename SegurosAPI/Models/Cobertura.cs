using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SegurosAPI.Models
{
    [Index(nameof(coberturaID), Name = "coberturaID_UQ", IsUnique = true)]
    public class Cobertura
    {
        [Key] public int coberturaID { get; set; }
        public string tipo { get; set; }
        public ICollection<Poliza>? Polizas { get; set; }
    }
}
