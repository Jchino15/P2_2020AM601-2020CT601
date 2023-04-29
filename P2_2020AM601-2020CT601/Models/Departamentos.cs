using System.ComponentModel.DataAnnotations;

namespace P2_2020AM601_2020CT601.Models
{
    public class Departamentos
    {
        [Key]
        public int Iddepartamento { get; set; }

        public string? nombreDepartamento { get; set; }
    }
}
