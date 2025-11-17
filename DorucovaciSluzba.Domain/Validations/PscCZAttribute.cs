using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DorucovaciSluzba.Domain.Validations
{
    public class PscCZAttribute : ValidationAttribute
    {
        public PscCZAttribute()
        {
            ErrorMessage = "PSČ musí být ve formátu 12345 nebo 123 45";
        }

        public override bool IsValid(object value)
        {
            if (value == null) return true;

            string input = value.ToString();

            // PSČ musí obsahovat přesně 5 číslic
            return Regex.IsMatch(input, @"^\d{5}|\d{3}\s\d{2}$");
        }
    }
}
