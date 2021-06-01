using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppSoulinthavong.Models
{
    public class CalculateAge
    {
        [Required(ErrorMessage = "Please enter your first name.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1900,2020, ErrorMessage = "Year entered must be between 1900 and 2020.")]
        public int? BirthYear { get; set; }

        public string AgeThisYear()
        {
            const int THIS_YEAR = 2021;
            int userAge;

            userAge = THIS_YEAR - BirthYear.Value;

            return this.Name + ", you will be " + userAge + " by the end of " + THIS_YEAR + ".";
        }
    }
}
