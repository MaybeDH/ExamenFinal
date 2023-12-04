using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class pilotos
    {
        [Key]
        public string numero_licencia { get; set; }
        public string restricciones { get; set; }
        public string salario { get; set; }
        public string turno { get; set; }
    }
  
}

