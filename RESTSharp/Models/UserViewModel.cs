﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;


namespace TestRESTSharp.Models
{
    public class UserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
