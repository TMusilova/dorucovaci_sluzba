using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class PhoneCZAttribute : ValidationAttribute
{
    public PhoneCZAttribute()
    {
        ErrorMessage = "Telefonní číslo musí být ve formátu 123456789 nebo 123 456 789";
    }

    public override bool IsValid(object value)
    {
        if (value == null) return true;

        string input = value.ToString().Trim();

        // Povolené formáty: 9 číslic nebo 3 skupiny po 3 číslicích oddělené mezerou
        return Regex.IsMatch(input, @"^(\d{9}|\d{3}\s\d{3}\s\d{3})$");
    }
}