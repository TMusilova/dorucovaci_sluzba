using System.ComponentModel.DataAnnotations;

namespace DorucovaciSluzba.Models.Package
{
    public class TrackPackageViewModel
    {
        // ČÍSLO ZÁSILKY
        [Required(ErrorMessage = "Číslo zásilky je povinné")]
        [Display(Name = "Číslo zásilky")]
        [RegularExpression(@"^\d{3}-\d{2}-\d{2}$", ErrorMessage = "Formát: xxx-xx-xx")]
        public string CisloZasilky { get; set; } = string.Empty;

        // E-MAIL
        [Required(ErrorMessage = "E-mail je povinný")]
        [EmailAddress(ErrorMessage = "Neplatný formát e-mailu")]
        [Display(Name = "E-mail")]
        public string Email { get; set; } = string.Empty;
    }
}
