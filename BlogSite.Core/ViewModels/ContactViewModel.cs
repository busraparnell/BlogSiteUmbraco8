using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core;

namespace BlogSite.Core.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "You must enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your message")]
        [MaxLength(length:500, ErrorMessage = "Your message must be max 500 characters")]
        public string Message { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "DateTime")]
        public DateTime DateTime { get; set; }

        public int ContactFormId { get; set; }
    }
}
