using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace datatable_app.Models
{
    public class User
    {
        [Required]
        public string Div { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string RollNo { get; set; }

        public string country { get; set; }
    }
}