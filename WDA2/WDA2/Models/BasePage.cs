using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
namespace WDA2.Models
{
    public class BasePage
    {
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Display(Name = "Age")]
            public string Age { get; set; }

            [Display(Name = "Email")]
            public string Email { get; set; }
        }
}