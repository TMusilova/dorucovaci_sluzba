using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DorucovaciSluzba.Domain.Validations
{
    public class FirstLetterCapitalizedCZAttribute : ValidationAttribute
    {
        public FirstLetterCapitalizedCZAttribute()
        {
            ErrorMessage = "První písmeno musí být velké";
        }

        public override bool IsValid(object value)
        {
            if (value == null) return true;

            string input = value.ToString().Trim();

            // Musí začínat velkým písmenem a obsahovat pouze české znaky
            return Regex.IsMatch(input, @"^[A-ZÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ][a-záčďéěíňóřšťúůýž]+$");
        }
    }
}
