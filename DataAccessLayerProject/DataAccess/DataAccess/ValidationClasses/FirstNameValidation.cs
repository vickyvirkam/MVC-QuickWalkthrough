using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAccess.ValidationClasses
{
    public class FirstNameValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Plz Provide the FirstName");
            }
            else {
                if (value.ToString().Contains("@"))
                {
                    return new ValidationResult("FirstName should not contain @");
                }
            
            }

            return ValidationResult.Success;
        }
    }
}