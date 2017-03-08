using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blockbuster.Models
{
    public class Min18YearsIfMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //VALIDATION LOGIC HERE.

            //Get Access to Customer
            var customer = (Models.Customer) validationContext.ObjectInstance;

            if (customer.MembershipTypesId == MembershipType.Unknown //when dont select membershiptype
                || customer.MembershipTypesId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }

            if(customer.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            //calculate the age
            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer should be at leat 18 years old to go on Membership");
        }
    }
}