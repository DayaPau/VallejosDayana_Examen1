using System.ComponentModel.DataAnnotations;

namespace VallejosDayana_Examen1.Models
{
    public class DVallejos
    {
        [Required]
        public int Edad { get; set; }

        [Key]
        public string Nombre { get; set; }
        public double Estatura { get; set; }
        public bool EsSoltero { get; set; }

        public   { get; set; }
    }
}
