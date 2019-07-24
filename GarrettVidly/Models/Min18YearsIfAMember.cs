using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarrettVidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //  *** validationContext.ObjectInstance <- Gives Access to the containing class
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknowm || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.BirthDate == null)
                return new ValidationResult("Birthdate is required.");

            return (customer.BirthDate.Value.AddYears(18) > DateTime.Now) 
                ? new ValidationResult("Customer must be at least 18 years of age for a memebership.") 
                : ValidationResult.Success;
           
        }
    }
}