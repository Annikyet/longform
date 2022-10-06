using System;
using System.Collections.Generic;

namespace longform.Models
{
    public class Profile
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string ProfileImgId { get; set; }
    }
    public class Account : Profile
    {
        public string Email { get; set; }
    }
}