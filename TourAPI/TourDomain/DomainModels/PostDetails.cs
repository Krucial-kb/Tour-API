using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.DomainModels
{
    public class PostDetails
    {
        public int DetailsId { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
