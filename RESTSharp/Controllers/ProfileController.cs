using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRESTSharp.Models;

namespace TestRESTSharp.Controllers
{
    public class ProfileController
    {
    // This class contains each Method this controller supported and executs from Test class
        public ProfileController()
        {
            //Container for general data(parameters etc) required for methods 
        }
        public UserProfileViewModel UpdateProfile(UserProfileViewModel userProfile, string token)
        {
            return userProfile;
        }
    }
}
