using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class MovieMaxReleaseDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.ReleaseDate <= DateTime.Now)
                return ValidationResult.Success;

            else
                return new ValidationResult("Release date cannot be greater than today.");
        }
    }
}
