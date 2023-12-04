using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class hangares
    {
        [Key]
        public int id_hangar { get; set; }
        public string numero_hangar { get; set; }
        public int capacidad { get; set; }
        public string localizacion { get; set; }

    }
}