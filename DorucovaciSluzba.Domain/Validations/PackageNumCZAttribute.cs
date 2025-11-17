using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DorucovaciSluzba.Domain.Validations
{
    public class PackageNumCZAttribute : ValidationAttribute
    {
        public PackageNumCZAttribute()
        {
            ErrorMessage = "Číslo zásilky musí být ve formátu 123-45-67";
        }

        public override bool IsValid(object value)
        {
            if (value == null) return true;

            string input = value.ToString().Trim();

            // Pouze čísla ve formátu xxx-xx-xx
            return Regex.IsMatch(input, @"^\d{3}-\d{2}-\d{2}$");
        }
    }
}
