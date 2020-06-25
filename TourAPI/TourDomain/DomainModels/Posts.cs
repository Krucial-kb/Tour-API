using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.DomainModels
{
    public class Posts
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public byte[] Media { get; set; }
        public string Comment { get; set; }
    }
}
