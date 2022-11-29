using System;
using System.ComponentModel.DataAnnotations;
namespace ApiDemo.Models
{
    public class UserModel
    {
        [Required]
        public string FirstName { get; set; }

    }
}

