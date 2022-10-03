using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace datatable_app.Models
{
    public class Countrycs
    {
 
       
        [Required]
        public string Cname { get; set; }
        [Required]
        public string Value { get; set; }
       
        
    }
}