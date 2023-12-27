using Identity.Domain.Entities;

namespace Identity.Application.Common.Identity.Services;

public interface IUserService
{
    ValueTask<User?> GetByIdAsync(Guid userId, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<User?> GetByEmailAddressAsync(string emailAddress, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<User> CreateAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<User> UpdateAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default);

    // ValueTask<User?> GetByIdAsync(Guid userId);
    //
    // ValueTask<User> CreateAsync(User user);
    //
    // ValueTask<User> UpdateAsync(User user);
}