using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TourAPI.ApiModels
{
    public class ApiUsers
    {
        public int UserId { get; set; }

        [Required]
        [DataMember(Name = "First Name")]
        [MaxLength(50, ErrorMessage = "Too many chars")]
        [MinLength(1, ErrorMessage = "First name can't be empty")]
        public string FirstName { get; set; }

        [Required]
        [DataMember(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "Too many chars")]
        [MinLength(1, ErrorMessage = "Last name can't be empty")]
        public string LastName { get; set; }

        [Required]
        [DataMember(Name = "UserName")]
        [MaxLength(50, ErrorMessage = "Too many chars")]
        [MinLength(1, ErrorMessage = "Username can't be empty")]
        public string UserName { get; set; }

        [Required]
        [DataMember(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(100, ErrorMessage = "Too many chars")]
        [MinLength(1, ErrorMessage = "Email can't be empty")]
        public string Email { get; set; }

        [Required]
        [DataMember(Name = "Password")]
        [DataType(DataType.Password)]
        [MaxLength(50, ErrorMessage = "Too many chars")]
        [MinLength(1, ErrorMessage = "Password can't be empty")]
        public string Password { get; set; }

        public byte[] ProfilePic { get; set; }

        public int? Posts { get; set; }
    }
}
