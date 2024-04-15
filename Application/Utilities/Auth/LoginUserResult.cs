using System.Text.Json.Serialization;

namespace Application.Common.Auth
{
    public class LoginUserResult
    {
        [JsonIgnore]
        public string FullName { get; set; }
        public string UserId { get; set; }
        public int PersonId { get; set; }
        public LoginUserOutcome Outcome { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public DateTime ExpiryDate { get; set; }
        public IList<string> roles { get; internal set; }

        public enum LoginUserOutcome
        {
            Success,
            UserNotRegistered,
            InvalidCredentials,
            EmailNotConfirmed,
            UserLockedOut
        }
    }
}
