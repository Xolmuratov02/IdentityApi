using Identity.Domain.Entities;

namespace Identity.Persistence.Repositories.Interfaces;

public interface IAccessTokenRepository
{
    ValueTask<AccessToken> CreateAsync(
        AccessToken token,
        bool saveChanges = true,
        CancellationToken cancellationToken = default
    );
}