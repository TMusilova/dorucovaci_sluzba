using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DorucovaciSluzba.Domain.Validations
{
    public class CpCZAttribute : ValidationAttribute
    {
        public CpCZAttribute()
        {
            ErrorMessage = "Číslo popisné musí být číslo";
        }

        public override bool IsValid(object value)
        {
            if (value == null) return true;

            string input = value.ToString().Trim();

            // Pouze čísla od 1 do 4 číslic
            return Regex.IsMatch(input, @"^\d{1,4}$");
        }
    }
}
