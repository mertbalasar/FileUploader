using FileUploader.Entities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileUploader.Entities.Attributes;
using FileUploader.Entities.Base;

namespace FileUploader.Entities.Models
{
    [CollectionName("user")]
    public class User : CollectionBase
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName { get => FirstName + " " + LastName; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public DateTime? TokenExpireAt { get; set; }
        public DateTime? BirthDay { get; set; }
        public bool IsPremium { get; set; } = false;
    }
}
