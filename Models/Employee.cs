using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Basics.Models
{
    public class Employee
    {
        [Required]
        public int EmpId{ get; set; }
        public string EmpName { get; set; }
    }
}