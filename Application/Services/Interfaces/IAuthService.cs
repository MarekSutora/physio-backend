using Application.Common.Auth;
using Application.DTO.Auth;

namespace Application.Services.Interfaces
{
    public interface IAuthService
    {
        Task<RegisterUserResult> RegisterClientAsync(RegisterRequestDto registerRequestDto);

        Task<LoginUserResult> LoginUserAsync(LoginRequestDto loginRequestDto);

        Task ConfirmEmailAsync(string userId, string code);

        Task ForgotPasswordAsync(ForgotPasswordRequestDto forgotPasswordRequestDto);

        Task ResetPasswordAsync(ResetPasswordRequestDto resetPasswordRequestDto);

        Task<LoginUserResult> RefreshTokenAsync(string refreshToken);

        Task<bool> VerifyClientByIdAsync(int personId, string userId);
    }
}
