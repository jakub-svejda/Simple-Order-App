using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOrderApp.Models
{
    public class RateModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public int Order { get; set; }
    }
}