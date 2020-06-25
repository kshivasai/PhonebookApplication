using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhonebookApplication.Models
{
    public class Newdata
    {
        [Required(ErrorMessage ="Please Enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public String Address_line_1 { get; set; }
        public string Address_line_2 { get; set; }
        [Required(ErrorMessage ="Please Enter your city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Pincode is required.")]
        public int Pincode { get; set; }
        [Required(ErrorMessage = "Phonenumber is required.")]
        public Int64 Phonenumber { get; set; }
    }
}