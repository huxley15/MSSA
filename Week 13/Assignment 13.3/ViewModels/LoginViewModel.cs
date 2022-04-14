﻿//step 16.6
using System.ComponentModel.DataAnnotations;

namespace Assignment12._1.ViewModels
{
    //step 15.6
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter user name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
