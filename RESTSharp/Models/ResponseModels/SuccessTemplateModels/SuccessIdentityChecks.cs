using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRESTSharp.Models.ResponseModels
{
    public static class SuccessIdentityChecks 
    {
        public static IdentityChecks getSuccessfulIdentityChecks()
        {
            IdentityChecks identityChecks = new IdentityChecks();
            LoginResponse loginResponse = new LoginResponse();
            identityChecks = new IdentityChecks();
            identityChecks.backgroundIsNotChecked = false;
            identityChecks.isNeedToBackgroundCheckAgain = false;
            identityChecks.creditScreeningIsNotChecked = false;
            identityChecks.isNeedToCreditScreeningCheckAgain = false;
            identityChecks.isMatch = false;
            return identityChecks;
        }
    }
}

