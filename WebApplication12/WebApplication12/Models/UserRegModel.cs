using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication12.Models
{
    public class UserRegModel
    {
        [Required]
        [DisplayName("User ID")]
        public int id { get; set; }

        [Required]
        [DisplayName("Email ID")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="please enter valid email")]
        public string emailid { get; set; }

        [Required]
        [DisplayName("User Password")]
      // [RegularExpression("^(?=.*[A-Z])(?=.*[a-z])(?=.*/d)(?=.*[$@$!%*?&])[A-Za-z/d$@$!%?&]{8,}", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 Uppercase Alphabet, 1 Lowercase Alphabet, 1 Number and 1 Special Character")]
        public string password { get; set; }

        [Required]
        [DisplayName("User Name")]
        [StringLength(20, ErrorMessage = "Name not be exceed")]
        public string name { get; set; }


        
        public string Gender { get; set; }

    }
}