using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProjeto.Core.CustomValidations
{
    public class MyValidationMethods
    {
        public static ValidationResult ValidateGreaterOrEqualToZero(double value, ValidationContext context)
        {
            bool isValid = true;

            if (value <= 0)
            {
                isValid = false;
            }

            if (isValid)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(string.Format("The Field {0} must be greater than or equal to 0", context.MemberName), new List<string> { context.MemberName });
            }

        }


    }

}