using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _fakeDb = new()
    {
        new User
        {
            Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), // Guid.NewGuid(),
            Name = "Jorge Bublitz",
            Email = "jorge@bublitz.com",
            PasswordHash = "hash123"
        }
    };

    public Task<User?> GetByIdAsync(Guid id)
    {
        var user = _fakeDb.FirstOrDefault(u => u.Id == id);
        return Task.FromResult(user);
    }
}
