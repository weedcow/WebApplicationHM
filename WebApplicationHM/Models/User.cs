using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationHM.Models
{
    public class User
    {
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        [HiddenInput]
        public string ReturnURL { get; set; }
    }
}