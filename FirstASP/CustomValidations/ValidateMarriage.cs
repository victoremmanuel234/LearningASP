using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;

namespace FirstASP.CustomValidations;

public class ValidateMarriage : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        return base.IsValid(value, validationContext);
    }

}
