using System.ComponentModel.DataAnnotations;

namespace P2_2020AM601_2020CT601.Models
{
    public class casosReportados
    {
        [Key]
        public int IdCasosconfirmados { get; set; }

        public int numCasosconfirmados { get; set; }

        public int numCasosrecuperados { get; set; }

        public int numCasosfallecidos { get; set; }

        public int Idgenero { get; set; }

        public int Iddepartamento { get; set; }

    }
}
