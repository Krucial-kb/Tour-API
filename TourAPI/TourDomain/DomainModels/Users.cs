using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.DomainModels
{
    public class Users
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] ProfilePic { get; set; }
        public int? Posts { get; set; }
    }
}
