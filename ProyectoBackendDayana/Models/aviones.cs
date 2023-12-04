using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendDayanaCano.Models
{
    public class aviones
    {
        [Key]
        public int id_avion { get; set; }
        public string numero_avion { get; set; }
        
        public string modelo { get; set; }
        public string peso { get; set; }
        public int capacidad { get; set; }
        public int id_hangar { get; set; }
        public string id_piloto { get; set; }

    }
}
