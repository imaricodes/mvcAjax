using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcAjax.Models
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string [] Hobbies { get; set; }
    }
}