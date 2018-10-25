﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace FormVal.Models
{
    [Table("tblRegister")]
    public class Register
    {
        [Key]
        [Required(ErrorMessage ="User Id Required")]
        public string UserId { get; set; }
        [StringLength(15,MinimumLength =4, ErrorMessage ="User Name 4 to 15 chars")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password Mismatch")]
        public string ConfirmPassword { get; set; }
        [Range(15,30,ErrorMessage ="Age 15 to 30 only")]
        public int? Age { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [RegularExpression(@"\+91[0-9]{10}",ErrorMessage ="Invalid Mobile")]
        public string Mobile { get; set; }
    }
}