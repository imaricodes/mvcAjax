using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcAjax.Models
{
    public class ProcessModel
    {
        public string Input { get; set; }

        public ProcessModel(string input)
        {
            this.Input = input.ToUpper();
        }
            
    }
}