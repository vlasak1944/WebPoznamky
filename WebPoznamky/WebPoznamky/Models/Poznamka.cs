using System.ComponentModel.DataAnnotations;
namespace WebPoznamky.Models
{
    public class Poznamka
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nadpis { get; set; }
        [Required]
        public string Telo{ get; set; }
        [Required]

        public Uzivatel Autor { get; set; }
    }
}
