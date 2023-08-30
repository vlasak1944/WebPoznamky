using System.ComponentModel.DataAnnotations;
namespace WebPoznamky.Models
{
    public class Uzivatel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Jmeno { get; set; }
        [Required]
        public string Heslo { get; set; }
        [Required]
        public List<Poznamka> Poznamky { get; set; }
    }
}
