namespace TaskFlow.Application.DTOs.Auth
{
   public record RegisterRequestDto(
    string FullName,
    string Email,
    string Password
);

}