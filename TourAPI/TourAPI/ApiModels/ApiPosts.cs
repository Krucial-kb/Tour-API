using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourAPI.ApiModels
{
    public class ApiPosts
    {
        public int PostId { get; set; }
        [MaxLength(150, ErrorMessage = "Too many chars")]
        public string Title { get; set; }
        [Required]
        public byte[] Media { get; set; }
        public string Comment { get; set; }

    }
}
