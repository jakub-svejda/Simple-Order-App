﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOrderApp.Models
{
    public class JobModel
    {
        public string Description { get; set; }
        public double Hours { get; set; }
        public bool IsEditing { get; set; }
    }
}