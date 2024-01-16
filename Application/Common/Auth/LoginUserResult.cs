using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Auth
{
    public class LoginUserResult
    {
        public LoginUserOutcome Outcome { get; set; }
        public string AccessToken { get; set; }     
        public string RefreshToken { get; set; }

        public DateTime ExpiryDate { get; set; }

        public enum LoginUserOutcome
        {
            Success,
            UserNotRegistered,
            InvalidCredentials,
            AccountNotConfirmed
        }
    }
}
