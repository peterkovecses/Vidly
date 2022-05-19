using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Dtos;

namespace Vidly.Models
{
    public class MusicAlbumMaxReleaseDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var musicAlbum = (MusicAlbumDto)validationContext.ObjectInstance;

            if (musicAlbum.ReleaseDate <= DateTime.Now)
                return ValidationResult.Success;

            else
                return new ValidationResult("Release date cannot be greater than today.");
        }
    }
}
