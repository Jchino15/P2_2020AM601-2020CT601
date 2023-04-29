using System.ComponentModel.DataAnnotations;

namespace P2_2020AM601_2020CT601.Models
{
    public class Generos
    {
        [Key]
        public int Idgenero { get; set; }
        public string? genero { get; set; }
    }
}
