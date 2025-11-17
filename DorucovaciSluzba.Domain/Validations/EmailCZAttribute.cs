using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DorucovaciSluzba.Domain.Validations
{
    public class EmailCZAttribute : ValidationAttribute
    {
        public EmailCZAttribute()
        {
            ErrorMessage = "E-mailová adresa není platná";
        }

        public override bool IsValid(object value)
        {
            if (value == null) return true;

            string input = value.ToString().Trim();

            // Pouze čísla od 1 do 4 číslic
            return Regex.IsMatch(input, @"^[^@\s]+@[^@\s]+\.[a-zA-Z]{2,63}$");
        }
    }
}
