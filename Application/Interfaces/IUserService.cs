using Application.Dtos;

namespace Application.Interfaces;

public interface IUserService
{
    Task<UserResponseDto?> GetUserByIdAsync(Guid id);
}
