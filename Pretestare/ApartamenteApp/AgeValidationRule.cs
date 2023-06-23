using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ApartamenteApp
{
    public class AgeValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            int age;
            int.TryParse(value as string, out age);
            if (age > 120 || age < 18) return new ValidationResult(false, "Invalid age.");

            return ValidationResult.ValidResult;
        }
    }
}
