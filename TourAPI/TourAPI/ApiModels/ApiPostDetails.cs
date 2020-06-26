using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourAPI.ApiModels
{
    public class ApiPostDetails
    {
        public int DetailsId { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int? Quantity { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? TimeStamp { get; set; }
    }
}
