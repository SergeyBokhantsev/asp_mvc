using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvc_e1.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please, your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, your mail")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please, your Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please, select an option")]
        public bool? WillAttend { get; set; }
    }
}