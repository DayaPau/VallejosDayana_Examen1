using System.ComponentModel.DataAnnotations;

namespace VallejosDayana_Examen1.Models
{
    public class DVallejos
    {
        [Required]
        public int Edad { get; set; }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Range(1.35, 2.10)]
        public double Estatura { get; set; }
        public bool EsSoltero { get; set; }

        public  DateTime Fecha{ get; set; }

        public Celular celular { get; set; }

    }
}
