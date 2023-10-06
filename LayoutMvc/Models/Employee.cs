using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LayoutMvc.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Birth { get; set; }
        public string Address { get; set; }
    }
}