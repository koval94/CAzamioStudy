using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRESTSharp.Models
{
    public class UserProfileViewModel
    {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string email { get; set; } = null;
            public string address { get; set; }
            public string phoneNumber { get; set; }
            public object profilePhoto { get; set; } 
    }
}
