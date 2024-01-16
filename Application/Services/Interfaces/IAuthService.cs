using Application.Common.Auth;
using Azure;
using Shared.DTO.Auth;

namespace Application.Services.Interfaces
{
    public interface IAuthService
    {
        Task<RegisterUserResult> RegisterUserAsync(RegisterRequestDto registerRequestDto);

        Task<LoginUserResult> LoginUserAsync(LoginRequestDto loginRequestDto);

        Task<ConfirmEmailResult> ConfirmEmailAsync(ConfirmEmailRequestDto confirmEmailRequestDto);

        Task ForgotPasswordAsync(ForgotPasswordRequestDto forgotPasswordRequestDto);

        Task<ResetPasswordResult> ResetPasswordAsync(ResetPasswordRequestDto resetPasswordRequestDto);

        Task<LoginUserResult> RefreshTokenAsync(string refreshToken);
    }
}
