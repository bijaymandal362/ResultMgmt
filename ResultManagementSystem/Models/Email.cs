﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResultManagementSystem.Models
{
    public class Email
    {
        public string To { get; set; }
        public string Body { get; set; }
        public string From { get; set; }
        public string Text { get; set; }
    }
}
