using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRESTSharp.Models;

namespace TestRESTSharp.Models
{
    public class User
    {
        public string userId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public int userRoleId { get; set; }
        public string userPhoto { get; set; }
    }

    public class AuthData
    {
        public string token { get; set; }
        public User user { get; set; }
    }

    public class IdentityChecks
    {
        public bool backgroundIsNotChecked { get; set; }
        public bool isNeedToBackgroundCheckAgain { get; set; }
        public bool creditScreeningIsNotChecked { get; set; }
        public bool isNeedToCreditScreeningCheckAgain { get; set; }
        public bool isMatch { get; set; }

        public static bool operator ==(IdentityChecks first, IdentityChecks second)
        {
            return (first.backgroundIsNotChecked == second.backgroundIsNotChecked &&
                    first.isNeedToBackgroundCheckAgain == second.isNeedToBackgroundCheckAgain &&
                    first.creditScreeningIsNotChecked == second.creditScreeningIsNotChecked &&
                    first.isNeedToCreditScreeningCheckAgain == second.isNeedToCreditScreeningCheckAgain &&
                    first.isMatch == second.isMatch);
        }
        public static bool operator !=(IdentityChecks first, IdentityChecks second)
        {
            return (first.backgroundIsNotChecked != second.backgroundIsNotChecked ||
                    first.isNeedToBackgroundCheckAgain != second.isNeedToBackgroundCheckAgain ||
                    first.creditScreeningIsNotChecked != second.creditScreeningIsNotChecked ||
                    first.isNeedToCreditScreeningCheckAgain != second.isNeedToCreditScreeningCheckAgain ||
                    first.isMatch != second.isMatch);
        }
    }

    public class LoginResponse
    {
        public AuthData authData { get; set; }
        public IdentityChecks identityChecks { get; set; }
    }

}
