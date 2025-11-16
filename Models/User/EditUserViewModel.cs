using DorucovaciSluzba.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace DorucovaciSluzba.Models.User
{
    public class EditUserViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Jméno je povinné")]
        [Display(Name = "Jméno")]
        public string Jmeno { get; set; } = string.Empty;

        [Required(ErrorMessage = "Příjmení je povinné")]
        [Display(Name = "Příjmení")]
        public string Prijmeni { get; set; } = string.Empty;

        [Required(ErrorMessage = "E-mail je povinný")]
        [Display(Name = "E-mail")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Telefon")]
        [Phone(ErrorMessage = "Neplatný formát telefonu")]
        public string? Telefon { get; set; }

        [Display(Name = "Datum narození")]
        [DataType(DataType.Date)]
        public DateTime? DatumNarozeni { get; set; }

        // ADRESA
        [Display(Name = "Ulice")]
        public string? Ulice { get; set; }

        [Display(Name = "Číslo popisné")]
        public string? CP { get; set; }

        [Display(Name = "Město")]
        public string? Mesto { get; set; }

        [RegularExpression(@"^\d{3} \d{2}$", ErrorMessage = "PSČ musí být ve formátu 700 30")]
        [Display(Name = "PSČ")]
        public string? Psc { get; set; }

        // ROLE
        [Required]
        [Display(Name = "Role uživatele")]
        public int TypId { get; set; }

        // Pro dropdown
        public List<TypUzivatel>? DostupneRole { get; set; }
    }
}
