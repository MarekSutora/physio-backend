using Application.Common.Auth;
using Azure;
using Shared.DTO.Auth;

namespace Application.Services.Interfaces
{
    public interface IAuthService
    {
        Task<RegisterUserResult> RegisterPatientAsync(RegisterRequestDto registerRequestDto, string Url);

        Task<LoginUserResult> LoginUserAsync(LoginRequestDto loginRequestDto);

        Task<bool> ConfirmEmailAsync(string userId, string code);

        Task ForgotPasswordAsync(ForgotPasswordRequestDto forgotPasswordRequestDto);

        Task<ResetPasswordResult> ResetPasswordAsync(ResetPasswordRequestDto resetPasswordRequestDto);

        Task<LoginUserResult> RefreshTokenAsync(string refreshToken);

        Task<bool> VerifyClientById(int clientId, string userId);
    }
}
